namespace TicTacToe
{
    partial class Form2
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
            PvP = new Button();
            label1 = new Label();
            PvE = new Button();
            SuspendLayout();
            // 
            // PvP
            // 
            PvP.Location = new Point(12, 69);
            PvP.Name = "PvP";
            PvP.Size = new Size(151, 58);
            PvP.TabIndex = 0;
            PvP.Text = "Player vs Player";
            PvP.UseVisualStyleBackColor = true;
            PvP.Click += PvP_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(88, 20);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 1;
            label1.Text = "Start new game";
            // 
            // PvE
            // 
            PvE.Location = new Point(169, 69);
            PvE.Name = "PvE";
            PvE.Size = new Size(151, 58);
            PvE.TabIndex = 2;
            PvE.Text = "Player vs Computer";
            PvE.UseVisualStyleBackColor = true;
            PvE.Click += PvE_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 151);
            Controls.Add(PvE);
            Controls.Add(label1);
            Controls.Add(PvP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PvP;
        private Label label1;
        private Button PvE;
    }
}