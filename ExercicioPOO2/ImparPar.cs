using System;

namespace VSProject
{
    public class ImparPar
    {
        public double valor;
        public string resultado;
        public ImparPar (double numero)
        {
            valor = numero;
            if (valor % 2 == 0) {
                resultado = "É par";
            }
            else
            {
                resultado = "É impar";
            }
        }
    }
}