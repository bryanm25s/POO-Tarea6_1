using DirectorioEmp.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Persona> personas = new List<Persona>();

            
            Persona per1 = new Persona("Gabriel", "García Márquez");
            Persona per2 = new Persona("José", "Saramago");

            per1.grados.Add(new Grado(1, "Universitario", "Universidad Nacional", "Licenciatura en Literatura"));
            per2.cargos.Add(new Cargo(1, "Profesor", "Universidad Nacional", 9500));

            
            personas.Add(per1);
            personas.Add(per2);

            
            foreach (Persona per in personas)
            {
                Console.WriteLine(per.getNombreCompleto());


                foreach (Grado g in per.grados)
                {
                    Console.WriteLine("  Grado: " + g.getnumeroGrado() + "," + " Nivel educativo: " + g.getnivelEducativo() + "," + "" + " Institucion: " + g.getInstitucion() +
                       "," + " Titulo: " + g.getnombreTitulo());

                }

                foreach (Cargo c in per.cargos)
                {
                    Console.WriteLine(" Cargo: " + c.getNumeroCargo() + ", " + " Titulo: " + c.getTitulo() + ", " + " Empresa: "  + c.getEmpresa() + ", " + " Salario: " + c.getSalario());

                }

            }

            Console.ReadLine(); 
        }
    }
}

