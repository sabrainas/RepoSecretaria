using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaSecretaria
{
    public partial class ReasonForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);
        public string Reason => textBoxReason.Text;
        public ReasonForm()
        {
            InitializeComponent();
        }

        private void textBoxReason_TextChanged(object sender, EventArgs e)
        {

        }
        private void ReasonForm_Load(object sender, EventArgs e)
        {
            textBoxReason.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxReason.Width, textBoxReason.Height, 5, 5));

        }
        private void buttonSubmitReason_Click(object sender, EventArgs e)
        {
            // Fecha o formulário ReasonForm
            Close();
        }

        private void buttonSubmitReason_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
