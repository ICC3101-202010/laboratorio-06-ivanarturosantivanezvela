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
        List<Seccion> secciones;

        public Area(string Namearea) : base(Namearea)
        {
            this.Namearea = Namearea;
            Secciones = new List<Seccion>();
        }

        public List<Seccion> Secciones { get => secciones; set => secciones = value; }
        public string Namearea { get => namearea; set => namearea = value; }
    }
}
