using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TCC.DTO
{
    public class TccDTO
    {
        private string codbarra;
        private string nomeprod;
        private int qtdprod;
        private decimal valorprod;
        private decimal valortotal;
        private decimal contasfixo;
        private decimal contasmes;
        private string nomeconta;

        public string CodBarra
        {
            get { return codbarra; }
            set { codbarra = value; }
        }
        public string Nomeprod
        {
            get { return nomeprod; }
            set { nomeprod = value; }
        }
        public int QtdProd
{
  get { return qtdprod; }
  set { qtdprod = value; }
}
        public decimal ValorProd
        {
            get { return valorprod; }
            set { valorprod = value; }
        }
        public decimal ValorTotal
        {
            get { return valortotal; }
            set { valortotal = value; }
        }
        public decimal ContasFixo
        {
            get { return contasfixo; }
            set { contasfixo = value; }
        }
        public decimal ContasMes
        {
            get { return contasmes; }
            set { contasmes = value; }
        }
        public string NomeConta
        {
            get { return nomeconta; }
            set { nomeconta = value; }
        }
    }
}
