using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversion_de_grados
{
    class solo_numeros
    {
        public static void numero(KeyPressEventArgs v)
        {
            if (Char.IsNumber(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                if (Char.IsControl(v.KeyChar))
                {
                    v.Handled = false;
                }
                else
                {
                    if (v.KeyChar.ToString().Equals(".") || v.KeyChar.ToString().Equals("-"))
                    {
                        v.Handled = false;
                    }
                    else
                    {
                        v.Handled = true;
                        MessageBox.Show("solo numero o numeros con punto decimal","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
            }
        }
    }
}
