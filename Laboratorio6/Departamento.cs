using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace Laboratorio6
{
    [Serializable()]
    public class Departamento:Division
    {
        string namedepartment;
        List<Area> areas;

        public Departamento(string Namedepartment): base(Namedepartment)
        {
            namedepartment = Namedepartment;
            Areas = new List<Area>();
        }

        public List<Area> Areas { get => areas; set => areas = value; }

        
    }
}
