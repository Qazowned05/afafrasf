using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Problema02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Objeto objeto1 = new Objeto();

            objeto1.name = "Diego";
            objeto1.lasName = "Rivera";
            objeto1.codigo = 3414;
            objeto1.numero = 917287980;

            string cadenajson = JsonConvert.SerializeObject(objeto1);
            Console.WriteLine("el Json generado es : " + cadenajson);



            Console.ReadKey();
        }
    }
}
