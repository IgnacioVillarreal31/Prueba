using System;
using Library;

namespace Prog
{
    public class Program
    {
        public static void Main(String[] args)
        { 
            Banco banco = new Banco();

            banco.CrearCuenta("Ignacio","Villarreal","5378737-2","098370230","Uruguay");
            Cuenta cuenta1 = banco.BuscarCuenta("Ignacio");

            banco.CrearCuenta("Pedro","Pascal","2121777-2","09991","Chile");
            Cuenta cuenta2 = banco.BuscarCuenta("Pedro");


            banco.Deposito(1000,cuenta1);
            Console.WriteLine(cuenta1.GetSaldo());
            banco.Transferencia(1200,cuenta1,cuenta2);
            Console.WriteLine(cuenta1.GetSaldo());
            Console.WriteLine(cuenta2.GetSaldo());
        }
    }
}