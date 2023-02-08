using System;
namespace Library
{
    public class Banco
    {
        public Banco()
        {
            listaCuentas = new List<Cuenta>();
        }
        public List<Cuenta> listaCuentas {get;set;}
        public void CrearCuenta (string nombre, string apellido, string ci, string telefono, string ubicacion)
        {
            foreach (Cuenta cuentas in listaCuentas)
            {
                if (nombre == cuentas.Nombre) 
                {
                    Console.WriteLine("Ya existe una cuenta con el mismo nombre.");
                    break;
                }
            }
            listaCuentas.Add(new Cuenta(nombre, apellido, ci, telefono, ubicacion));
        }
        public Cuenta BuscarCuenta(string Nombre)
        {
            foreach (Cuenta c in listaCuentas)
            {
                if (c.Nombre == Nombre)
                {
                    return c;
                }
            }
            return null;
        }

        public void Transferencia(float dinero,Cuenta referente,Cuenta destinatario)
        {
            if (referente.SacarDinero(dinero) == true)
            {
                destinatario.AgregarDinero(dinero);
            }
        }
        public void Deposito(float dinero,Cuenta referente)
        {
            referente.AgregarDinero(dinero);
        }
    }
}