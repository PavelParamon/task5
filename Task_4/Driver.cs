using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;



namespace Task_4
{
    public class Driver 
    {


        Trolleybus trolleybus;

        public delegate void NoMaterials();
        public event NoMaterials NoMaterial;
        public bool IsReady;

        public Driver()
        {
            IsReady = true;
            NoMaterial = NoMater;
        }
       
        public Trolleybus TrolleybusSet
        {
            set
            {
                trolleybus = value;
            }
            get { return trolleybus; }
        }
        public void NoMater()
        {
            IsReady = false;
        }

        public void Set()
        {
            if(trolleybus.Rods == false)
            {
                NoMaterial();
                Repair();
            }
        }

        public void Repair()
        {
            Thread.Sleep(3000);
            trolleybus.Rods = true;
            IsReady = true;

            
        }
    }
}
