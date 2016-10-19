using System;
using System.Windows.Forms;

namespace AutoUnpack
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }

        public string Value => txtValue.Text;

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}