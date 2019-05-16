using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            
            Console.WriteLine("hey, como estas? me podrias decir tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("hola {0}, me podrias decir tu apellido",nombre);
            apellido = Console.ReadLine();

            CheckL(nombre);
            CheckL(apellido);

            Console.WriteLine("{0} {1}, Stop! You have violated the Law! Pay the court a fine or serve your sentance. ", nombre,apellido);

        }




        static void CheckL(string str)
        {
            int length = str.Length;

            if (length <= 2)
            {
                throw new System.ArgumentException("nombre/apellido no valido");
            }
        }


    }
}
