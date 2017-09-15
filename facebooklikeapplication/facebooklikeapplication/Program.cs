using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facebooklikeapplication
{
    class Program
    {
        static void Main(string[] args)
        {


            likeapplication();
        }

       public static void likeapplication()
        {
            var names = new List<string>();

            while(true)
            {
                string s1;
                Console.WriteLine("Enter the name of the person");
                s1=Console.ReadLine();
                names.Add(s1);

                if(names.Count()==1)
                {
                    Console.WriteLine(names[0]+" "+"Liked your picture");
                }

                else if (names.Count()==2)
                {
                    Console.WriteLine(names[0] + " " +"and" +" "+ names[1] + " " + "Liked your picture");
                }

                else if(names.Count()>= 3)
                {
                    Console.WriteLine("{0},{1} and {2} others liked your photo",names[0],names[1],names.Count()-2);
                }
                  
            }
        }

    }
}
