using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var ver = Trasformacion(" JUAN Pablo ", new List<string> { "ToUpper", "ToLower", "ToSnakeCase" }).ToList();

            foreach (var item in ver)
            {
                
                Console.WriteLine(item.ToString());
            }
        
           
        }

        public static List<string> Trasformacion(string phrase, List<String> Trasformacion)
        {
            List<string> resultado = new List<string>();

            foreach (var item in Trasformacion)
            {
              
                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                switch (item)
                {
                    case "ToUpper":
                        resultado.Add(ti.ToUpper(phrase).ToString());
                        break;
                    case "ToLower":
                        resultado.Add(ti.ToLower(phrase).ToString());
                        break;
                    case "ToSnakeCase":
                        //resultado.Add(phrase.Replace(' ', '_').Remove(0).Remove(phrase.Length));
                        break;
                    default:;
                        break;
                }
            }
            return resultado;
        }

        public string letter(string letas, string Trasformacion) {

            return "";

        }
    }

    
}
