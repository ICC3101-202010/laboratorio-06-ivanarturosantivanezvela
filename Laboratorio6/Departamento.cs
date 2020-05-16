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
        List<Seccion> secciones;

        public Departamento(string Namedepartment): base(Namedepartment)
        {
            namedepartment = Namedepartment;
            Secciones = new List<Seccion>();
        }

        public List<Seccion> Secciones { get => secciones; set => secciones = value; }
    }
}
