using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace Laboratorio6
{
    public class Program
    {
        public static void Main()
        {
            
            bool value=false;
            while (!value)
            {
                Console.WriteLine("1- Si desea utilizar un archivo para cargar la informacion de su empresa 2- Ingresar datos manuales de mi empresa  3-Salir");
                string opcion =Console.ReadLine();
                
                switch (opcion)
                {
                    case "1":
                        try
                        {   
                            Empresa.Deserializar("empresa.bin").Empresainformacion();

                            

                        }
                        catch(Exception)
                        {
                            Console.WriteLine("No se encontro la empresa, se solicitara de forma manual");
                            opcion = "2";

                        }
                       
                        
                        break;

                    case "2":

                        Console.WriteLine("Escriba el nombre de la empresa");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Escriba el rut de la empres");
                        int rut = Convert.ToInt32(Console.ReadLine());
                        Empresa empresa = new Empresa(nombre, rut);

                        Area area = new Area("Economia");
                        area.Personaencargada = new Persona("Juan", "Perez", 193242006, "Gerente");
                        area.Listadepersonas.Add(new Persona("Ivan", "Santivanez", 19078504, "Consejero"));

                       

                        Departamento departamento = new Departamento("Cuentas nacionales");
                        departamento.Personaencargada = new Persona("Diana", "Lopez", 14572216, "Jefe");
                        departamento.Listadepersonas.Add(new Persona("Pamela", "Vela", 14485792, "Senior"));

                        

                        Seccion seccion = new Seccion("Gobierno");
                        seccion.Personaencargada = new Persona("Agustin", "Fernandez", 19322466, "Jefe");
                        seccion.Listadepersonas.Add(new Persona("James", "Mcgil", 14078905, "Coordinador"));

                        

                        Bloque bloque1 = new Bloque("Gobierno municipal");
                        bloque1.Personaencargada = new Persona("Diego", "Aviles", 145728, "Ayudante");
                        bloque1.Listadepersonas.Add(new Persona("Saul", "Godmas", 1234565, "Digitador"));

                        Bloque bloque2 = new Bloque("Gobierno general");
                        bloque2.Personaencargada = new Persona("Javier", "Gonzalez", 1324458, "Ayudante");
                        bloque2.Listadepersonas.Add(new Persona("Kim", "Waxler", 1234565, "Digitador"));

                        empresa.Divisiones.Add(area);
                        empresa.Divisiones.Add(departamento);
                        empresa.Divisiones.Add(seccion);
                        empresa.Divisiones.Add(bloque1);
                        empresa.Divisiones.Add(bloque2);

                        Empresa.Serializar("empresa.bin", empresa);
                        empresa.Empresainformacion();

                        break;
                    case "3":
                        value = true;
                        break;



                }
               

            }

        }
        
    }
}





