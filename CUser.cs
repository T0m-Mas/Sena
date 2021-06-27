using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sena_2
{
    [Serializable]
    class User
    {
        private string nom;
        private string pass;
        private ushort[] key;
        private string ruta;
        private DateTime fecha;

        public User(string nomin, string passin)//para registrar un usuario
        {
            this.nom = nomin;
            this.pass = passin;
            this.fecha = DateTime.Now;
            this.key = new ushort[32];

            var rand = new Random(fecha.Second);
            //Genero key para encriptar listado
            for (int f = 0; f < key.Length; f++)
            {
                this.key[f] = (ushort)rand.Next(10, 20);
            }

        }
        public User()
        {
            //Para leer de disco
        }

        public ushort[] GetKey()
        {
            return this.key;
        }
        public string GetNom()
        {
            return this.nom;
        }
        public void SetRuta(string s)
        {
            this.ruta = s;
        }
        public string GetRuta()
        {
            return this.ruta;
        }
        public string GetFecha()
        {
            return this.fecha.ToString("d");
        }

        public bool Verificar(string passin)
        {
            if (passin != this.pass) { return false; }
            return true;
        }

        public void SetNom(string nomin)
        {
            this.nom = nomin;
        }
        public void SetPass(string passin)
        {
            this.pass = passin;
        }

    }
}
