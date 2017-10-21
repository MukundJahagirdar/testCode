using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_static_certification
{
    class Program
    {
        [ThreadStatic]
        public static int _field;
        static void Main(string[] args)
        {

            Thread t = new Thread(() => 
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine($" _field value is from t {_field} ");
                }
            });

            Thread t1 = new Thread(() =>
            {
               
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine($" _field value is  from t1 {_field}");
                }
            });

            t.Start();
             t1.Start();

            t.Join();
            t1.Join();
        }
    }
}
