using Caelum.Stella.CSharp.Validation;
using System;
using System.Diagnostics;

namespace ValidadorDeDocumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf1 = "03444081243";
            string cpf2 = "04444444434";
            string cpf3 = "44444444444";

            ValidarCPF(cpf1);
            ValidarCPF(cpf2);
            ValidarCPF(cpf3);
        }

        private static void ValidarCPF(string cpf)
        {
            try
            {
                new CPFValidator().AssertValid(cpf);
                Debug.WriteLine("CPF Válido: " + cpf);
            }
            catch (Exception exc)
            {
                Debug.WriteLine("CPF Inválido! " + cpf + " : " + exc.Message);
            }
        }
    }
}
