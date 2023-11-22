using System;

namespace EjercicioPrueba.Dto
{
    internal class ClientetDto
    {
        //ATRIBUTOS(CARACTERÍSTICAS)
        //private por defecto

        long idCliente; //PK

        string nombreCliente;

        string apellidosCliente

        string dniCliente;

        string fchaNacimientoCliente;

        string emailCliente;

        int telefonoCliente;

        string fchaAltaCliente;

        string fchaBajaCliente;

        //GETTERS Y SETTERS (métodos de acceso get-lectura; set-escritura)(métodos de acceso get-lectura; set-escritura)

        public long idCliente
        {
            get => idCliente;
                 set =>idCliente = value;
        }

        public string nombreCliente 
        {
            get => nombreCliente;
                 set => nombreCliente = value;
        }

        public string apellidoCliente
        {
            get => apellidoCliente;
                set => apellidoCliente = value; 
        }

        public string dniCliente
        {
            get => dniCliente;
                set =>dniCliente = value;   
        }

        public string fchaNacimientoCliente
        {
            get => fchaNacimientoCliente;
                set=>fchaNacimientoCliente  = value;
        }

        public string emailCliente
        {
            get => emailCliente;
                set=> emailCliente = value;
        }

        public int telfonoCliente
        {
            get => telfonoCliente;
                set => telfonoCliente = value;
        }

        public string fchaAltaCliente
        {
            get => fchaAltaCliente;
                set => fchaAltaCliente = value;
        }

        public string fchaBajaAltaCliente
        {
            get=> fchaBajaAltaCliente;  
                set=>fchaBajaCliente = value;
        }

        //CONSTRUCTORES

        public ClienteDto (long idCliente, string nombreCliente, string apellidosCliente, string dniCliente, string fchaNacimientoCliente, string emailCliente, int telefonoCliente, string fchaAltaCliente, string fchaBajaCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente= apellidosCliente;    
            this.dniCliente= dniCliente;
            this.fchaNacimienteCliente = fchaNacimientoCliente;
            this.emailCliente= emailCliente;
            this.telefonoCliente= telefonoCliente;
            this.fchaAltaCliente= fchaAltaCliente;
            this.fchaBajaCliente= fchaBajaCliente;
        }

        public ClienteDto()
        {
        }

        //ToString
        override
        public string ToString()
        {
            string clienteString = "Nombre: " + this.nombreCliente +
                " Apellidos: " + this.apellidosCliente +
                " DNI: " + this.dniCliente +
                " Fecha Nacimiento: " + this.fchNacimientoCliente +
                " Email: " + this.emailCliente +
                " Tlf: " + this.tlfCliente +
                " Fecha Alta: " + this.fchAltaCliente +
                " Fecha Baja: " + this.fchBajaCliente;

            return clienteString;
        }
    }
}