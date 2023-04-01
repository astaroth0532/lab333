using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        abstract public class Norma //абстрактний клас
        {
            public double Norm;
            public double Abs;
            public virtual double ABS(int a, int bi) //віртуальні методи
            {
                Console.WriteLine("ABS");
                return 1;
            }
            public virtual double NORM(int a, int bi) //віртуальні методи
            {
                Console.WriteLine("NORM");
                return 1;
            }
        }
        public class Complex : Norma //клас-наслідник для роботи з комплексними числами
        {
            public override double NORM(int a,int bi) //перевизначений метод норми
            {
                Norm = Math.Pow(a, 2) + Math.Pow(bi, 2);
                return Norm;
            }
            public override double ABS(int a, int bi) //перевизначений метод модуля
            {
                return Math.Sqrt(NORM(a,bi));
            }
            
        }
        public class Vector : Norma //клас-наслідник для роботи з векторами
        {
            public override double NORM(int x, int y)  //перевизначений метод норми
            {
                Norm = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                return Norm;
            }
            public override double ABS(int x, int y) //перевизначений метод модуля
            {
                return Math.Max(Math.Abs(x),Math.Abs(y));
            }
        }
    }
}
