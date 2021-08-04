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
    public class SubCategoriaDB
    {

        public bool InserirDados(tb_subcategoria obj)
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

                obj.JsonLTCategoria = obj.JsonLTCategoria.Replace("Codigo", "CodigoCategoria");

                var proCategoria = JsonConvert.DeserializeObject<List<tb_categoria_subcategoria>>(obj.JsonLTCategoria, settings);

                sSQL = "insert into tb_subcategoria(Nome, Menu)values(@Nome, @Menu)";
                cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                cmd.Parameters.AddWithValue("@Menu", obj.Menu);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    int CodigoSubCategoria = 0;
                    cmd.Parameters.Clear();
                    sSQL = "select CodigoSubCategoria from tb_subcategoria order by CodigoSubCategoria desc limit 1 ";
                    cmd.CommandText = sSQL;
                    var DrCodP = cmd.ExecuteReader();

                    if (DrCodP.HasRows)
                    {
                        DrCodP.Read();
                        CodigoSubCategoria = Convert.ToInt32(DrCodP["CodigoSubCategoria"].ToString());
                        DrCodP.Close();
                    }
                    else
                    {
                        return false;
                    }

                    int Codigo = 0;
                    foreach (var item in proCategoria)
                    {
                        Codigo = item.CodigoCategoria;

                        cmd.Parameters.Clear();
                        cmd.Connection = cn;
                        sSQL = "insert into  tb_categoria_subcategoria (CodigoSubCategoria ,CodigoCategoria)values(@CodigoSubCategoria, @CodigoCategoria)";
                        cmd.Parameters.AddWithValue("@CodigoSubCategoria", CodigoSubCategoria);
                        cmd.Parameters.AddWithValue("@CodigoCategoria", Codigo);
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

        public bool UpdateDados(tb_subcategoria obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "update tb_subcategoria set Nome=@Nome, Menu=@Menu, Ativo=@Ativo where codigosubcategoria=@codigosubcategoria";
                cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                cmd.Parameters.AddWithValue("@Menu", obj.Menu);
                cmd.Parameters.AddWithValue("@codigosubcategoria", obj.CodigoSubCategoria);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }



        public bool ExcluirDados(int codigosubcategoria)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "UPDATE tb_subcategoria SET Ativo='Não' WHERE CodigosubCategoria=@codigosubcategoria";
                cmd.Parameters.AddWithValue("@codigosubcategoria", codigosubcategoria);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }

        public bool ValidarNome(tb_subcategoria obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_subcategoria where Nome=@Nome";
                cmd.Parameters.AddWithValue("@descricao", obj.Nome);

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

        public List<tb_subcategoria> GetAllSubCategoria()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_subcategoria where Ativo='Sim' order by Nome";
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_subcategoria>();

                while (Dr.Read())
                {
                    var item = new tb_subcategoria
                    {
                        CodigoSubCategoria = Convert.ToInt32(Dr["CodigoSubCategoria"]),
                        Nome = Dr["Nome"].ToString(),
                        Menu = Dr["Menu"].ToString(),
                        
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



        public List<ProdutoVWList> GetProdutoVWListSubcategoria(int Cod)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT p.CodigoProduto, p.CodigoInterno, p.Nome, p.Descricao, p.Valor, p.DataRegistro, p.Peso, p.Ativo, f.Caminho, g.CodigoSubCategoria from tb_produto AS p " +
                        "JOIN tb_produto_subcategoria AS g ON g.CodigoProduto = p.CodigoProduto " +
                        "LEFT JOIN tb_produto_foto AS f ON f.CodigoProduto = p.CodigoProduto " +
                        "WHERE g.CodigoSubCategoria =" + Cod +" GROUP BY p.CodigoInterno";


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



    }
}
