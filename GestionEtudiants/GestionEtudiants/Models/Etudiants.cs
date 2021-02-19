using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class Etudiants
    {

        public int ID { get; set; }
        public string FullName { get; set; }
        public int CIN { get; set; }
        public string Adresse { get; set; }

        public Etudiants()
        {

        }
    }
    
}
