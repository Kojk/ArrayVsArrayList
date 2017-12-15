using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayVsArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int miliarda = 100000000;
            //int[] miliardaPole = new int[miliarda];
            //ArrayList miliardaAlist = new ArrayList();

            //Random r = new Random();

            //Stopwatch stopky = new Stopwatch();
            //stopky.Start();

            //for (int i = 0; i < miliardaPole.Length; i++)
            //{
            //    miliardaPole[i] = r.Next();
            //}
            //stopky.Stop();
            //Console.WriteLine("naplneni pole {0}", stopky.Elapsed);

            //stopky.Restart();
            //for (int i = 0; i < miliarda; i++)
            //{
            //    miliardaAlist.Add(r.Next());
            //}
            //stopky.Stop();
            //Console.WriteLine("naplneni Arraylist {0}", stopky.Elapsed);

            
            //stopky.Restart();
            //Array.Sort(miliardaPole);
            //stopky.Stop();
            //Console.WriteLine("sort Array {0}", stopky.Elapsed);

            //stopky.Restart();
            //miliardaAlist.Sort();
            //stopky.Stop();
            //Console.WriteLine("sort ArrayList {0}", stopky.Elapsed);

            string vstup = "3acj";
            try    // skuska
            {
                int cislo = int.Parse(vstup);
            }
            catch(Exception exception)   //vynimka
            {
                // odchytenie obecnej vynimky

                Console.WriteLine(exception.Message);
                throw exception;       // nieco spravi ale vyhodi vynimku
            }
            finally
            {
                // vzdy sa provede
            }


            Console.ReadLine();

        }
    }
}
