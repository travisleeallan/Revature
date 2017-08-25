using System;
using ShapeGarden.Models;
using ShapeGarden.Interfaces;
using ShapeGarden.Abstracts;


namespace ShapeGarden
{
    class Program //default internal
    {
        //private static Program p = new Program();
        static void Main(string[] args) //default private
        {
            PlayWithShapes();
        }

        public static void PlayWithShapes()
        {
            Rectangle r1 = new Rectangle();
            AShape a1 = new Square(); //
            var a2 = new Square();    //lazy instantiation
            IShape i1 = new Triangle(); //
            Object o = 10;
            int i = (int)o;
            int i2 = (int)((Object)a2);

            int x = 3;
            
            //a1.Perimeter();
            //a1.Perimeter(1);
            //a2.Perimeter();
            //a2.Perimeter(1);
            var arr1 = new IShape[] {r1, a1, a2};
            PrintShapes(arr1);
            PrintShapes(r1, a1, a2);
        }

        ///<summary>
        /// no more comments!!!
        ///</summary>
        public static void PrintShapes(params IShape[] r)
        {
            try
            {
                foreach (AShape item in r) 
                {
                    Console.WriteLine(item.Sides);
                }
            }
            catch(NullReferenceException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                throw new Exception("message", ex);
            }
            finally
            {

            }
            
        }

    }
}
