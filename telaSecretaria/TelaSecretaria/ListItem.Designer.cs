namespace TelaSecretaria
{
    partial class ListItem
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListItem));
            this.labelAluno = new System.Windows.Forms.Label();
            this.botaoDeferir = new System.Windows.Forms.Button();
            this.botaoIndeferir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPdf = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAluno
            // 
            this.labelAluno.AutoSize = true;
            this.labelAluno.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAluno.Location = new System.Drawing.Point(16, 23);
            this.labelAluno.Name = "labelAluno";
            this.labelAluno.Size = new System.Drawing.Size(377, 28);
            this.labelAluno.TabIndex = 0;
            this.labelAluno.Text = "Sabrina do Espirito Santo Mendonça";
            // 
            // botaoDeferir
            // 
            this.botaoDeferir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.botaoDeferir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoDeferir.FlatAppearance.BorderSize = 0;
            this.botaoDeferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoDeferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoDeferir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botaoDeferir.Location = new System.Drawing.Point(586, 82);
            this.botaoDeferir.Name = "botaoDeferir";
            this.botaoDeferir.Size = new System.Drawing.Size(135, 38);
            this.botaoDeferir.TabIndex = 2;
            this.botaoDeferir.Text = "Deferir";
            this.botaoDeferir.UseVisualStyleBackColor = false;
            this.botaoDeferir.Click += new System.EventHandler(this.botaoDeferir_Click);
            // 
            // botaoIndeferir
            // 
            this.botaoIndeferir.BackColor = System.Drawing.Color.Brown;
            this.botaoIndeferir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoIndeferir.FlatAppearance.BorderSize = 0;
            this.botaoIndeferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoIndeferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoIndeferir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botaoIndeferir.Location = new System.Drawing.Point(737, 82);
            this.botaoIndeferir.Name = "botaoIndeferir";
            this.botaoIndeferir.Size = new System.Drawing.Size(135, 38);
            this.botaoIndeferir.TabIndex = 3;
            this.botaoIndeferir.Text = "Indeferir";
            this.botaoIndeferir.UseVisualStyleBackColor = false;
            this.botaoIndeferir.Click += new System.EventHandler(this.botaoIndeferir_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(441, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "RA: 123456789";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(154, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelPdf
            // 
            this.labelPdf.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.labelPdf.AutoSize = true;
            this.labelPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPdf.LinkColor = System.Drawing.Color.Brown;
            this.labelPdf.Location = new System.Drawing.Point(180, 54);
            this.labelPdf.Name = "labelPdf";
            this.labelPdf.Size = new System.Drawing.Size(74, 20);
            this.labelPdf.TabIndex = 1;
            this.labelPdf.TabStop = true;
            this.labelPdf.Text = "Ver PDF";
            this.labelPdf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelPdf_LinkClicked);
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botaoIndeferir);
            this.Controls.Add(this.botaoDeferir);
            this.Controls.Add(this.labelPdf);
            this.Controls.Add(this.labelAluno);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(884, 132);
            this.Load += new System.EventHandler(this.ListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAluno;
        private System.Windows.Forms.Button botaoDeferir;
        private System.Windows.Forms.Button botaoIndeferir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel labelPdf;
    }
}
