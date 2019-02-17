using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Task_4
{
    public class DrawAll
    {
        Scene scene;


        public DrawAll(Scene scene)
        {
            this.scene = scene;
        }

        public void Set(Bitmap bmp, Graphics g)
        {
            Drawing.Draw(scene, bmp, g);

        }
    }
}
