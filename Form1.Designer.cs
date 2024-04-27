namespace Forms1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceitar = new Button();
            btnRejeitar = new Button();
            txtMensagem = new TextBox();
            SuspendLayout();
            // 
            // btnAceitar
            // 
            btnAceitar.BackColor = Color.Lime;
            btnAceitar.Cursor = Cursors.Hand;
            btnAceitar.Font = new Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceitar.Location = new Point(379, 146);
            btnAceitar.Name = "btnAceitar";
            btnAceitar.Size = new Size(253, 221);
            btnAceitar.TabIndex = 0;
            btnAceitar.Text = "SIM";
            btnAceitar.UseVisualStyleBackColor = false;
            btnAceitar.BackColorChanged += Aceitar_Click;
            btnAceitar.Click += Aceitar_Click;
            // 
            // btnRejeitar
            // 
            btnRejeitar.BackColor = Color.Red;
            btnRejeitar.Cursor = Cursors.Hand;
            btnRejeitar.FlatStyle = FlatStyle.Popup;
            btnRejeitar.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnRejeitar.ForeColor = Color.Black;
            btnRejeitar.Location = new Point(68, 146);
            btnRejeitar.Name = "btnRejeitar";
            btnRejeitar.Size = new Size(253, 221);
            btnRejeitar.TabIndex = 1;
            btnRejeitar.Text = "NÃO";
            btnRejeitar.UseVisualStyleBackColor = false;
            btnRejeitar.Click += Rejeitar_Click;
            // 
            // txtMensagem
            // 
            txtMensagem.Font = new Font("Papyrus", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtMensagem.Location = new Point(77, 49);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(573, 52);
            txtMensagem.TabIndex = 2;
            txtMensagem.Text = "Cancelar assinatura?";
            txtMensagem.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMensagem);
            Controls.Add(btnRejeitar);
            Controls.Add(btnAceitar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceitar;
        private Button btnRejeitar;
        private TextBox txtMensagem;
    }
}