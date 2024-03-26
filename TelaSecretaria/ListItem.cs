using System;
using System.Drawing;
using System.Windows.Forms;

namespace TelaSecretaria
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
            ApplyCustomButtonStyle(botaoDeferir);
            ApplyCustomButtonStyle(botaoIndeferir);
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
    }
}
