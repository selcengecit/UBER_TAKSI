using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uber
{
    class Program
    {
        static void Main(string[] args)
        {
            int ride_time;
            int ride_distance;
            float[] sonuc = new float[4];
            do
            {
                Console.WriteLine("Süre bilgisi giriniz: ");
                ride_time = Convert.ToInt32(Console.ReadLine());
            }
            while (!(ride_time >= 10 && ride_time <= 50));
            do
            {
                Console.WriteLine("Mesafeyi giriniz: ");
                ride_distance = Convert.ToInt32(Console.ReadLine());
            }
            while (!(ride_distance >= 5 && ride_distance <= 20));

            float[] cost_per_minute = new float[4];
            cost_per_minute[0] = 0.2f;
            cost_per_minute[1] = 0.35f;
            cost_per_minute[2] = 0.4f;
            cost_per_minute[3] = 0.45f;

            float[] cost_per_mile = new float[4];
            cost_per_mile[0] = 1.1f;
            cost_per_mile[1] = 1.8f;
            cost_per_mile[2] = 2.3f;
            cost_per_mile[3] = 3.5f;

            for (int i = 0; i < cost_per_minute.Length; i++)
            {
                if ((cost_per_minute[i] >= 0.1 && cost_per_minute[i] <= 350.0)
                    && (cost_per_mile[i] >= 0.5 && cost_per_mile[i] <= 7.0)
                    && (cost_per_minute.Length == cost_per_mile.Length)
                    && (cost_per_minute.Length >= 4 && cost_per_minute.Length <= 10))
                {
                    sonuc[i] = (cost_per_minute[i] * ride_time) + (cost_per_mile[i] * ride_distance);
                    Console.WriteLine(sonuc[i]);
                }
            }   
            Console.ReadKey();
        }
    }
}
