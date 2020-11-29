using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeForms.MainTask2
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void cmdOpenGreenPeaceForm_Click(object sender, EventArgs e)
        {
            GreenpeaceForm greenpeaceForm = new GreenpeaceForm();
            greenpeaceForm.Show();
        }
    }
}
