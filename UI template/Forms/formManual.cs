using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_template.Forms
{
    public partial class formManual : Form
    {
        public formManual()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            gbx_input.ForeColor = ThemeColor.SecondaryColor;
            gbx_output.ForeColor = ThemeColor.SecondaryColor;
            foreach (Control btns in gbx_input.Controls)
            {
                btns.ForeColor = Color.Black;
            }
            foreach (Control btns in gbx_output.Controls)
            {
                btns.ForeColor = Color.Black;
            }

        }

        private void frmManual_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
