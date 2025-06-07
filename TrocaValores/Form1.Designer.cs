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
            LabelValor1.Location = new Point(186, 128);
            LabelValor1.Name = "LabelValor1";
            LabelValor1.Size = new Size(45, 15);
            LabelValor1.TabIndex = 0;
            LabelValor1.Text = "Valor 1:";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(237, 127);
            txtValor1.Multiline = true;
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(100, 23);
            txtValor1.TabIndex = 1;
            // 
            // LabelValor2
            // 
            LabelValor2.AutoSize = true;
            LabelValor2.Location = new Point(422, 128);
            LabelValor2.Name = "LabelValor2";
            LabelValor2.Size = new Size(45, 15);
            LabelValor2.TabIndex = 2;
            LabelValor2.Text = "Valor 2:";
            // 
            // txtValor2
            // 
            txtValor2.BackColor = SystemColors.Window;
            txtValor2.Location = new Point(473, 125);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(100, 23);
            txtValor2.TabIndex = 3;
            // 
            // BtnTroca
            // 
            BtnTroca.BackColor = Color.FromArgb(128, 128, 255);
            BtnTroca.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnTroca.ForeColor = SystemColors.ControlText;
            BtnTroca.Image = Properties.Resources._8665775_repeat_icon__1_;
            BtnTroca.Location = new Point(339, 230);
            BtnTroca.Margin = new Padding(0);
            BtnTroca.Name = "BtnTroca";
            BtnTroca.Size = new Size(78, 69);
            BtnTroca.TabIndex = 4;
            BtnTroca.Text = "Trocar";
            BtnTroca.UseVisualStyleBackColor = false;
            BtnTroca.Click += BtnTroca_Click;
            // 
            // FrmTrocaValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(BtnTroca);
            Controls.Add(txtValor2);
            Controls.Add(LabelValor2);
            Controls.Add(txtValor1);
            Controls.Add(LabelValor1);
            ForeColor = SystemColors.ControlText;
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
