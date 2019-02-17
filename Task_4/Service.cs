using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace Task_4
{
    public class Service
    {
        public int x, y;
        public int speed;
        public bool IsReady;

        Trolleybus trolleybus;

        public delegate void NoMaterials();
        public event NoMaterials NoMaterial;

        public Service(int x, int y, int speed)
        {
            this.x = x;
            this.y = y;
            this.speed = speed;
            IsReady = true;
            NoMaterial = NoMater;
        }

        
        public Trolleybus TrolleybusSet
        {
            set
            {
                trolleybus = value;
            }
        }

        public void NoMater()
        {
            IsReady = false;
        }
        public void Set(int ws)
        {
            if (trolleybus.Engine == false)
            {
                NoMaterial();
                Repair(ws); 
            }
        }

        public void Move(int ws)
        {
            if (x < ws)
                x += speed;
            else
            {
                x = 0;
                trolleybus.Engine = true;
                IsReady = true;
            }
        }


        public void Repair(int ws)
        {
            speed = 15;
            Move(ws);      
        }
    }
}
