using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci.DATA
{
    public static class Metot
    {
        //Formların kontrolleri gönderilerek temizlenecek.
        //Eğer gönderilen control bir groupbox veya flowlayoutpanel ise recursive olarak tekrar ilgili metot çağırılacak.
        public static void Temizle(Control.ControlCollection collection)
        {
            foreach (Control item in collection)
            {
                if (item is ComboBox) ((ComboBox)item).SelectedIndex = 0;
                else if (item is TextBox) ((TextBox)item).Text = "";
                else if (item is RadioButton) ((RadioButton)item).Checked = true;
                else if (item is CheckBox) ((CheckBox)item).Checked = false;
                else if (item is NumericUpDown) ((NumericUpDown)item).Value = 0;
                else if (item is FlowLayoutPanel) Temizle(((FlowLayoutPanel)item).Controls);
                else if (item is GroupBox) Temizle(((GroupBox)item).Controls);
            }

        }
    }
}
