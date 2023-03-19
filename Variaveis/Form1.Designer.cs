namespace Variaveis
{
    partial class frmSoma
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
            btnInteiros = new Button();
            btnReais = new Button();
            lblA = new Label();
            lblB = new Label();
            lblResultado = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // btnInteiros
            // 
            btnInteiros.Location = new Point(216, 14);
            btnInteiros.Name = "btnInteiros";
            btnInteiros.Size = new Size(75, 23);
            btnInteiros.TabIndex = 0;
            btnInteiros.Text = "Inteiros";
            btnInteiros.UseVisualStyleBackColor = true;
            btnInteiros.Click += btnInteiros_Click;
            // 
            // btnReais
            // 
            btnReais.Location = new Point(216, 46);
            btnReais.Name = "btnReais";
            btnReais.Size = new Size(75, 23);
            btnReais.TabIndex = 1;
            btnReais.Text = "Reais";
            btnReais.UseVisualStyleBackColor = true;
            btnReais.Click += btnReais_Click;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(53, 14);
            lblA.Name = "lblA";
            lblA.Size = new Size(40, 15);
            lblA.TabIndex = 2;
            lblA.Text = "numA";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(53, 46);
            lblB.Name = "lblB";
            lblB.Size = new Size(39, 15);
            lblB.TabIndex = 3;
            lblB.Text = "numB";
            lblB.Click += label2_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 85);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado";
            // 
            // txtA
            // 
            txtA.Location = new Point(110, 6);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 5;
            // 
            // txtB
            // 
            txtB.Location = new Point(110, 38);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 6;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(110, 77);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 7;
            // 
            // frmSoma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 139);
            Controls.Add(txtResultado);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblResultado);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(btnReais);
            Controls.Add(btnInteiros);
            Name = "frmSoma";
            Text = "Soma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInteiros;
        private Button btnReais;
        private Label lblA;
        private Label lblB;
        private Label lblResultado;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtResultado;
    }
}