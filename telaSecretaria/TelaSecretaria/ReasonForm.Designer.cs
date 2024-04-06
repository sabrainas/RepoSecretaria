namespace TelaSecretaria
{
    partial class ReasonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelReason = new System.Windows.Forms.Label();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.buttonSubmitReason = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReason.Location = new System.Drawing.Point(13, 23);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(384, 30);
            this.labelReason.TabIndex = 1;
            this.labelReason.Text = "Infome o motivo do indeferimento:";
            // 
            // textBoxReason
            // 
            this.textBoxReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReason.Location = new System.Drawing.Point(15, 59);
            this.textBoxReason.Multiline = true;
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxReason.Size = new System.Drawing.Size(389, 130);
            this.textBoxReason.TabIndex = 0;
            this.textBoxReason.TextChanged += new System.EventHandler(this.textBoxReason_TextChanged);
            // 
            // buttonSubmitReason
            // 
            this.buttonSubmitReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitReason.Location = new System.Drawing.Point(273, 195);
            this.buttonSubmitReason.Name = "buttonSubmitReason";
            this.buttonSubmitReason.Size = new System.Drawing.Size(131, 41);
            this.buttonSubmitReason.TabIndex = 2;
            this.buttonSubmitReason.Text = "Enviar";
            this.buttonSubmitReason.UseVisualStyleBackColor = true;
            this.buttonSubmitReason.Click += new System.EventHandler(this.buttonSubmitReason_Click_1);
            // 
            // ReasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(417, 247);
            this.Controls.Add(this.buttonSubmitReason);
            this.Controls.Add(this.labelReason);
            this.Controls.Add(this.textBoxReason);
            this.Name = "ReasonForm";
            this.Text = "ReasonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.Button buttonSubmitReason;
    }
}