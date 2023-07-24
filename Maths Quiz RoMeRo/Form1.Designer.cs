namespace Maths_Quiz_RoMeRo
{
    partial class Form1
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

        
        private void InitializeComponent()
        {
            lblNumA = new Label();
            lblSymbol = new Label();
            lblNumB = new Label();
            label4 = new Label();
            lblTotal = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNumA
            // 
            lblNumA.AutoSize = true;
            lblNumA.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumA.Location = new Point(88, 30);
            lblNumA.Margin = new Padding(4, 0, 4, 0);
            lblNumA.Name = "lblNumA";
            lblNumA.Size = new Size(49, 33);
            lblNumA.TabIndex = 0;
            lblNumA.Text = "00";
            // 
            // lblSymbol
            // 
            lblSymbol.AutoSize = true;
            lblSymbol.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSymbol.Location = new Point(162, 30);
            lblSymbol.Margin = new Padding(4, 0, 4, 0);
            lblSymbol.Name = "lblSymbol";
            lblSymbol.Size = new Size(32, 33);
            lblSymbol.TabIndex = 1;
            lblSymbol.Text = "?";
            // 
            // lblNumB
            // 
            lblNumB.AutoSize = true;
            lblNumB.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumB.Location = new Point(218, 30);
            lblNumB.Margin = new Padding(4, 0, 4, 0);
            lblNumB.Name = "lblNumB";
            lblNumB.Size = new Size(49, 33);
            lblNumB.TabIndex = 2;
            lblNumB.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(296, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(33, 33);
            label4.TabIndex = 3;
            label4.Text = "=";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(358, 30);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(49, 33);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 120);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(473, 33);
            label1.TabIndex = 5;
            label1.Text = "Press Q for +, W for - and E for x";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 182);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(label4);
            Controls.Add(lblNumB);
            Controls.Add(lblSymbol);
            Controls.Add(lblNumA);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Maths Quiz RoMeRo";
            KeyUp += KeyIsUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNumA;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label lblNumB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
    }
}
