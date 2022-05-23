using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputation
{
    public class MeasureLineLength
    {
        int x1, x2, y1, y2;
        public MeasureLineLength()
        {
            Console.WriteLine("Enter X start coordinate number of line1 i.e x1: ");
            x1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y start coordinate number of line1 i.e y1: ");
            y1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X end coordinate number of line i.e x2: ");
            x2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y end coordinate number of line1 i.e y2: ");
            y2=Convert.ToInt32(Console.ReadLine());
        }
        public static void MesuretheLength()
        {
            MeasureLineLength line1 = new MeasureLineLength();
            MeasureLineLength line2 = new MeasureLineLength();
            double lengthofLine = Math.Sqrt(Math.Pow((line1.x2 - line1.x1),2) + Math.Pow((line1.y2 - line1.y1),2));
            double lengthofLine2 = Math.Sqrt(Math.Pow((line2.x2 - line2.x1),2) + Math.Pow((line2.y2 - line2.y1),2));
            
            if(lengthofLine2 == lengthofLine)
            {
                Console.WriteLine("Both lines are Equal OR Identical");
            }
            else
            {
                Console.WriteLine("Both lines are non identical");
            }
        }

    }
}
