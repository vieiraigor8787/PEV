using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PEV.Classes;
using PEV.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace PEV.Data
{
    public class ProdutoDB
    {

        public bool InserirDados(ProdutoModel obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    Culture = new System.Globalization.CultureInfo("pt-BR")
                };
                
                obj.JsonLTFoto = obj.JsonLTFoto.Replace("Descricao", "Caminho");
                obj.JsonLTGenero = obj.JsonLTGenero.Replace("Codigo", "CodigoGenero");
                obj.JsonLTSubcategoria = obj.JsonLTSubcategoria.Replace("Codigo", "CodigoSubcategoria");

                var prodFotos = JsonConvert.DeserializeObject<List<tb_produto_foto>>(obj.JsonLTFoto, settings);
                var proGeneros = JsonConvert.DeserializeObject<List<tb_produto_genero>>(obj.JsonLTGenero, settings);
                var proSubcategoria = JsonConvert.DeserializeObject<List<tb_produto_subcategoria>>(obj.JsonLTSubcategoria, settings);

                sSQL = "insert into tb_produto (CodigoInterno, Nome, Descricao, valor, dataregistro, peso, quantidade, ativo, tamanho, MensagemEstoque)values(@codigointerno, @nome, @descricao, @valor, Now(), @peso, @quantidade, @ativo, @tamanho, @MensagemEstoque)";
                cmd.Parameters.AddWithValue("@codigointerno", obj.tb_produto.CodigoInterno);
                cmd.Parameters.AddWithValue("@nome", obj.tb_produto.Nome);
                cmd.Parameters.AddWithValue("@descricao", obj.tb_produto.Descricao);
                cmd.Parameters.AddWithValue("@valor", obj.tb_produto.Valor);
                cmd.Parameters.AddWithValue("@peso", obj.tb_produto.Peso);
                cmd.Parameters.AddWithValue("@quantidade", obj.tb_produto.Quantidade);
                cmd.Parameters.AddWithValue("@ativo", obj.tb_produto.Ativo);
                cmd.Parameters.AddWithValue("@tamanho", obj.tb_produto.Tamanho);
                cmd.Parameters.AddWithValue("@MensagemEstoque", obj.tb_produto.MensagemEstoqueBaixo);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                int result = cmd.ExecuteNonQuery();

                if (result==1) {
                    int CodigoProduto = 0;
                    cmd.Parameters.Clear();
                    sSQL = "select CodigoProduto from tb_produto order by CodigoProduto desc limit 1 ";
                    cmd.CommandText = sSQL;
                    var DrCodP = cmd.ExecuteReader();

                    if (DrCodP.HasRows)
                    {
                        DrCodP.Read();
                        CodigoProduto = Convert.ToInt32(DrCodP["CodigoProduto"].ToString());
                        DrCodP.Close();
                    }
                    else {
                        return false;
                    }
                    //Fotos
                    foreach (var item in prodFotos) {
                        cmd.Parameters.Clear();
                        cmd.Connection = cn;
                        sSQL = "insert into  tb_produto_foto (CodigoProduto,Caminho)values(@CodigoProduto,@Caminho)";
                        cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);
                        cmd.Parameters.AddWithValue("@Caminho", item.Caminho);
                        cmd.CommandText = sSQL;
                        cmd.ExecuteNonQuery();
                    }

                    string Tabela = "";
                    string Coluna = "";
                    int Codigo = 0;

                    //Generos                    
                    foreach (var item in proGeneros)
                    {
                        Tabela = "tb_produto_genero";
                        Coluna = "CodigoGenero";
                        Codigo = item.CodigoGenero;

                        cmd.Parameters.Clear();
                        cmd.Connection = cn;
                        sSQL = "insert into  " + Tabela + " (" + Coluna + ",CodigoProduto)values(@Codigo,@CodigoProduto)";
                        cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);
                        cmd.Parameters.AddWithValue("@Codigo", Codigo);
                        cmd.CommandText = sSQL;
                        cmd.ExecuteNonQuery();
                    }

                    //Categorias                   
                    foreach (var item in proSubcategoria)
                    {
                        Codigo = item.CodigoSubCategoria;

                        cmd.Parameters.Clear();
                        cmd.Connection = cn;
                        sSQL = "insert into  tb_produto_subcategoria (CodigoSubCategoria ,CodigoProduto)values(@Codigo,@CodigoProduto)";
                        cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);
                        cmd.Parameters.AddWithValue("@Codigo", Codigo);
                        cmd.CommandText = sSQL;
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }

        public bool UpdateDados(ProdutoModel obj)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    Culture = new System.Globalization.CultureInfo("pt-BR")
                };

                obj.JsonLTFoto = obj.JsonLTFoto.Replace("Descricao", "Caminho");
                obj.JsonLTGenero = obj.JsonLTGenero.Replace("Codigo", "CodigoGenero");
                obj.JsonLTSubcategoria = obj.JsonLTSubcategoria.Replace("Codigo", "CodigoSubcategoria");

                var prodFotos = JsonConvert.DeserializeObject<List<tb_produto_foto>>(obj.JsonLTFoto, settings);
                var proGeneros = JsonConvert.DeserializeObject<List<tb_produto_genero>>(obj.JsonLTGenero, settings);
                var proSubcategoria = JsonConvert.DeserializeObject<List<tb_produto_subcategoria>>(obj.JsonLTSubcategoria, settings);

                sSQL = " update tb_produto set CodigoInterno=@codigointerno, Nome=@nome, Descricao=@descricao, valor=@valor, peso=@peso, quantidade=@quantidade, ativo=@ativo," +
                       " tamanho=@tamanho, MensagemEstoque=@MensagemEstoque where CodigoProduto=" + obj.tb_produto.CodigoProduto;

                cmd.Parameters.AddWithValue("@codigointerno", obj.tb_produto.CodigoInterno);
                cmd.Parameters.AddWithValue("@nome", obj.tb_produto.Nome);
                cmd.Parameters.AddWithValue("@descricao", obj.tb_produto.Descricao);
                cmd.Parameters.AddWithValue("@valor", obj.tb_produto.Valor);                
                cmd.Parameters.AddWithValue("@peso", obj.tb_produto.Peso);
                cmd.Parameters.AddWithValue("@quantidade", obj.tb_produto.Quantidade);
                cmd.Parameters.AddWithValue("@ativo", obj.tb_produto.Ativo);
                cmd.Parameters.AddWithValue("@tamanho", obj.tb_produto.Tamanho);
                cmd.Parameters.AddWithValue("@MensagemEstoque", obj.tb_produto.MensagemEstoqueBaixo);
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    sSQL = " delete from tb_produto_foto where CodigoProduto=" + obj.tb_produto.CodigoProduto +";";
                    sSQL += "delete from tb_produto_genero where CodigoProduto=" + obj.tb_produto.CodigoProduto + ";";
                    cmd.Parameters.Clear();
                    cmd.Connection = cn;
                    cmd.CommandText = sSQL;
                    cmd.ExecuteNonQuery();

                    //Fotos
                    foreach (var item in prodFotos)
                    {
                        cmd.Parameters.Clear();
                        cmd.Connection = cn;
                        sSQL = "insert into  tb_produto_foto (CodigoProduto,Caminho)values(@CodigoProduto,@Caminho)";
                        cmd.Parameters.AddWithValue("@CodigoProduto", obj.tb_produto.CodigoProduto);
                        cmd.Parameters.AddWithValue("@Caminho", item.Caminho);
                        cmd.CommandText = sSQL;
                        cmd.ExecuteNonQuery();
                    }

                    string Tabela = "";
                    string Coluna = "";
                    int Codigo = 0;

                    //Generos                    
                    foreach (var item in proGeneros)
                    {
                        Tabela = "tb_produto_genero";
                        Coluna = "CodigoGenero";
                        Codigo = item.CodigoGenero;

                        cmd.Parameters.Clear();
                        cmd.Connection = cn;
                        sSQL = "insert into  " + Tabela + " (" + Coluna + ",CodigoProduto)values(@Codigo,@CodigoProduto)";
                        cmd.Parameters.AddWithValue("@CodigoProduto", obj.tb_produto.CodigoProduto);
                        cmd.Parameters.AddWithValue("@Codigo", Codigo);
                        cmd.CommandText = sSQL;
                        cmd.ExecuteNonQuery();
                    }

                    //Categorias                   
                    foreach (var item in proSubcategoria) 
                    {
                        Codigo = item.CodigoSubCategoria;

                        cmd.Parameters.Clear();
                        cmd.Connection = cn;
                        sSQL = "insert into  tb_produto_subcategoria (CodigoSubCategoria ,CodigoProduto)values(@Codigo,@CodigoProduto)";
                        cmd.Parameters.AddWithValue("@CodigoProduto", obj.tb_produto.CodigoProduto);
                        cmd.Parameters.AddWithValue("@Codigo", Codigo);
                        cmd.CommandText = sSQL;
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }
 
        public List<SelectListItem> GetGenero()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_genero";
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                List<SelectListItem> LT = new List<SelectListItem>();

                while (Dr.Read())
                {
                    var item = new SelectListItem
                    {
                        Value = Dr["CodigoGenero"].ToString(),
                        Text = Dr["Descricao"].ToString(),
                    };

                    LT.Add(item);
                }
                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }


        public List<SelectListItem> GetSubcategoria()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_subcategoria where Ativo='Sim'";
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                List<SelectListItem> LT = new List<SelectListItem>();

                while (Dr.Read())
                {
                    var item = new SelectListItem
                    {
                        Value = Dr["CodigoSubCategoria"].ToString(),
                        Text = Dr["Nome"].ToString(),
                    };

                    LT.Add(item);
                }
                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public List<SelectListItem> GetCategoria()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_categoria";
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                List<SelectListItem> LT = new List<SelectListItem>();

                while (Dr.Read())
                {
                    var item = new SelectListItem
                    {
                        Value = Dr["CodigoCategoria"].ToString(),
                        Text = Dr["Descricao"].ToString(),
                    };

                    LT.Add(item);
                }
                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public List<SelectListItem> GetTamanho()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_tamanho";
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                List<SelectListItem> LT = new List<SelectListItem>();

                while (Dr.Read())
                {
                    var item = new SelectListItem
                    {
                        Value = Dr["CodigoTamanho"].ToString(),
                        Text = Dr["Descricao"].ToString(),
                    };
                    LT.Add(item);
                }
                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }
        public bool ValidarNome(tb_produto obj)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_produto where nome=@nome";
                cmd.Parameters.AddWithValue("@nome", obj.Nome);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();
                return Dr.HasRows;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }

        public bool ValidarTamanho(ProdutoModel obj)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_produto where Codigointerno=@codigointerno AND tamanho=@tamanho";

                cmd.Parameters.AddWithValue("@codigointerno", obj.tb_produto.CodigoInterno);
                cmd.Parameters.AddWithValue("@tamanho", obj.tb_produto.Tamanho);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();
                return Dr.HasRows;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }

        public List<tb_produto> GetAllProduto()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_produto order by nome";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_produto>();

                while (Dr.Read())
                {
                    var item = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]).AddHours(-3),
                        Quantidade = Convert.ToInt32(Dr["Quantidade"]),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Dr["Ativo"].ToString(),
                        Tamanho = Dr["Tamanho"].ToString(),
                        MensagemEstoqueBaixo = Dr["MensagemEstoque"].ToString()
                    };
                    Lista.Add(item);
                }

                return Lista;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public List<tb_produto> EstoqueBaixo()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT * FROM tb_produto WHERE Quantidade < 5 AND MensagemEstoque='Sim'";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_produto>();

                while (Dr.Read())
                {
                    var item = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]).AddHours(-3),
                        Quantidade = Convert.ToInt32(Dr["Quantidade"]),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Tamanho = Dr["Tamanho"].ToString()
                    };
                    Lista.Add(item);
                }

                return Lista;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public bool SemMensagemEstoque(int Cod)
        {
            try
            {
                string sSql = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSql = "UPDATE tb_produto SET MensagemEstoque='Não' WHERE CodigoProduto=" + Cod;
                cmd.CommandText = sSql;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
            return true;
        }

        public bool ValidaEstoque()

        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT * FROM tb_produto WHERE Quantidade < 5  AND MensagemEstoque='Sim'";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();
                return Dr.HasRows;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }

        public ProdutoModel GetProduto(int CodigoProduto) {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_produto where CodigoProduto=@CodigoProduto";
                cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var ProdM = new ProdutoModel();

                tb_produto tbPro=null;

                while (Dr.Read())
                {
                    tbPro = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]).AddHours(-3),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Quantidade = Convert.ToInt32(Dr["Quantidade"]),
                        Ativo = Dr["Ativo"].ToString(),
                        Tamanho = Dr["Tamanho"].ToString(),
                        MensagemEstoqueBaixo = Dr["MensagemEstoque"].ToString()
                    };                  
                }

                ProdM.tb_produto = tbPro;
                ProdM.JsonLTFoto = JsonConvert.SerializeObject(GetProdutoFoto(CodigoProduto));
                ProdM.JsonLTGenero = JsonConvert.SerializeObject(GetProdutoGenero(CodigoProduto));

                return ProdM;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public List<produtogeneroModel> GetProdutoGenero(int CodigoProduto)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = " Select A.*,B.* from tb_produto_genero as A,tb_genero as B" +
                       " WHERE A.CodigoGenero=B.CodigoGenero" +
                       " AND A.CodigoProduto=" + CodigoProduto;                

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<produtogeneroModel>();

                while (Dr.Read())
                {
                    var item = new produtogeneroModel
                    {
                        CodigoGenero = Convert.ToInt32(Dr["CodigoGenero"]),
                        CodigoProduto = CodigoProduto,
                        Descricao= Dr["Descricao"].ToString()
                    };
                    Lista.Add(item);
                }
                return Lista;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public List<produtofotoModel> GetProdutoFoto(int CodigoProduto)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = " Select A.*,B.* from tb_produto_foto as A,tb_produto as B" +
                       " WHERE A.CodigoProduto=B.CodigoProduto" +
                       " AND A.CodigoProduto=" + CodigoProduto;                

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<produtofotoModel>();

                while (Dr.Read())
                {
                    var item = new produtofotoModel
                    {
                        CodigoFoto = Convert.ToInt32(Dr["CodigoFoto"]),
                        Descricao = Dr["Caminho"].ToString(),                        
                        CodigoProduto = CodigoProduto
                    };
                    Lista.Add(item);
                }

                return Lista;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }
        public List<ProdutoVWList> GetProdutoVWList()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select *," +
                    "(select Caminho from tb_produto_foto where tb_produto_foto.CodigoProduto=tb_produto.CodigoProduto limit 1) as Foto" +
                    " from tb_produto WHERE Ativo='Sim' GROUP BY tb_produto.CodigoInterno";            

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var LT = new List<ProdutoVWList>();

                while (Dr.Read())
                {
                    var item = new ProdutoVWList();

                    item.tb_produto = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]).AddHours(-3),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Dr["Ativo"].ToString(),
                    };

                    item.Foto = Dr["Foto"].ToString();

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public List<ProdutoVWList> GetProdutoVWListBusca(string Nome)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select *," +
                    "(select Caminho from tb_produto_foto where tb_produto_foto.CodigoProduto=tb_produto.CodigoProduto limit 1) as Foto" +
                    " from tb_produto WHERE Nome LIKE'%" + Nome + "%' GROUP BY tb_produto.CodigoInterno";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var LT = new List<ProdutoVWList>();

                while (Dr.Read())
                {
                    var item = new ProdutoVWList();

                    item.tb_produto = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]).AddHours(-3),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Dr["Ativo"].ToString(),
                    };

                    item.Foto = Dr["Foto"].ToString();

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }


        public List<ProdutoVWList> GetProdutoVWListCategoria(string Descricao)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT p.CodigoProduto, ct.Descricao, p.CodigoInterno, p.Nome, p.Descricao, p.Valor, p.DataRegistro, p.Peso, p.Ativo, f.Caminho from tb_produto AS p " +
                        "LEFT JOIN tb_produto_foto AS f ON f.CodigoProduto = p.CodigoProduto " +
                        "INNER JOIN tb_produto_categoria AS c ON (p.CodigoProduto = c.CodigoProduto) " +
                        "INNER JOIN tb_categoria AS ct ON (c.CodigoCategoria = ct.CodigoCategoria)" +
                        "WHERE ct.Descricao='" + Descricao + "' " +
                        "GROUP BY p.CodigoInterno";


                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var LT = new List<ProdutoVWList>();

                while (Dr.Read())
                {
                    var item = new ProdutoVWList();

                    item.tb_produto = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]).AddHours(-3),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Dr["Ativo"].ToString(),
                    };

                    item.Foto = Dr["Caminho"].ToString();

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }



        public List<ProdutoVWList> GetProdutoVWListInfantil()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT p.CodigoProduto, p.CodigoInterno, p.Nome, p.Descricao, p.Valor, p.DataRegistro, p.Peso, p.Ativo, f.Caminho," +
                        "g.CodigoGenero from tb_produto AS p JOIN tb_produto_genero AS g ON g.CodigoProduto = p.CodigoProduto LEFT JOIN tb_produto_foto " +
                        "AS f ON f.CodigoProduto = p.CodigoProduto WHERE g.CodigoGenero =16 GROUP BY p.CodigoInterno";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var LT = new List<ProdutoVWList>();

                while (Dr.Read())
                {
                    var item = new ProdutoVWList();

                    item.tb_produto = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]).AddHours(-3),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Dr["Ativo"].ToString(),
                    };

                    item.Foto = Dr["Caminho"].ToString();

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public List<ProdutoVWList> GetProdutoVWListFeminino()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT p.CodigoProduto, p.CodigoInterno, p.Nome, p.Descricao, p.Valor, p.DataRegistro, p.Peso, p.Ativo, f.Caminho," +
                        "g.CodigoGenero from tb_produto AS p JOIN tb_produto_genero AS g ON g.CodigoProduto = p.CodigoProduto " +
                        "LEFT JOIN tb_produto_foto AS f ON f.CodigoProduto = p.CodigoProduto WHERE g.CodigoGenero =15 GROUP BY p.CodigoInterno";


                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var LT = new List<ProdutoVWList>();

                while (Dr.Read())
                {
                    var item = new ProdutoVWList();

                    item.tb_produto = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]).AddHours(-3),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Dr["Ativo"].ToString(),
                    };

                    item.Foto = Dr["Caminho"].ToString();

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public List<ProdutoVWList> GetProdutoVWListMasculino()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT p.CodigoProduto, p.CodigoInterno, p.Nome, p.Descricao, p.Valor, p.DataRegistro, p.Peso, p.Ativo, f.Caminho," +
                        "g.CodigoGenero from tb_produto AS p JOIN tb_produto_genero AS g ON g.CodigoProduto = p.CodigoProduto " +
                        "LEFT JOIN tb_produto_foto AS f ON f.CodigoProduto = p.CodigoProduto WHERE g.CodigoGenero=14 GROUP BY p.CodigoInterno";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var LT = new List<ProdutoVWList>();

                while (Dr.Read())
                {
                    var item = new ProdutoVWList();

                    item.tb_produto = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]).AddHours(-3),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Dr["Ativo"].ToString(),
                    };

                    item.Foto = Dr["Caminho"].ToString();

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public ProdutoView GetProdutoView(int CodigoProduto)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_produto where CodigoProduto=@CodigoProduto and ativo='sim'";
                cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();
                var ProdM = new ProdutoView();
                tb_produto tbPro = null;
                while (Dr.Read())
                {
                    tbPro = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]).AddHours(-3),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Dr["Ativo"].ToString(),
                    };
                }

                ProdM.tb_produto = tbPro;
                ProdM.produtofotoModel = GetProdutoFoto(CodigoProduto);
                ProdM.produtogeneroModel =GetProdutoGenero(CodigoProduto);

                return ProdM;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }


        public List<SelectListItem> GetTamanhoProduto(int CodigoProduto)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = " SELECT tb_produto.CodigoProduto, tb_produto.Tamanho FROM tb_produto";
                sSQL += " WHERE tb_produto.CodigoInterno = (SELECT A.CodigoInterno FROM tb_produto AS A WHERE A.CodigoProduto = "+ CodigoProduto + ")";
                sSQL += " And Ativo='Sim' GROUP BY tb_produto.CodigoProduto ,tb_produto.Tamanho ";
                sSQL += "order by case Tamanho when 'P' then 1 when 'M' then 2 when 'G' then 3 when 'GG' then 4 when 'EG' then 5 ELSE 6 END";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();
                List<SelectListItem> LT = new List<SelectListItem>();

                while (Dr.Read())
                {
                    var item = new SelectListItem
                    {
                        Value = Dr["CodigoProduto"].ToString(),
                        Text = Dr["Tamanho"].ToString(),
                    };

                    LT.Add(item);
                }
                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public int GetQtdProduto(int CodigoProduto)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = " SELECT Quantidade FROM tb_produto  WHERE CodigoProduto=" + CodigoProduto;                

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();
                Dr.Read();

                if (Dr.HasRows)
                {
                    return Convert.ToInt32(Dr["Quantidade"]);
                }
                else {
                    return 0;
                }               
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return 0;
            }
        }


        public List<ProdutoVWList> GetProdutoVWListProcura(string nome)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select *," +
                    "(select Caminho from tb_produto_foto where tb_produto_foto.CodigoProduto=tb_produto.CodigoProduto limit 1) as Foto" +
                    " from tb_produto where tb_produto.nome=@nome";

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();
                var LT = new List<ProdutoVWList>();
                while (Dr.Read())
                {
                    var item = new ProdutoVWList();
                    item.tb_produto = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]).AddHours(-3),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Dr["Ativo"].ToString(),
                    };
                    item.Foto = Dr["Foto"].ToString();
                    LT.Add(item);
                }
                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }
    }
}
