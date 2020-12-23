using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha
{
    class Sputnik : Agency
    {
        const int TICKET_PRICE_TO_ITALY = 4020;
        const int TICKET_PRICE_TO_GERMANY = 3441;
        const int TICKET_PRICE_TO_ENGLAND = 7430;

        public Sputnik()
        {
            name = "Спутник";
            counter++;
        }
        override public void Calculate()
        {
            Console.Write("Количество проданных путевок в Италию: ");
            response = Console.ReadLine();
            Tickets_italy = int.Parse(response);

            Console.Write("Количество проданных путевок в Англию: ");
            response = Console.ReadLine();
            Tickets_england = int.Parse(response);

            Console.Write("Количество проданных путевок в Германию: ");
            response = Console.ReadLine();
            Tickets_germany = int.Parse(response);

            volume =
                (TICKET_PRICE_TO_ENGLAND * tickets_england) +
                (TICKET_PRICE_TO_ITALY * tickets_italy) +
                (TICKET_PRICE_TO_GERMANY * tickets_germany);

            sold = tickets_italy + tickets_germany + tickets_italy;
        }
        public void Calculate(int tickets_italy, int tickets_england, int tickets_germany)
        {
            Tickets_italy = tickets_italy;
            Tickets_england = tickets_england;
            Tickets_germany = tickets_germany;

            volume =
                (TICKET_PRICE_TO_ENGLAND * tickets_england) +
                (TICKET_PRICE_TO_ITALY * tickets_italy) +
                (TICKET_PRICE_TO_GERMANY * tickets_germany);

            sold = tickets_spain + tickets_italy + tickets_greece + tickets_turkey;
        }
        override public void DisplaySale()
        {
            MessageBox.Show(name + "\n\n" +
                        "Количество проданных путевок в Италию: " + Tickets_italy + "\n" +
                        "Количество проданных путевок в Англию: " + Tickets_england + "\n" +
                        "Количество проданных путевок в Германию: " + Tickets_germany + "\n" +
                        "Общее количество проданных путевок: " + Sold + "\n" + "\n" +
                        "Объём продаж: " + Volume + " руб." + "\n",
                        "Расчет итоговой оценки", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
