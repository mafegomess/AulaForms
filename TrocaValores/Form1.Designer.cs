namespace TrocaValores
{
    partial class FrmTrocaValores
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
            LabelValor1 = new Label();
            txtValor1 = new TextBox();
            LabelValor2 = new Label();
            txtValor2 = new TextBox();
            BtnTroca = new Button();
            SuspendLayout();
            // 
            // LabelValor1
            // 
            LabelValor1.AutoSize = true;
            LabelValor1.Location = new Point(146, 129);
            LabelValor1.Name = "LabelValor1";
            LabelValor1.Size = new Size(45, 15);
            LabelValor1.TabIndex = 0;
            LabelValor1.Text = "Valor 1:";
            LabelValor1.Click += label1_Click;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(197, 126);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(100, 23);
            txtValor1.TabIndex = 1;
            // 
            // LabelValor2
            // 
            LabelValor2.AutoSize = true;
            LabelValor2.Location = new Point(377, 130);
            LabelValor2.Name = "LabelValor2";
            LabelValor2.Size = new Size(45, 15);
            LabelValor2.TabIndex = 2;
            LabelValor2.Text = "Valor 2:";
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(428, 127);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(100, 23);
            txtValor2.TabIndex = 3;
            // 
            // BtnTroca
            // 
            BtnTroca.Location = new Point(298, 242);
            BtnTroca.Name = "BtnTroca";
            BtnTroca.Size = new Size(75, 23);
            BtnTroca.TabIndex = 4;
            BtnTroca.Text = "Trocar";
            BtnTroca.UseVisualStyleBackColor = true;
            BtnTroca.Click += BtnTroca_Click;
            // 
            // FrmTrocaValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnTroca);
            Controls.Add(txtValor2);
            Controls.Add(LabelValor2);
            Controls.Add(txtValor1);
            Controls.Add(LabelValor1);
            Name = "FrmTrocaValores";
            Text = "Troca de Valores";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelValor1;
        private TextBox txtValor1;
        private Label LabelValor2;
        private TextBox txtValor2;
        private Button BtnTroca;
    }
}
