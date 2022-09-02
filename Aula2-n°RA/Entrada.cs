using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_n_RA
{
    internal class Entrada
    {
        double valor;
        int poltrona;
        DateTime data;

        public void SetValor(double valor)
        {
            this.valor = valor; 
        }
        public double GetValor()
        {
            return this.valor;
        }
        public void SetPoltrona(int poltrona)
        {
            this.poltrona = poltrona;
        }
        public int GetPoltrona()
        {
            return this.poltrona;
        }
        public void SetData(DateTime data)
        {
            this.data = data;   
        }
        public DateTime GetData()
        {
            return this.data;   
        }





    }
}
