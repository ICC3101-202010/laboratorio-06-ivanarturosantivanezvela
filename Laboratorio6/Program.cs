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
                string opcion = Console.ReadLine();

               
                
                switch (opcion)
                {
                    case "1":
                        try
                        {
                            Console.WriteLine("Leyendo empresa.bin");
                            Empresa.Deserializar("empresa.bin").Empresainformacion();

                            

                        }
                        catch(Exception)
                        {   
                            Console.WriteLine("No se encontro la empresa, se solicitara de forma manual");
                            Console.WriteLine("Escriba el nombre de la empresa");
                            string nombre1 = Console.ReadLine();
                            Console.WriteLine("Escriba el rut de la empresa");
                            int rut1 = Convert.ToInt32(Console.ReadLine());
                            Empresa empresa1 = new Empresa(nombre1, rut1);

                            Area area1 = new Area("Economia");
                            area1.Personaencargada = new Persona("Juan", "Perez", 193242006, "Gerente");
                            area1.Listadepersonas.Add(new Persona("Ivan", "Santivanez", 19078504, "Consejero"));



                            Departamento departamento1 = new Departamento("Cuentas nacionales");
                            departamento1.Personaencargada = new Persona("Diana", "Lopez", 14572216, "Jefe");
                            departamento1.Listadepersonas.Add(new Persona("Pamela", "Vela", 14485792, "Senior"));

                            area1.Departamentos.Add(departamento1);

                            Seccion seccion1 = new Seccion("Gobierno");
                            seccion1.Personaencargada = new Persona("Agustin", "Fernandez", 19322466, "Jefe");
                            seccion1.Listadepersonas.Add(new Persona("James", "Mcgil", 14078905, "Coordinador"));

                            departamento1.Secciones.Add(seccion1);

                            Bloque bloque11 = new Bloque("Gobierno municipal");
                            bloque11.Personaencargada = new Persona("Diego", "Aviles", 145728, "Ayudante");
                            bloque11.Listadepersonas.Add(new Persona("Saul", "Godmas", 1234565, "Digitador"));

                            Bloque bloque22 = new Bloque("Gobierno general");
                            bloque22.Personaencargada = new Persona("Javier", "Gonzalez", 1324458, "Ayudante");
                            bloque22.Listadepersonas.Add(new Persona("Kim", "Waxler", 1234565, "Digitador"));

                            seccion1.Bloques.Add(bloque11);
                            seccion1.Bloques.Add(bloque22);

                            empresa1.Divisiones.Add(area1);
                            empresa1.Divisiones.Add(departamento1);
                            empresa1.Divisiones.Add(seccion1);
                            empresa1.Divisiones.Add(bloque11);
                            empresa1.Divisiones.Add(bloque22);

                            Empresa.Serializar("empresa.bin", empresa1);
                            empresa1.Empresainformacion();





                        }
                       
                        
                        break;

                    case "2":

                        Console.WriteLine("Escriba el nombre de la empresa");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Escriba el rut de la empresa");
                        int rut = Convert.ToInt32(Console.ReadLine());
                        Empresa empresa = new Empresa(nombre, rut);

                        Area area = new Area("Economia");
                        area.Personaencargada = new Persona("Juan", "Perez", 193242006, "Gerente");
                        area.Listadepersonas.Add(new Persona("Ivan", "Santivanez", 19078504, "Consejero"));

                        

                        Departamento departamento = new Departamento("Cuentas nacionales");
                        departamento.Personaencargada = new Persona("Diana", "Lopez", 14572216, "Jefe");
                        departamento.Listadepersonas.Add(new Persona("Pamela", "Vela", 14485792, "Senior"));

                        area.Departamentos.Add(departamento);

                        Seccion seccion = new Seccion("Gobierno");
                        seccion.Personaencargada = new Persona("Agustin", "Fernandez", 19322466, "Jefe");
                        seccion.Listadepersonas.Add(new Persona("James", "Mcgil", 14078905, "Coordinador"));

                        departamento.Secciones.Add(seccion);

                        Bloque bloque1 = new Bloque("Gobierno municipal");
                        bloque1.Personaencargada = new Persona("Diego", "Aviles", 145728, "Ayudante");
                        bloque1.Listadepersonas.Add(new Persona("Saul", "Godmas", 1234565, "Digitador"));

                        Bloque bloque2 = new Bloque("Gobierno general");
                        bloque2.Personaencargada = new Persona("Javier", "Gonzalez", 1324458, "Ayudante");
                        bloque2.Listadepersonas.Add(new Persona("Kim", "Waxler", 1234565, "Digitador"));

                        seccion.Bloques.Add(bloque1);
                        seccion.Bloques.Add(bloque2);

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





