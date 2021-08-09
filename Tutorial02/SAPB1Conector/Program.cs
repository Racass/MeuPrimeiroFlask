using System;
using SAPbobsCOM;

namespace SAPB1Conector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Bem vindo ao meu primeiro conector ao SAP Business One!");
            Console.WriteLine("Estou preparando algumas configurações e iremos iniciar nossa conexão, ok? :)");

            Company oCmp = new Company();

            oCmp.Server = "";
            oCmp.CompanyDB = "";
            oCmp.UserName = "";
            oCmp.Password = "";
            oCmp.DbUserName = "";
            oCmp.DbPassword = "";
            oCmp.DbServerType = BoDataServerTypes.[...];


            if(oCmp.Connect() != 0)
            {
                Console.WriteLine("Houve um erro ao conectarmos com o SAP.");
                string error = oCmp.GetLastErrorDescription();
                Console.WriteLine($"O erro foi: {error}.");
            }
            else
            {
                Console.WriteLine("Conectamos ao SAP com sucesso!");
            }
        }
    }
}
