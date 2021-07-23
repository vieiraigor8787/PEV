using PEV.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEV.Classes;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PEV.Data
{
    public class RelatorioDB
    {
        //Número de Colaboradores
        public Colaborador Colaboradores()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT IFNULL (COUNT(*), 0) AS Colaboradores FROM tb_login WHERE tipo='A';";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrColaborador = cmd.ExecuteReader();

                DrColaborador.Read();

                var colaborador = new Colaborador()
                {
                    TotalColaborador = Convert.ToInt32(DrColaborador["Colaboradores"])
                };

                var model = new Colaborador();
                model.TotalColaborador = Convert.ToInt32(colaborador.TotalColaborador);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        //Número de Clientes
        public Cliente Clientes()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT IFNULL (COUNT(*),0) AS Clientes FROM tb_login WHERE tipo='C'";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrCliente = cmd.ExecuteReader();

                DrCliente.Read();

                var cliente = new Cliente()
                {
                    TotalCliente = Convert.ToInt32(DrCliente["Clientes"])
                };

                var model = new Cliente();
                model.TotalCliente = Convert.ToInt32(cliente.TotalCliente);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        //Número de produtos ativos
        public Produto Produtos()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT IFNULL (COUNT(DISTINCT nome), 0) as Produtos FROM tb_produto WHERE Ativo='Sim'";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrProduto = cmd.ExecuteReader();

                DrProduto.Read();

                var produto = new Produto()
                {
                    TotalProduto = Convert.ToInt32(DrProduto["Produtos"])
                };

                var model = new Produto();
                model.TotalProduto = Convert.ToInt32(produto.TotalProduto);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        //Quantidade geral de produtos
        public Produto QuantidadeProdutos()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT IFNULL (SUM(Quantidade), 0) AS TotalProdutos FROM  tb_produto WHERE Ativo='Sim'";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrProduto = cmd.ExecuteReader();

                DrProduto.Read();

                var produto = new Produto()
                {
                    QuantidadeTotal = Convert.ToInt32(DrProduto["TotalProdutos"])
                };

                var model = new Produto();
                model.QuantidadeTotal = Convert.ToInt32(produto.QuantidadeTotal);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }


        //Quantidade de venda nos últimos 7 dias
        public Vendas Vendas()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT IFNULL (COUNT(*), 0) AS Vendas FROM  tb_venda where DataRegistro between date_sub(now(), INTERVAL 1 WEEK) and NOW();";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrVenda = cmd.ExecuteReader();

                DrVenda.Read();

                var venda = new Vendas()
                {
                    TotalVenda = Convert.ToInt32(DrVenda["Vendas"])
                };

                var model = new Vendas();
                model.TotalVenda = Convert.ToInt32(venda.TotalVenda);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        //Valor total de vendas dos últimos 7 dias
        public Vendas VendaValor()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT IFNULL (SUM(ValorFinal), 0) AS Valor FROM tb_venda where DataRegistro between date_sub(now(), INTERVAL 1 WEEK) and NOW()";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrVenda = cmd.ExecuteReader();

                DrVenda.Read();
                var venda = new Vendas()
                {
                    VendaValor = Convert.ToDouble(DrVenda["Valor"])
                };
                var model = new Vendas();
                model.VendaValor = Convert.ToDouble(venda.VendaValor);
                return model;


            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }


        // Tiket médio
        public Vendas MediaVendas()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();
                sSQL = "SELECT IFNULL((SUM(ValorFinal) / COUNT(*)), 0) AS ValorFinal FROM tb_venda";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrVenda = cmd.ExecuteReader();

                DrVenda.Read();

                var venda = new Vendas()
                {
                    MedidaVendas = Convert.ToDouble(DrVenda["ValorFinal"])
                };

                var model = new Vendas();
                model.MedidaVendas = Convert.ToDouble(venda.MedidaVendas);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        //Maior Venda
        public Vendas MaiorVendas()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();
                sSQL = "SELECT IFNULL (MAX(ValorFinal), 0) AS MaiorVenda FROM tb_venda";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrVenda = cmd.ExecuteReader();

                DrVenda.Read();

                var venda = new Vendas()
                {
                    MaiorVenda = Convert.ToDouble(DrVenda["MaiorVenda"])
                };

                var model = new Vendas();
                model.MaiorVenda = Convert.ToDouble(venda.MaiorVenda);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        //Quantidade de Vendas
        public Vendas VendasTotal()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT IFNULL (COUNT(*), 0) AS VendasTotal FROM  tb_venda";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrVenda = cmd.ExecuteReader();

                DrVenda.Read();

                var venda = new Vendas()
                {
                    VendasTotal = Convert.ToInt32(DrVenda["VendasTotal"])
                };

                var model = new Vendas();
                model.VendasTotal = Convert.ToInt32(venda.VendasTotal);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }


        //Valor total das vendas
        public Vendas VendaValorTotal()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT IFNULL (SUM(ValorFinal), 0) AS ValorTotal FROM tb_venda";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrVenda = cmd.ExecuteReader();

                DrVenda.Read();

                var venda = new Vendas()
                {
                    VendasValorTotal = Convert.ToDouble(DrVenda["ValorTotal"])
                };

                var model = new Vendas();
                model.VendasValorTotal = Convert.ToDouble(venda.VendasValorTotal);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }


        //Tamanho que mais vendeu
        public TamanhoVendeu TamanhoMaisVendeu()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();


                sSQL = "SELECT p.Tamanho, COUNT(i.CodigoProduto) AS Quantidade FROM tb_venda_itens AS i " +
                    "INNER JOIN tb_produto AS p ON(p.CodigoProduto = i.CodigoProduto) GROUP BY p.Tamanho ORDER BY Quantidade DESC;";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrVenda = cmd.ExecuteReader();

                DrVenda.Read();

                var TamVen = new TamanhoVendeu()
                {
                    Tamanho = DrVenda["Tamanho"].ToString(),
                    Quantidade = Convert.ToInt16(DrVenda["Quantidade"])
                };

                var model = new TamanhoVendeu();
                model.Tamanho = TamVen.Tamanho.ToString();
                model.Quantidade = Convert.ToInt16(TamVen.Quantidade);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                var model = new TamanhoVendeu();
                model.Tamanho = "Sem Registros!";
                model.Quantidade = 0;
                return model;
            }
        }


        //NOME E TAMANHO DO PRODUTO QUE MAIS VENDA
        public TamanhoVendeu NomeTamMaisVendido()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT p.Nome, p.Tamanho, COUNT(i.CodigoProduto) AS Quantidade FROM tb_venda_itens AS i " +
                        "INNER JOIN tb_produto AS p ON(p.CodigoProduto = i.CodigoProduto) " +
                        "GROUP BY i.codigoproduto ORDER BY Quantidade DESC; ";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrVenda = cmd.ExecuteReader();

                DrVenda.Read();

                var venda = new TamanhoVendeu()
                {
                    Nome = DrVenda["Nome"].ToString(),
                    Tamanho = DrVenda["Tamanho"].ToString(),
                    Quantidade = Convert.ToInt16(DrVenda["Quantidade"])
                };

                var model = new TamanhoVendeu();
                model.Nome = venda.Nome.ToString();
                model.Tamanho = venda.Tamanho.ToString();
                model.Quantidade = Convert.ToInt16(venda.Quantidade);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                var model = new TamanhoVendeu();
                model.Nome = "Sem Registros!";
                model.Tamanho = "";
                model.Quantidade = 0;
                return model;
            }
        }


        //NOME DO PRODUTO QUE MAIS VENDIDO
        public TamanhoVendeu NomeProdutoMaisVendido()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT p.Nome, COUNT(i.CodigoProduto) AS Quantidade FROM tb_venda_itens AS i " +
                        "INNER JOIN tb_produto AS p ON(p.CodigoProduto = i.CodigoProduto)" +
                        "GROUP BY p.Nome ORDER BY Quantidade DESC";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrVenda = cmd.ExecuteReader();

                DrVenda.Read();

                var venda = new TamanhoVendeu()
                {
                    Nome = DrVenda["Nome"].ToString(),
                    Quantidade = Convert.ToInt16(DrVenda["Quantidade"])
                };

                var model = new TamanhoVendeu();
                model.Nome = venda.Nome.ToString();
                model.Quantidade = Convert.ToInt16(venda.Quantidade);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                var model = new TamanhoVendeu();
                model.Nome = "Sem Registros!";
                model.Quantidade = 0;
                return model;
            }
        }


        //Método GENERO MAIS VENDIDO
        public GeneroVendeMais GeneroMaisVendido()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "        SELECT pg.CodigoGenero, g.Descricao, COUNT(i.CodigoProduto) AS Quantidade FROM tb_venda_itens AS i " +
                                "INNER JOIN tb_produto_genero AS pg ON(pg.CodigoProduto = i.CodigoProduto) " +
                                "INNER JOIN tb_produto AS p ON(p.CodigoProduto = i.CodigoProduto) " +
                                "INNER JOIN tb_genero AS g ON(g.CodigoGenero = pg.CodigoGenero) " +
                                "GROUP BY pg.CodigoGenero ORDER BY Quantidade DESC; ";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrVenda = cmd.ExecuteReader();

                DrVenda.Read();

                var venda = new GeneroVendeMais()
                {
                    Descricao = DrVenda["Descricao"].ToString(),
                    Quantidade = Convert.ToInt16(DrVenda["Quantidade"])
                };

                var model = new GeneroVendeMais();
                model.Descricao = venda.Descricao.ToString();
                model.Quantidade = Convert.ToInt16(venda.Quantidade);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                var model = new GeneroVendeMais();
                model.Descricao = "Sem Registros!";
                model.Quantidade = 0;
                return model;
            }
        }


        //PRODUTOS QUE AINDA NÃO VENDERAM NADA
        public List<ClienteCidade> ProdutoSemVenda()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT p.Nome AS Nome, IFNULL (iv.CodigoVenda,0) as Codigo_Venda FROM tb_produto AS p LEFT JOIN tb_venda_itens AS iv " +
                       "ON(p.CodigoProduto = iv.CodigoProduto) WHERE IFNULL(iv.CodigoVenda, 0) = 0 ";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                Dr.Read();

                var Lista = new List<ClienteCidade>();

                while (Dr.Read())
                {
                    var item = new ClienteCidade
                    {
                        Nome = Dr["Nome"].ToString(),
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

        public List<ClienteCidade> ClienteCidade()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT cidade, uf, COUNT(cidade) as Quantidade FROM tb_endereco GROUP BY cidade ORDER BY Quantidade DESC";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<ClienteCidade>();

                while (Dr.Read())
                {
                    var item = new ClienteCidade
                    {
                        Cidade = Dr["Cidade"].ToString(),
                        UF = Dr["UF"].ToString(),
                        Quantidade = Convert.ToInt32(Dr["Quantidade"]),
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
    }


}

