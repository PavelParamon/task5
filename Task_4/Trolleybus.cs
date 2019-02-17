using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace Task_4
{
   
    public class Trolleybus: IBreak
    {
        int x, y;
        int speed;
        double prob;

        static Random rnd = new Random();

        bool engine;
        bool rods;
        public delegate void Break();
        public event Break Breakdown;

        public Trolleybus(int x, int y, int speed)
        {
            this.x = x;
            this.y = y;
            this.speed = speed;
            engine = true;
            rods = true;
            Breakdown = Breakage;
        }


        public bool Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public bool Rods
        {
            get { return rods; }
            set { rods = value; }
        }

        public int X { get { return x; } }

        public int Y { get { return y; } }

        public void Set(int ws)
        {
            Dangerous(ws);
        }

        public void Breakage()
        {
            double p = Probability();
            if (p > 0.3)
                rods = false;
            else
                engine = false;
        }
        public void Move(int ws)
        {
            if (x < ws)
                x += speed;
            else
            {
                x = 0;
            }
        }
        public double Probability()
        {
            return rnd.NextDouble();
        }


        public void Dangerous(int ws)
        {
            if (engine && rods)
            {
                Move(ws);
                prob = Probability();
                
            }

            if (prob > 0.99)
            {
                Breakdown();
                prob = 0;
            }

        }


    }
}
