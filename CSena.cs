using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sena_2
{
    [Serializable]
    class Sena
    {

        private string nom;
        private string pass;
        private string user;
        private string mail;
        private string extra;

        public string Pass
        {
            set { this.pass = value; }
            get { return this.pass; }

        }
        public string User
        {
            set { this.user = value; }
            get { return this.user; }

        }
        public string Nom
        {
            set { this.nom = value; }
            get { return this.nom; }

        }
        public string Mail
        {
            set { this.mail = value; }
            get { return this.mail; }

        }
        public string Extra
        {
            set { this.extra = value; }
            get { return this.extra; }

        }

    }
}
