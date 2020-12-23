using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zadacha
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void FormTravel_Load(object sender, EventArgs e)
        {

        }

        private void radGrandoTur_CheckedChanged(object sender, EventArgs e)
        {
            txtSpain.Visible = true;
            txtTurkey.Visible = true;
            txtItaly.Visible = true;
            txtGreece.Visible = true;
            txtGermany.Visible = false;
            txtEngland.Visible = false;
            lblTypes.Text = "ГРАНДОТУР";

            txtSpain.Text = "";
            txtTurkey.Text = "";
            txtItaly.Text = "";
            txtGermany.Text = "";
            txtGreece.Text = "";
            txtEngland.Text = "";

            lblSpain.Visible = true;
            lblTurkey.Visible = true;
            lblGreece.Visible = true;
            lblItaly.Visible = true;
            lblEngland.Visible = false;
            lblGermany.Visible = false;
        }

        private void radSakvoyz_CheckedChanged(object sender, EventArgs e)
        {
            txtSpain.Visible = true;
            txtTurkey.Visible = false;
            txtItaly.Visible = true;
            txtGreece.Visible = false;
            txtGermany.Visible = false;
            txtEngland.Visible = false;
            lblTypes.Text = "САКВОЯЖ";

            txtSpain.Text = "";
            txtTurkey.Text = "";
            txtItaly.Text = "";
            txtGermany.Text = "";
            txtGreece.Text = "";
            txtEngland.Text = "";

            lblItaly.Visible = true;
            lblTurkey.Visible = false;
            lblGreece.Visible = false;
            lblSpain.Visible = true;
            lblEngland.Visible = false;
            lblGermany.Visible = false;
        }

        private void radSputnik_CheckedChanged(object sender, EventArgs e)
        {
            txtSpain.Visible = false;
            txtTurkey.Visible = false;
            txtItaly.Visible = true;
            txtGreece.Visible = false;
            txtGermany.Visible = true;
            txtEngland.Visible = true;
            lblTypes.Text = "СПУТНИК";

            txtSpain.Text = "";
            txtTurkey.Text = "";
            txtItaly.Text = "";
            txtGermany.Text = "";
            txtGreece.Text = "";
            txtEngland.Text = "";

            lblSpain.Visible = false;
            lblTurkey.Visible = false;
            lblGreece.Visible = false;
            lblItaly.Visible = true;
            lblEngland.Visible = true;
            lblGermany.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSpain.Visible = true;
            txtTurkey.Visible = true;
            txtItaly.Visible = true;
            txtGreece.Visible = true;
            txtGermany.Visible = false;
            txtEngland.Visible = false;

            txtSpain.Text = "";
            txtTurkey.Text = "";
            txtItaly.Text = "";
            txtGermany.Text = "";
            txtGreece.Text = "";
            txtEngland.Text = "";

            radGrandoTur.Checked = true;

            lblTypes.Text = "ГРАНДОТУР";
            lblVolume.Text = "ОБЪЁМ ПРОДАЖ:";
            lblFirm.Text = "НАЗВАНИЕ ФИРМЫ:";
            lblSold.Text = "КОЛ-ВО ПРОДАННЫХ БИЛЕТОВ:";

            txtList.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (lblTypes.Text == "ГРАНДОТУР")
            {
                GrandoTur G = new GrandoTur();
                if ((txtSpain.Text == "") ||
                    (txtTurkey.Text == "") ||
                    (txtItaly.Text == "") ||
                    (txtGreece.Text == ""))
                {
                    MessageBox.Show("Необходимо задать данные",
                        "Расчёт оценки",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    Environment.Exit(0);
                }
                G.Calculate(
                    int.Parse(txtSpain.Text), 
                    int.Parse(txtTurkey.Text),
                    int.Parse(txtItaly.Text),
                    int.Parse(txtGreece.Text));
                lblVolume.Text = "ОБЪЁМ ПРОДАЖ: " + G.Volume + " руб.";
                lblFirm.Text = "НАЗВАНИЕ ФИРМЫ: " + G.name;
                lblSold.Text = "КОЛ-ВО ПРОДАННЫХ БИЛЕТОВ: " + G.Sold;
                txtList.Text += G.name + ": " + G.Volume + " руб." + "\r\n";
                Agency.pain[Agency.counter] = G.Volume;
                Agency.said_point[Agency.counter] = G.Sold;
            }
            if (lblTypes.Text == "СПУТНИК")
            {
                Sputnik S = new Sputnik();
                if ((txtGermany.Text == "") ||
                    (txtEngland.Text == "") ||
                    (txtItaly.Text == ""))
                {
                    MessageBox.Show("Необходимо задать данные",
                        "Расчёт оценки",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    Environment.Exit(0);
                }
                S.Calculate(
                    int.Parse(txtGermany.Text),
                    int.Parse(txtEngland.Text),
                    int.Parse(txtItaly.Text));
                lblVolume.Text = "ОБЪЁМ ПРОДАЖ: " + S.Volume + " руб.";
                lblFirm.Text = "НАЗВАНИЕ ФИРМЫ: " + S.name;
                lblSold.Text = "КОЛ-ВО ПРОДАННЫХ БИЛЕТОВ: " + S.Sold;
                txtList.Text += S.name + ": " + S.Volume + " руб." + "\r\n";
                Agency.pain[Agency.counter] = S.Volume;
                Agency.said_point[Agency.counter] = S.Sold;
            }
            if (lblTypes.Text == "САКВОЯЖ")
            {
                Sakvoyaz S1 = new Sakvoyaz();
                if ((txtSpain.Text == "") ||
                    (txtItaly.Text == ""))
                {
                    MessageBox.Show("Необходимо задать данные",
                        "Расчёт оценки",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    Environment.Exit(0);
                }
                S1.Calculate(
                    int.Parse(txtSpain.Text),
                    int.Parse(txtItaly.Text));
                lblVolume.Text = "ОБЪЁМ ПРОДАЖ: " + S1.Volume + " руб.";
                lblFirm.Text = "НАЗВАНИЕ ФИРМЫ: " + S1.name;
                lblSold.Text = "КОЛ-ВО ПРОДАННЫХ БИЛЕТОВ: " + S1.Sold;
                txtList.Text += S1.name + ": " + S1.Volume + " руб." + "\r\n";
                Agency.pain[Agency.counter] = S1.Volume;
                Agency.said_point[Agency.counter] = S1.Sold;
            }
            StreamWriter writer = new StreamWriter("F:\\pain.txt",false);
            writer.WriteLine(txtList.Text);
            writer.Close();
            //сохранение в файл. =^=
        }

        private void lblGermany_Click(object sender, EventArgs e)
        {

        }

        private void lblEngland_Click(object sender, EventArgs e)
        {

        }

        private void lblSpain_Click(object sender, EventArgs e)
        {

        }

        private void lblItaly_Click(object sender, EventArgs e)
        {

        }

        private void lblGreece_Click(object sender, EventArgs e)
        {

        }

        private void lblTurkey_Click(object sender, EventArgs e)
        {

        }

        private void lblVolume_Click(object sender, EventArgs e)
        {

        }

        private void lblFirm_Click(object sender, EventArgs e)
        {

        }

        private void lblVolumeFirm_Click(object sender, EventArgs e)
        {
        }

        private void lblTypes_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Общий объём продаж: "+ Agency.pain.Sum() + " руб." + "\n" +
                "Общее количество путёвок: " + Agency.said_point.Sum());

        }
    }
}
