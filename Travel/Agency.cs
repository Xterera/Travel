using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha
{
    public abstract class Agency
    {
        protected int tickets_germany = 0;
        protected int tickets_england = 0;
        protected int tickets_spain = 0;
        protected int tickets_italy = 0;
        protected int tickets_greece = 0;
        protected int tickets_turkey = 0;
        protected string response;
        protected int volume = 0;
        protected int sold = 0;

        internal protected string name = "";

        public static float[] pain = new float[1000];
        public static float[] said_point = new float[1000];
        public static float accumulator = 0;
        public static float average = 0;
        public static int counter = 0;
        public static int point = 0;

        public int Tickets_germany
        {
            get
            {
                return tickets_germany;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Неверное значение - " + value,
                        "Расчет оценки",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    Environment.Exit(0);
                }
                else
                    tickets_germany = value;
            }
        }

        public int Tickets_england
        {
            get
            {
                return tickets_england;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Неверное значение - " + value,
                        "Расчет оценки",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    Environment.Exit(0);
                }
                else
                    tickets_england = value;
            }
        }
        public int Tickets_greece
        {
            get
            {
                return tickets_greece;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Неверное значение - " + value,
                        "Расчет оценки",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    Environment.Exit(0);
                }
                else
                    tickets_greece = value;
            }
        }
        public int Tickets_turkey
        {
            get
            {
                return tickets_turkey;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Неверное значение - " + value,
                        "Расчет оценки",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    Environment.Exit(0);
                }
                else
                    tickets_turkey = value;
            }
        }
        public int Tickets_italy
        {
            get
            {
                return tickets_italy;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Неверное значение - " + value,
                        "Расчет оценки",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    Environment.Exit(0);
                }
                else
                    tickets_italy = value;
            }
        }
        public int Tickets_spain
        {
            get
            {
                return tickets_spain;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Неверное значение - " + value,
                        "Расчет оценки",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    Environment.Exit(0);
                }
                else
                    tickets_spain = value;
            }
        }
        public float Volume
        {
            get
            {
                return volume;
            }
            //set отсутствует
        }
        public float Sold
        {
            get
            {
                return sold;
            }
            //set отсутствует
        }
        public abstract void Calculate();
        public abstract void DisplaySale();
        public static void DispSum()
        {
            Console.WriteLine("Общий объём продаж: {0}", pain.Sum());
        }
    }
}
