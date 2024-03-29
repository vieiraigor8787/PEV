﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PEV.Classes;
using PEV.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PEV.Data
{
    public class CategoriaDB
    {

        public bool InserirDados(tb_categoria obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "insert into tb_categoria(Descricao)values(@descricao)";
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);

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

        public bool UpdateDados(tb_categoria obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "update tb_categoria set descricao=@descricao where codigocategoria=@codigocategoria";
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                cmd.Parameters.AddWithValue("@codigocategoria", obj.CodigoCategoria);

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

        public bool ExcluirDados(int codigocategoria)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "UPDATE tb_categoria SET Ativo='Não' WHERE CodigoCategoria=@codigocategoria";
                cmd.Parameters.AddWithValue("@codigocategoria", codigocategoria);

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

        public bool ValidarNome(tb_categoria obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_categoria where descricao=@descricao";
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);

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

        public List<tb_categoria> GetAllCategoria()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_categoria where Ativo='Sim' order by descricao";
                //sSQL = "SELECT distinct c.CodigoCategoria, c.Descricao, sc.Nome FROM tb_categoria AS c " +
                //"INNER JOIN tb_categoria_subcategoria AS cs ON(c.CodigoCategoria= cs.CodigoCategoria)" +
                //"INNER JOIN tb_subcategoria AS sc ON(cs.CodigoSubCategoria= sc.CodigoSubCategoria)";
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_categoria>();

                while (Dr.Read())
                {
                    var item = new tb_categoria
                    {
                        CodigoCategoria = Convert.ToInt32(Dr["CodigoCategoria"]),
                        Descricao = Dr["Descricao"].ToString(),
                    };

                    Lista.Add(item);
                }

                return Lista;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                var Lista = new List<tb_categoria>();

                    var item = new tb_categoria
                    {
                        CodigoCategoria = 0,
                        Descricao = "",
                    };

                    Lista.Add(item);
                return Lista;
            }
        }

        public List<tb_categoria> GetAllCategoriaSub(int cod)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                //sSQL = "select * from tb_categoria where Ativo='Sim' order by descricao" +
                sSQL = "SELECT sc.Nome FROM tb_categoria AS c " +
                "INNER JOIN tb_categoria_subcategoria AS cs ON(c.CodigoCategoria= cs.CodigoCategoria)" +
                "INNER JOIN tb_subcategoria AS sc ON(cs.CodigoSubCategoria= sc.CodigoSubCategoria) where c.CodigoCategoria=" + cod;
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_categoria>();

                while (Dr.Read())
                {
                    var item = new tb_categoria
                    {
                        //CodigoCategoria = Convert.ToInt32(Dr["CodigoCategoria"]),
                        //Descricao = Dr["Descricao"].ToString(),
                        Nome = Dr["Nome"].ToString()
                    };

                    Lista.Add(item);
                }

                return Lista;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                var Lista = new List<tb_categoria>();

                var item = new tb_categoria
                {
                    Nome = ""
                    };

                    Lista.Add(item);

                return Lista;
            }
        }



    }
}
