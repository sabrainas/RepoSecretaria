using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TelaSecretaria
{
    public partial class ListItem : UserControl
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn (int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);
        public ListItem()
        {
            InitializeComponent();
            ApplyCustomButtonStyle(botaoDeferir);
            ApplyCustomButtonStyle(botaoIndeferir);
            ApplyCustomControlStyle(this);

        }

        #region Properties
        private string _nameStudent;

        public string NameStudent
        {
            get { return _nameStudent; }
            set { _nameStudent = value; }
        }
        #endregion

        private void botaoDeferir_Click(object sender, EventArgs e)
        {
            // Evento de clique do botão
        }

        // Método para aplicar estilos personalizados ao botão
        private void ApplyCustomButtonStyle(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            if (button == botaoDeferir)
            {
                button.BackColor = Color.FromArgb(34, 139, 34); //verde
            }
            if (button == botaoIndeferir) {
                button.BackColor = Color.FromArgb(165, 42, 42); //vermelho
            }
            
            button.ForeColor = Color.White;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.FlatAppearance.BorderSize = 0;
            button.Cursor = Cursors.Hand;

            
        }

        private void ListItem_Load(object sender, EventArgs e)
        {
            botaoDeferir.Region = Region.FromHrgn(CreateRoundRectRgn(0,0,botaoDeferir.Width,botaoDeferir.Height,5,5));

            botaoIndeferir.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, botaoDeferir.Width, botaoDeferir.Height, 5, 5));

        }

        private void ApplyCustomControlStyle(UserControl control)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, 5, 5));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelPdf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botaoIndeferir_Click(object sender, EventArgs e)
        {
            using (var reasonForm = new ReasonForm())
            {
                if (reasonForm.ShowDialog() == DialogResult.OK)
                {
                    string reason = reasonForm.Reason;
                    // Faça o que quiser com o motivo inserido
                    // Por exemplo, você pode exibi-lo em algum lugar ou salvá-lo em um banco de dados
                    MessageBox.Show($"Motivo do indeferimento: {reason}", "Motivo");
                }
            }
        }

        private void botaoIndeferir_Click_1(object sender, EventArgs e)
        {
            using (var reasonForm = new ReasonForm())
            {
                if (reasonForm.ShowDialog() == DialogResult.OK)
                {
                    string reason = reasonForm.Reason;
                    // Faça o que quiser com o motivo inserido
                    // Por exemplo, você pode exibi-lo em algum lugar ou salvá-lo em um banco de dados
                    MessageBox.Show($"Motivo do indeferimento: {reason}", "Motivo");
                }
            }
        }
    }
}
