using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Perro
    {
        public string Name { get; set; }
        public int Age { get; private set; }

        public Perro()//no inicializa las variables name y age 
        {

        }
        public Perro(int age, string name)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Bark()
        {//en el caso de que name no este inicializada ésta función arroja una excepcion-error
            
           

            string name = this.Name;
            return "wao"+ name.Length.ToString();
        }
    }
}
