using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laboratorio6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empresa> empresas = new List<Empresa>();
            Console.WriteLine("Quiere cargar la informacion de las empresas? si/no");
            string respuesta = Console.ReadLine();
            if (respuesta == "no")
            {
                AgregarEmpresa(empresas);
                Save(empresas);
            }
            else if (respuesta == "si")
            {
                try
                {
                    empresas = Load();
                    verEmpresas(empresas);
                }
                catch (System.IO.FileNotFoundException e)
                {
                    Console.WriteLine("No se pudo abrir el archivo");
                    Console.WriteLine(e.Message);
                    Console.WriteLine(" ");
                    AgregarEmpresa(empresas);
                    Save(empresas);

                }

            }

            void Save(List<Empresa> empresa)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("Empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, empresa);
                stream.Close();
            }

            List<Empresa> Load()
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("Empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<Empresa> empresa = (List<Empresa>)formatter.Deserialize(stream);
                stream.Close();
                return empresa;
            }
            void AgregarEmpresa(List<Empresa> empresas1)
            {
                Console.Write("Nombre de la empresa: ");
                string nombre = Console.ReadLine();
                Console.Write("Rut de la empresa: ");
                string rutEmpresa = Console.ReadLine();
                Console.WriteLine("Divisiones de la empresa y sus trabajadores");
                List<Division> divisiones = new List<Division>();
                empresas1.Add(new Empresa(nombre, rutEmpresa, divisiones));
            }

            void verEmpresas(List<Empresa> empresas1)
            {
                foreach (Empresa e1 in empresas)
                {
                    Console.WriteLine(e1);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
