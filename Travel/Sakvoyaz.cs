using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha
{
    class Sakvoyaz : Agency
    {
        const int TICKET_PRICE_TO_SPANISH = 3806;
        const int TICKET_PRICE_TO_ITALY = 4020;

        public Sakvoyaz()
        {
            name = "Саквояж";
            counter++;
        }
        override public void Calculate()
        {
            Console.Write("Количество проданных путевок в Испанию: ");
            response = Console.ReadLine();
            Tickets_spain = int.Parse(response);

            Console.Write("Количество проданных путевок в Италию: ");
            response = Console.ReadLine();
            Tickets_italy = int.Parse(response);

            volume =
                (TICKET_PRICE_TO_SPANISH * tickets_spain) +
                (TICKET_PRICE_TO_ITALY * tickets_italy);

            sold = tickets_spain + tickets_italy;

        }
        public void Calculate(int tickets_spain, int tickets_italy)
        {
            Tickets_spain = tickets_spain;
            Tickets_italy = tickets_italy;

            volume =
                (TICKET_PRICE_TO_SPANISH * tickets_spain) +
                (TICKET_PRICE_TO_ITALY * tickets_italy);

            sold = tickets_spain + tickets_italy;
        }
        override public void DisplaySale()
        {
            MessageBox.Show(name + "\n\n" +
                        "Количество проданных путевок в Испанию: " + Tickets_spain + "\n" +
                        "Количество проданных путевок в Италию: " + Tickets_italy + "\n" +
                        "Общее количество проданных путевок: " + Sold + "\n" + "\n" +
                        "Объём продаж: " + Volume + " руб." + "\n",
                        "Расчет итоговой оценки", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
