using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversion_de_grados
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            centigrados.Enabled = false;
            farenheit.Enabled = false;
            kelvin.Enabled = false;
            rankine.Enabled = false;
            menu.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(menu.SelectedIndex)
            { 
                case 0:
                    farenheit.Enabled = true;
                    centigrados.Enabled=false;
                    kelvin.Enabled = false;
                    rankine.Enabled = false;
                    break;
                case 1:
                    farenheit.Enabled = false;
                    centigrados.Enabled = false;
                    kelvin.Enabled = true;
                    rankine.Enabled = false;

                    break;
                case 2:
                    centigrados.Enabled = true;
                    farenheit.Enabled = false;
                    kelvin.Enabled = false;
                    rankine.Enabled = false;
                    break;
                case 3:
                    centigrados.Enabled = false;
                    farenheit.Enabled = false;
                    kelvin.Enabled = false;
                    rankine.Enabled = true;
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void convertir_Click(object sender, EventArgs e)
        {
            double c,f,k,r;
            switch (menu.SelectedIndex)
            {
                case 0:
                    if (farenheit.Text == "")
                    {
                        MessageBox.Show("Error dejo una o mas casillas en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        f = Convert.ToDouble(farenheit.Text);
                        k = (f - 32) * (.555555555555) + 273.15;
                        kelvin.Text = k.ToString();
                        c = (f - 32) * 0.5555555555;
                        centigrados.Text = c.ToString();
                        r = f + 459.67;
                        rankine.Text = r.ToString();
                    }
                    break;
                case 1:
                    if (kelvin.Text == "")
                    {
                        MessageBox.Show("Error dejo una o mas casillas en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        k = Convert.ToDouble(kelvin.Text);
                        f = (k - 273) * (1.8) + 32;
                        farenheit.Text = f.ToString();
                        c = k - 273.15;
                        centigrados.Text = c.ToString();
                        r = k * 1.8;
                        rankine.Text = r.ToString();
                    }
                    break;
                case 2:
                    if (centigrados.Text == "")
                    {
                        MessageBox.Show("Error dejo una o mas casillas en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        c = Convert.ToDouble(centigrados.Text);
                        k = c + 273.15;
                        kelvin.Text = k.ToString();
                        f = (c * 1.8) + 32;
                        farenheit.Text = f.ToString();
                        r = (c * 1.8) + 491.67;
                        rankine.Text = r.ToString();
                    }
                    break;
                case 3:
                    if (rankine.Text == "")
                    {
                        MessageBox.Show("Error dejo una o mas casillas en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        r = Convert.ToDouble(rankine.Text);
                        c = (r - 491.67) * (0.5555555);
                        centigrados.Text = c.ToString();
                        k = (r) * (0.555555);
                        kelvin.Text = k.ToString();
                        f = r - 459.67;
                        farenheit.Text = f.ToString();
                    }
                    break;
                default:
                    MessageBox.Show("Error dejo una o mas casillas en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar el programa", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            string s;
            s = "";
            kelvin.Text = s;
            centigrados.Text = s;
            farenheit.Text = s;
            rankine.Text = s;
        }

        private void kelvin_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void kelvin_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros.numero(e);
        }

        private void Conversiones(object sender, EventArgs e)
        {

        }
    }
}
