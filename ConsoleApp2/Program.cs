using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var estudiantes = StudentEntity.GetStudentEntities().Where(s => s.Gender == "male");
            //var estudiantes = from Student in StudentEntity.GetStudentEntities()
            //                  where Student.Gender == "male"
            //                  select Student;

            

            

            foreach (var item in estudiantes)
            {
                Console.Write(item.ID);
                Console.Write("{0, 20}", item.Name);
                Console.Write("{0, 20}", item.Gender);
                Console.WriteLine();

            }


            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++");

             
            string nameExample = "Berni";
            string strNewString = nameExample.ChangeFirstLetterCase();
            
            Console.WriteLine(strNewString);



            int precioCarro = 25;
            int precioConImpuestos = precioCarro.AddTaxToTheValue();

            Console.WriteLine(precioConImpuestos);





















            Console.ReadLine();
        }
    }
}

