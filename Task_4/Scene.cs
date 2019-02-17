using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace Task_4
{
    public class Scene
    {


        public Trolleybus trolleybus1;
        public Trolleybus trolleybus2;
        public Trolleybus trolleybus3;
        public Trolleybus trolleybus4;

        public Driver driver1 = new Driver();
        public Driver driver2 = new Driver();
        public Driver driver3 = new Driver();
        public Driver driver4 = new Driver();

        public Service service;
        int ws;

        static object locker = new object();

        public Scene(int ws)
        {
            this.ws = ws;

            trolleybus1 = new Trolleybus(0, 20 * 1, 7);
            trolleybus2 = new Trolleybus(0, 20 * 5, 7);
            trolleybus3 = new Trolleybus(0, 20 * 10, 7);
            trolleybus4 = new Trolleybus(0, 20 * 15, 7);

            service = new Service(0, 0, 15);

            driver1.TrolleybusSet = trolleybus1;
            driver2.TrolleybusSet = trolleybus2;
            driver3.TrolleybusSet = trolleybus3;
            driver4.TrolleybusSet = trolleybus4;

           
        }


        public void Set(int ws, Driver driver)
        {

            driver.TrolleybusSet.Set(ws);
            driver.Set();

            if (!driver.TrolleybusSet.Engine)
            {
                lock (service)
                {
                    service.x = 0;
                    service.y = driver.TrolleybusSet.Y;
                    service.TrolleybusSet = driver.TrolleybusSet;
                    while (!driver.TrolleybusSet.Engine)
                    {
                        service.Set(ws);
                        Thread.Sleep(50);

                    }
                }
                
            }
                   
                
        }

    }
}
