using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Technique headphones = new Headphones("Наушники","РБ",44444,"2 года",ConsoleColor.Blue);
            Technique headphones1 = new Headphones("Наушники", "РБ", 444, "2 года", ConsoleColor.Blue);

            Technique tecniqueExample = new Technique("Товар", "РБ", 23333,"2 year");
            Goods PhoneExample = new Smartphone("Sony", "China", 54_555, "2 year", 80_29_89_47_333, true);
            Console.ReadKey();
            
            computerLab Obj = new computerLab();
                        
            Obj.Add(headphones);
            Obj.Add(headphones1);
            Obj.Add(tecniqueExample);
            Obj.Add(headphones);
            Obj.Add(PhoneExample);

            Console.Write("Массив:");
            Obj.Print();

            classController controller = new classController(Obj);

            controller.TotalCost();
            controller.SortAndPrint();
            controller.Search_to_write_off();

            Console.ReadKey();
            Obj.Delete(allElements: headphones1);
            Obj.Print();

            Obj.Delete(numberOfElement:1);
            Obj.Print();

            Obj.Delete(allElements:headphones);
            Obj.Print();

        }
    }
}
