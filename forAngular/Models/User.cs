using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace forAngular.Models
{
    public class Users
    {
        public int id
        {
            get
            {
                return 1;

            }
        }
        public string name
        {
            get
            {
                return "ciccio";

            }
        }

        public string cognome
        {
            get
            {
                return "vlakko";
            }
        }
        public int age
        {
            get
            {
                return 88;
            }
        }
    }

    public class User
    {
        public int id;
        public string name;
        public string cognome;
        public string  professione;
        public string citta;
        public string  statocivile;
        public DateTime nascita;
        public int  age;
    }

    public class Registro
    {
        public int id;
        public int Lotto;
        public string Esito;
        public DateTime date;
    }
}