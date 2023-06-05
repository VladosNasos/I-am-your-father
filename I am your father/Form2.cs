using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_am_your_father
{

    public partial class Luke : Form
    {
        public event EventHandler LukeTextChanged;
        public Luke()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void LukeTextBox_TextChanged(object sender, EventArgs e)
        {
            LukeTextChanged?.Invoke(this, EventArgs.Empty);
            //VaderTextBox.Text = LukeForm.LukeTextBox.Text;
        }
    }
}
