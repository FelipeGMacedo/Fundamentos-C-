using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp
{
    public class TiposNumericos
    {
        public void Executa()
        {
            //Byte *usado para idade e números não tão grandes
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            //Sbyte
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);

            //Short - 16bits
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);

            //ushort - 16bits
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);

            //Int
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            //Double
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            //Float
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            //Long
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            //Decimal *sistema monetário*
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);
        }
    }
}
