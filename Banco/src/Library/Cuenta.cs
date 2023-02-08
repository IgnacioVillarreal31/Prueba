using System;
namespace Library
{
    public class Cuenta
    {
        public string Nombre;
        private string Apellido;
        private string Ci;
        private string Telefono;
        private string Direccion;
        public enum Datos {Nombre,Apellido,Ci,Telefono,Direccion};
        private float Saldo;
        public Cuenta (string nombre,string apellido,string ci,string telefono,string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Ci = ci;
            Telefono = telefono;
            Direccion = direccion;
        }
        public string GetDatos()
        {
            return $"Nombre: {Nombre}\nApellido: {Apellido}\nCi: {Ci}\nTelefono: {Telefono}\nDireccion: {Direccion}";
        }
        public void SetDatos(Datos dato,string nuevoValor)
        {
            switch (dato)
            {
                case Datos.Nombre: Nombre = nuevoValor;
                break;  

                case Datos.Apellido: Apellido = nuevoValor;
                break; 

                case Datos.Ci: Ci = nuevoValor;
                break; 

                case Datos.Telefono: Telefono = nuevoValor;
                break; 

                case Datos.Direccion: Direccion = nuevoValor;
                break; 
            }
        }
        public bool SacarDinero(float dinero)
        {
            if (dinero<=Saldo)
            {
                Saldo -= dinero;
                return true;
            }
            return false;
        }
        public void AgregarDinero(float dinero)
        {
            Saldo += dinero;
        }
        public float GetSaldo()
        {
            return Saldo;
        }
    }
}

