using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace Laboratorio6
{
    [Serializable()]
    public class Bloque:Division
    {
        string namebloque;

        public Bloque(string Namebloque):base(Namebloque)
        {
            this.Namebloque = Namebloque;
        }

        public string Namebloque { get => namebloque; set => namebloque = value; }

        
    }
}
