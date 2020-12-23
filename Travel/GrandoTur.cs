using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha
{
    class GrandoTur : Agency
    {
        const int TICKET_PRICE_TO_SPANISH = 3806;
        const int TICKET_PRICE_TO_ITALY = 4020;
        const int TICKET_PRICE_TO_GREECE = 6320;
        const int TICKET_PRICE_TO_TURKEY = 5421;
        

        
        public GrandoTur()
        {
            name = "ГрандоТур";
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

            Console.Write("Количество проданных путевок в Грецию: ");
            response = Console.ReadLine();
            Tickets_greece = int.Parse(response);

            Console.Write("Количество проданных путевок в Турцию: ");
            response = Console.ReadLine();
            Tickets_turkey = int.Parse(response);

            volume =
                (TICKET_PRICE_TO_SPANISH * tickets_spain) +
                (TICKET_PRICE_TO_ITALY * tickets_italy) +
                (TICKET_PRICE_TO_GREECE * tickets_greece) +
                (TICKET_PRICE_TO_TURKEY * tickets_turkey);

            sold = tickets_spain + tickets_italy + tickets_greece + tickets_turkey;
        }
        public void Calculate(int tickets_spain, int tickets_greece, int tickets_italy, int tickets_turkey)
        {
            Tickets_spain = tickets_spain;
            Tickets_italy = tickets_italy;
            Tickets_greece = tickets_greece;
            Tickets_turkey = tickets_turkey;

            volume =
                (TICKET_PRICE_TO_SPANISH * tickets_spain) +
                (TICKET_PRICE_TO_ITALY * tickets_italy) +
                (TICKET_PRICE_TO_GREECE * tickets_greece) +
                (TICKET_PRICE_TO_TURKEY * tickets_turkey);

            sold = tickets_spain + tickets_italy + tickets_greece + tickets_turkey;
        }
        override public void DisplaySale()
        {
            MessageBox.Show(name + "\n\n" +
                        "Количество проданных путевок в Испанию: " + Tickets_spain + "\n" +
                        "Количество проданных путевок в Италию: " + Tickets_italy + "\n" +
                        "Количество проданных путевок в Грецию: " + Tickets_greece + "\n" +
                        "Количество проданных путевок в Турцию: " + Tickets_turkey + "\n" + "\n" +
                        "Общее количество проданных путевок: " + Sold + "\n" + "\n" +
                        "Объём продаж: " + Volume + " руб." + "\n",
                        "Расчет итоговой оценки", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
