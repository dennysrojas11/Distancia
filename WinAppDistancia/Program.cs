using System;
using System.Windows.Forms;

namespace WinAppDistancia
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class Distancia {
        double x1, x2, y1, y2, dis;

        public Distancia(double X1, double Y1, double X2, double Y2) {
            this.x1 = X1;
            this.x2 = X2;
            this.y1 = Y1;
            this.y2 = Y2;
        }

        public double calcular() {
            dis = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            dis = Math.Round(dis, 3);
            return dis;
        }
    }
}
