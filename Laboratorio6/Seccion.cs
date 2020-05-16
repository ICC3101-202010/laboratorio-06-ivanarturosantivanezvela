using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace Laboratorio6
{
    [Serializable()]
    public class Seccion:Division
    {
        string nameseccion;
        List<Bloque> bloques;

        public Seccion(string Nameseccion):base(Nameseccion)
        {
            this.Nameseccion = Nameseccion;
            Bloques = new List<Bloque>();
        }

        public string Nameseccion { get => nameseccion; set => nameseccion = value; }
        public List<Bloque> Bloques { get => bloques; set => bloques = value; }
    }
}
