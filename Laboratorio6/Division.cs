using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace Laboratorio6
{
    [Serializable()]
    public class Division
    {
       string namedivision;
       Persona personaencargada;
       List<Persona> listadepersonas;
       


       public Division(string Namedivision)
       {
            this.Namedivision = Namedivision;
            Listadepersonas = new List<Persona>();

       }

        public Persona Personaencargada { get => personaencargada; set => personaencargada = value; }
        public List<Persona> Listadepersonas { get => listadepersonas; set => listadepersonas = value; }
        public string Namedivision { get => namedivision; set => namedivision = value; }

        

        public string Getdivisiones()
        {
            string resultado = $"[{this.GetType().Name}] {Namedivision}\n";

            resultado += $"\tEncargado: {Personaencargada.Name}\n";
            resultado += "\tTrabajadores:";

            foreach (Persona trabajador in Listadepersonas)
            {
                resultado += $"\n\t\t{trabajador.Name} - {trabajador.Cargo}";
            }

            return resultado;
        }

    }
}
