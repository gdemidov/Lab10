using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите угол с помощью целочисленных значений градусов, угловых минут, угловых секунд");
            try
            {
                int gradus = Convert.ToInt32(Console.ReadLine());
                int min = Convert.ToInt32(Console.ReadLine());
                int sec = Convert.ToInt32(Console.ReadLine());
                Angle ugol = new Angle(gradus, min, sec); //ugol
                double gradus1, radian;
                ugol.ToRadians(gradus, min, sec, out gradus1, out radian);
                Console.WriteLine("Угол в радианах равен = {0:F4}", radian);
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Входная строка имела неверный формат");
            }
            Console.ReadKey();

        }
    }
    public class Angle //(gradus, min, sec)
    {
        int gradus;
        int min;
        int sec;
        public int Gradus
        {
            set
            {
                if (value >= 0 && value <= 360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Диапазон возможных значений градусов [0...360]");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Диапазон возможных значений для угловых минут [0...60]");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Диапазон возможных значений для угловых секунд [0...60]");
                }
            }
            get
            {
                return sec;
            }
        }

        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        public void ToRadians(int gradus, int min, int sec, out double gradus1, out double radian)
        {
            gradus1 = gradus + (min / 60) + (sec / 3600);
            radian = gradus1 * Math.PI / 180;
        }

    }
}
