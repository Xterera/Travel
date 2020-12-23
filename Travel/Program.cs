using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
namespace Zadacha
{
    
    class Program
    {
        static string response;
        static string more = "YES";
        static string WhatKindOfFirm()
        {
            Console.Write("Выберите фирму: Грандо-Тур(1);Саквояж(2);Спутник(3): ");
            response = Console.ReadLine();
            if (response == "")
            {
                MessageBox.Show("Вы должны выбрать название фирмы");
                Environment.Exit(0);
            }
            else
                if (int.Parse(response) < 1 | int.Parse(response) > 3)
            {
                MessageBox.Show("Вы должны выбрать название фирмы");
                Environment.Exit(0);
            }
            return response;
        }

        static void Main(string[] args)
        {
            while (more == "YES")
            {
                response = WhatKindOfFirm();
                switch (int.Parse(response))
                {
                    case 1:
                        {
                            GrandoTur G = new GrandoTur();
                            G.Calculate();
                            G.DisplaySale();
                            Pupil.pain[Pupil.counter] = G.Volume;
                            break;
                        }
                    case 2:
                        {
                            Sakvoyaz S = new Sakvoyaz();
                            S.Calculate();
                            S.DisplaySale();
                            Pupil.pain[Pupil.counter] = S.Volume;
                            break;
                        }
                    case 3:
                        {
                            Sputnik S1 = new Sputnik();
                            S1.Calculate();
                            S1.DisplaySale();
                            Pupil.pain[Pupil.counter] = S1.Volume;
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Вы должны выбрать название фирмы");
                            break;
                        }

                }
                Console.WriteLine("Попробуете еще раз?(Yes/No)");
                more = Console.ReadLine();
                more = more.ToUpper();
                Pupil.counter++;
            }
            if (Pupil.counter !=0) Pupil.DispSum();
            StreamWriter writer = new StreamWriter("F:\\pain.txt");

            for (int row = 0; row < Pupil.counter; row++)
            {
                writer.WriteLine(Pupil.pain[row]);
            }
            writer.Close();
            Console.WriteLine("Файл создан!");
            Console.ReadKey();
        }
    }

}
*/