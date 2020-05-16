using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace Laboratorio6
{   [Serializable()]
    public class Empresa
    {
        string nombreempresa;
        int rutempresa;
        List<Division> divisiones;

        public string Nombreempresa { get => nombreempresa; set => nombreempresa = value; }
        public int Rutempresa { get => rutempresa; set => rutempresa = value; }
        public List<Division> Divisiones { get => divisiones; set => divisiones = value; }

        public Empresa()
        {
            Divisiones = new List<Division>();

        }

        public Empresa(string Nombreempresa,int Rutempresa)
            :this()
        {    
            this.Nombreempresa = Nombreempresa;
            this.Rutempresa = Rutempresa;
            

        }
        public static void Serializar(string nombreArchivo, Empresa empresa)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(nombreArchivo, FileMode.OpenOrCreate);
            binaryFormatter.Serialize(fileStream, empresa);
            fileStream.Close();
        }

        public static Empresa Deserializar(string nombreArchivo)
        {
            if (File.Exists(nombreArchivo))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fileStream = new FileStream(nombreArchivo, FileMode.Open);
                Empresa empresa = (Empresa)binaryFormatter.Deserialize(fileStream);
                fileStream.Close();
                return empresa;
            }
            else
            {
                return null;
            }
        }
        public string Getempresa()
        {
            return $"Empresa: {nombreempresa} ({rutempresa})";
        }

        public void Empresainformacion()
        {
            
            Console.WriteLine($"{this.Getempresa()}\n");
            foreach (Division division in Divisiones)
            {
                Console.WriteLine($"{division.Getdivisiones()}\n");

            }
                
               
        }

    }
}
