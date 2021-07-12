using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PEV.Models
{
    public class RelatorioModel
    {
        public Cliente Clientes { get; set; }
        public Colaborador Colaboradores { get; set; }
        public Vendas Vendas { get; set; }
        public Produto Produtos { get; set; }

    }

    public class Produto
    {
        public int TotalProduto { get; set; }
        public int QuantidadeTotal { get; set; }
    }

    public class Colaborador
    {
        public int TotalColaborador { get; set; }
    }

    public class Cliente
    {
        public int TotalCliente { get; set; }
    }

    public class Vendas
    {
        public int TotalVenda { get; set; }
        public double VendaValor { get; set; }
        public double MedidaVendas { get; set; }
        public double MaiorVenda { get; set; }
        public int VendasTotal { get; set; }
        public double VendasValorTotal { get; set; }
    }

    public class TamanhoVendeu
    {
        public string Nome { get; set; }
        public string Tamanho { get; set; }
        public int Quantidade { get; set; }
    }

    public class GeneroVendeMais
    {
        public int CodigoGenero { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
    }
}
