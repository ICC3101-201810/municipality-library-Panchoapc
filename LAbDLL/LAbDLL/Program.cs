using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LAbDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFile(@"C:\Users\panch\Desktop\Labs en Git\municipality-library-Panchoapc\LAbDLL\ClassLibrary1.dll");
            foreach (Type type in assembly.GetTypes())
            {
                if (type.IsClass)
                {
                    Console.WriteLine("Clase: "+ type.Name);
                    Console.WriteLine("Attributes: ");
                    foreach (PropertyInfo info in type.GetProperties())
                    {
                        Console.WriteLine("\t+"+info.Name+ ": "+info.PropertyType.Name);
                    }
                    Console.WriteLine("Metodos: ");
                    foreach (MethodInfo info in type.GetMethods())
                    {
                        Console.WriteLine("\t+"+info.Name+ "():"+info.ReturnType.Name);
                        foreach (ParameterInfo pinfo in info.GetParameters())
                        {
                                Console.WriteLine("\t\tParametros: " +pinfo.ParameterType.Name +" "+pinfo.Name);
                        }
                    }
                    Console.WriteLine("--------------------------------------------------------------------");

                }
                else if (type.IsInterface)
                {
                    Console.WriteLine("Interfaz: "+type.Name);
                }
            }
            Console.ReadKey();
        }
    }
}
