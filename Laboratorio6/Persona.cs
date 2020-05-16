using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace Laboratorio6
{
    [Serializable()]
    public class Persona
    {
        string name;
        string surname;
        int rut;
        string cargo;
        public Persona(string Name,string Surname,int Rut,string Cargo)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Rut = Rut;
            this.Cargo = Cargo;

        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Rut { get => rut; set => rut = value; }
        public string Cargo { get => cargo; set => cargo = value; }
    }
}
