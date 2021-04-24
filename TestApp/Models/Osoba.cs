using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApp.Models
{
    public enum Risk { low, medium, high }

    public enum Posledice { lom = 0 }

    public class Osoba
    {

        public int Id { get; set; }

        public string Ime { get; set; }
    }
}