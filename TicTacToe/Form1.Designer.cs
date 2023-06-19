namespace TicTacToe
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
            field1 = new Button();
            field2 = new Button();
            field3 = new Button();
            field6 = new Button();
            field5 = new Button();
            field4 = new Button();
            field9 = new Button();
            field8 = new Button();
            field7 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // field1
            // 
            field1.Cursor = Cursors.Hand;
            field1.Font = new Font("Segoe UI", 41.25F, FontStyle.Regular, GraphicsUnit.Point);
            field1.Location = new Point(12, 12);
            field1.Name = "field1";
            field1.Size = new Size(85, 85);
            field1.TabIndex = 0;
            field1.UseVisualStyleBackColor = true;
            field1.MouseClick += fieldClick;
            // 
            // field2
            // 
            field2.Cursor = Cursors.Hand;
            field2.Font = new Font("Segoe UI", 41.25F, FontStyle.Regular, GraphicsUnit.Point);
            field2.Location = new Point(103, 12);
            field2.Name = "field2";
            field2.Size = new Size(85, 85);
            field2.TabIndex = 1;
            field2.UseVisualStyleBackColor = true;
            field2.MouseClick += fieldClick;
            // 
            // field3
            // 
            field3.Cursor = Cursors.Hand;
            field3.Font = new Font("Segoe UI", 41.25F, FontStyle.Regular, GraphicsUnit.Point);
            field3.Location = new Point(194, 12);
            field3.Name = "field3";
            field3.Size = new Size(85, 85);
            field3.TabIndex = 2;
            field3.UseVisualStyleBackColor = true;
            field3.MouseClick += fieldClick;
            // 
            // field6
            // 
            field6.Cursor = Cursors.Hand;
            field6.Font = new Font("Segoe UI", 41.25F, FontStyle.Regular, GraphicsUnit.Point);
            field6.Location = new Point(194, 103);
            field6.Name = "field6";
            field6.Size = new Size(85, 85);
            field6.TabIndex = 5;
            field6.UseVisualStyleBackColor = true;
            field6.MouseClick += fieldClick;
            // 
            // field5
            // 
            field5.Cursor = Cursors.Hand;
            field5.Font = new Font("Segoe UI", 41.25F, FontStyle.Regular, GraphicsUnit.Point);
            field5.Location = new Point(103, 103);
            field5.Name = "field5";
            field5.Size = new Size(85, 85);
            field5.TabIndex = 4;
            field5.UseVisualStyleBackColor = true;
            field5.MouseClick += fieldClick;
            // 
            // field4
            // 
            field4.Cursor = Cursors.Hand;
            field4.Font = new Font("Segoe UI", 41.25F, FontStyle.Regular, GraphicsUnit.Point);
            field4.Location = new Point(12, 103);
            field4.Name = "field4";
            field4.Size = new Size(85, 85);
            field4.TabIndex = 3;
            field4.UseVisualStyleBackColor = true;
            field4.MouseClick += fieldClick;
            // 
            // field9
            // 
            field9.Cursor = Cursors.Hand;
            field9.Font = new Font("Segoe UI", 41.25F, FontStyle.Regular, GraphicsUnit.Point);
            field9.Location = new Point(194, 194);
            field9.Name = "field9";
            field9.Size = new Size(85, 85);
            field9.TabIndex = 8;
            field9.UseVisualStyleBackColor = true;
            field9.MouseClick += fieldClick;
            // 
            // field8
            // 
            field8.Cursor = Cursors.Hand;
            field8.Font = new Font("Segoe UI", 41.25F, FontStyle.Regular, GraphicsUnit.Point);
            field8.Location = new Point(103, 194);
            field8.Name = "field8";
            field8.Size = new Size(85, 85);
            field8.TabIndex = 7;
            field8.UseVisualStyleBackColor = true;
            field8.MouseClick += fieldClick;
            // 
            // field7
            // 
            field7.Cursor = Cursors.Hand;
            field7.Font = new Font("Segoe UI", 41.25F, FontStyle.Regular, GraphicsUnit.Point);
            field7.Location = new Point(12, 194);
            field7.Name = "field7";
            field7.Size = new Size(85, 85);
            field7.TabIndex = 6;
            field7.UseVisualStyleBackColor = true;
            field7.MouseClick += fieldClick;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 298);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(267, 69);
            label1.TabIndex = 9;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 375);
            Controls.Add(label1);
            Controls.Add(field9);
            Controls.Add(field8);
            Controls.Add(field7);
            Controls.Add(field6);
            Controls.Add(field5);
            Controls.Add(field4);
            Controls.Add(field3);
            Controls.Add(field2);
            Controls.Add(field1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            ResumeLayout(false);
        }

        #endregion

        private Button field1;
        private Button field2;
        private Button field3;
        private Button field6;
        private Button field5;
        private Button field4;
        private Button field9;
        private Button field8;
        private Button field7;
        private Label label1;
    }
}