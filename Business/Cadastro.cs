using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Cadastro
    {
        public int Pedido { get; set; }
        public int Mesa { get; set; }
        public char Pizza { get; set; }
        public int qtdPizza { get; set; }
        public char ObservacaoPizza { get; set; }
        public char Bebida { get; set; }
        public int qtdBebida { get; set; }
        public char ObservacaoBebida { get; set; }

        public List<Cadastro> Pedidos()
        {
            var Pedidos = new List<Cadastro>();
            var cadastroDB = new BancoDeDados.Cadastros();
            foreach (DataRow row in cadastroDB.Pedidos().Rows)
            {
                var cadastro = new Cadastro();
                cadastro.Pedido = Convert.ToInt32(row["Pedido"]);
                cadastro.Mesa = Convert.ToInt32(row["Mesa"]);
                cadastro.Pizza = (char)row["Pizza"];
                cadastro.qtdPizza = Convert.ToInt32(row["qtdPizza"]);
                cadastro.ObservacaoPizza =(char)row["ObservacaoPizza"];
                cadastro.Bebida = (char)row["Bebida"];
                cadastro.qtdBebida = Convert.ToInt32(row["qtdBebida"]);
                cadastro.ObservacaoBebida = (char)row["Mesa"];

                Pedidos.Add(cadastro);

            }
            return Pedidos;
        }
    }
}
