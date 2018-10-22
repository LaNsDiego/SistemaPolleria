using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.Ayuda
{
    public class ClsNUI
    {
        public static void AjustarEstadoControles(List<Control> Controles,bool disponibilidad)
        {
            foreach (Control control in Controles)
            {
                control.Enabled = disponibilidad;
            }
        }

        public static void LimpiarControles(List<Control> Controles)
        {
            foreach (Control control in Controles)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }else if(control is DateTimePicker)
                {
                    control.ResetText();
                }else if (control is GroupBox)
                {
                    ((RadioButton)control.Controls[0]).Checked = true;
                }
            }
        }
    }
}
