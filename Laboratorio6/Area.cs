using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace Laboratorio6
{
    [Serializable()]
    public class Area:Division
    {
        string namearea;
        List<Departamento> departamentos;

        public Area(string Namearea) : base(Namearea)
        {
            this.Namearea = Namearea;
            Departamentos = new List<Departamento>();
        }

        
        public string Namearea { get => namearea; set => namearea = value; }
        public List<Departamento> Departamentos { get => departamentos; set => departamentos = value; }
    }
}
