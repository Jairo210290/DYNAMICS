using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DYNAMICS.BE
{
    public class Cliente
    {

        //Variables
        private int idCliente;
        private string nombre;
        private string apellido;
        private string telefono1;
        private string telefono2;


        //Metodos set y get
        public int IdCliente
        {
            get
            {
                return this.idCliente;
            }
            set
            {
                this.idCliente = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public string Telefono1
        {
            get
            {
                return this.telefono1;
            }
            set
            {
                this.telefono1 = value;
            }
        }

        public string Telefono2
        {
            get
            {
                return this.telefono2;
            }
            set
            {
                this.telefono2 = value;
            }
        }


    }
}
