using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_13_encapsulation
{
    internal class araba
    {
        private int hiz;
        private bool motor_calisiyor_mu;

        public void Motor_acik()
        {
            motor_calisiyor_mu = true;
            Console.WriteLine("Motor çalışıyor");
        }
        public void Motor_kapali()
        {
            motor_calisiyor_mu = false;
            Console.WriteLine("Motor durdu");
        }

        public void Hizlan(int miktar)
        {
            if (motor_calisiyor_mu)
            {
                hiz += miktar;
                Console.WriteLine($"Araç hızlandı: {hiz} km/h.");
            }
            else
            {
                Console.WriteLine("Motor çalışmıyor.");
            }
        }


        public int Hizi_goster() { return hiz; }
    }
}