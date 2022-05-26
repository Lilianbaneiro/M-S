using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Carregar os números
            cbMes.Items.Add(01);
            cbMes.Items.Add(02);
            cbMes.Items.Add(03);
            cbMes.Items.Add(04);
            cbMes.Items.Add(05);
            cbMes.Items.Add(05);
            cbMes.Items.Add(06);
            cbMes.Items.Add(07);
            cbMes.Items.Add(08);
            cbMes.Items.Add(09);
            cbMes.Items.Add(10);
            cbMes.Items.Add(11);
            cbMes.Items.Add(12);

            cbMescase.Items.Add(01);
            cbMescase.Items.Add(02);
            cbMescase.Items.Add(03);
            cbMescase.Items.Add(04);
            cbMescase.Items.Add(05);
            cbMescase.Items.Add(05);
            cbMescase.Items.Add(06);
            cbMescase.Items.Add(07);
            cbMescase.Items.Add(08);
            cbMescase.Items.Add(09);
            cbMescase.Items.Add(10);
            cbMescase.Items.Add(11);
            cbMescase.Items.Add(12);
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(cbMes.SelectedItem);
            
            if (numero == 1)
            {
                lbMes.Text = "Janeiro";
            }
            if (numero == 2)
            {
                lbMes.Text = "Fevereiro";
            }
            if (numero == 3)
            {
                lbMes.Text = "Março";
            }
            if (numero == 4)
            {
                lbMes.Text = "Abril";
            }
            if (numero == 5)
            {
                lbMes.Text = "Maio";
            }
            if (numero == 6)
            {
                lbMes.Text = "Junho";
            }
            if (numero == 7)
            {
                lbMes.Text = "Julho";
            }
            if (numero == 8)
            {
                lbMes.Text = "Agosto";
            }
            if (numero == 9)
            {
                lbMes.Text = "Setembro";
            }
            if (numero == 10)
            {
                lbMes.Text = "Outubro";
            }
            if (numero == 11)
            {
                lbMes.Text = "Novembro";
            }
            else if (numero == 12)
            {
                lbMes.Text = "Dezembro";
            }

            //exibir resultado
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbMescase_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Mescase = Convert.ToInt32(cbMescase.SelectedItem);
            switch(Mescase)
            {
                case 01:
                    lbMescase.Text = "Janeiro";
                    break;
                case 02:
                    lbMescase.Text = "Fevereiro";
                    break;
                case 03:
                    lbMescase.Text = "Março";
                    break;
                case 04:
                    lbMescase.Text = "Abril";
                    break;
                case 05:
                    lbMescase.Text = "Maio";
                    break;
                case 06:
                    lbMescase.Text = "Junho";
                    break;
                case 07:
                    lbMescase.Text = "Julho";
                    break;
                case 08:
                    lbMescase.Text = "Agosto";
                    break;
                case 09:
                    lbMescase.Text = "Setembro";
                    break;
                case 10:
                    lbMescase.Text = "Outubro";
                    break;
                case 11:
                    lbMescase.Text = "Novembro";
                    break;
                default:
                    lbMescase.Text = "Dezembro";
                    break;

            }
        }
    }
}
