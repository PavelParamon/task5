using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Task_4
{
    public class Drawing
    {
        public static void Draw(Scene scene, Bitmap bmp, Graphics g)
        {
            DrawTroll(scene.trolleybus1.X, scene.trolleybus1.Y, bmp, g, scene.trolleybus1);
            DrawTroll(scene.trolleybus2.X, scene.trolleybus2.Y, bmp, g, scene.trolleybus2);
            DrawTroll(scene.trolleybus3.X, scene.trolleybus3.Y, bmp, g, scene.trolleybus3);
            DrawTroll(scene.trolleybus4.X, scene.trolleybus4.Y, bmp, g, scene.trolleybus4);

            if (!scene.driver1.IsReady)
                DrawDriver(scene.trolleybus1.X, scene.trolleybus1.Y, bmp, g);
            if (!scene.driver2.IsReady)
                DrawDriver(scene.trolleybus2.X, scene.trolleybus2.Y, bmp, g);
            if (!scene.driver3.IsReady)
                DrawDriver(scene.trolleybus3.X, scene.trolleybus3.Y, bmp, g);
            if (!scene.driver4.IsReady)
                DrawDriver(scene.trolleybus4.X, scene.trolleybus4.Y, bmp, g);

            if (!scene.service.IsReady)
                DrawServicel(scene.service.x, scene.service.y, bmp, g);
        }

        private static void DrawTroll(int x, int y, Bitmap bmp, Graphics g, Trolleybus troll)
        {
            using (g = Graphics.FromImage(bmp))
            {
                g.DrawLine(Pens.Gray, 0, y + 48, 850, y + 48);

                g.FillRectangle(Brushes.Yellow, x, y, 120, 40);
                g.FillEllipse(Brushes.Black, x + 20, y + 32, 16, 16);
                g.FillEllipse(Brushes.Black, x + 80, y + 32, 16, 16);

                if (troll.Rods)
                    g.DrawLine(Pens.Black, x + 100, y, x, y - 20);
                else
                    g.DrawLine(Pens.Black, x + 100, y, x, y - 3);

                if (!troll.Engine)
                {
                    g.DrawLine(Pens.Gray, x + 120, y + 25, x + 135, y + 10);
                    g.DrawLine(Pens.Gray, x + 120, y + 25, x + 135, y + 15);
                    g.DrawLine(Pens.Gray, x + 120, y + 25, x + 135, y + 26);
                    g.DrawLine(Pens.Gray, x + 120, y + 25, x + 135, y + 30);
                    g.DrawLine(Pens.Gray, x + 120, y + 25, x + 135, y + 35);
                }

            }
        }
        private static void DrawDriver(int x, int y, Bitmap bmp, Graphics g)
        {
            using (g = Graphics.FromImage(bmp))
            {
                g.FillEllipse(Brushes.Pink, x + 70, y + 24, 15, 24);
                g.FillEllipse(Brushes.Pink, x + 70, y + 12, 10, 12);
            }
        }
        private static void DrawServicel(int x, int y, Bitmap bmp, Graphics g)
        {
            using (g = Graphics.FromImage(bmp))
            {
                g.FillRectangle(Brushes.Red, x, y + 10, 60, 31);
                g.FillRectangle(Brushes.Red, x + 60, y + 25, 23, 16);
                g.FillEllipse(Brushes.Black, x + 12, y + 34, 14, 14);
                g.FillEllipse(Brushes.Black, x + 55, y + 34, 14, 14);
            }
        }
    }
}
