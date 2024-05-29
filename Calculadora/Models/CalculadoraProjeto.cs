using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class CalculadoraProjeto
    {
        private List<string> _historico;
        private string Data;

        public CalculadoraProjeto(string data)
        {
            _historico = new List<string>();
            Data = data;
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;

            _historico.Insert(0, "Resultado: " + resultado + "Data: " + Data);
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;

            _historico.Insert(0, "Resultado: " + resultado + "Data: " + Data);
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;

            _historico.Insert(0, "Resultado: " + resultado + "Data: " + Data);
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;

            _historico.Insert(0, "Resultado: " + resultado + "Data: " + Data);
            return resultado;
        }

        public List<string> Historico()
        {
            _historico.RemoveRange(3, _historico.Count - 3);

            return _historico;
        }
    }
}