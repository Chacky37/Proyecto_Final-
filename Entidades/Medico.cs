using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico:Persona
    {
        public Medico() { }

        public string Especialidad { get; set; }

        public int AniosExpe { get; set; }

    }
}

