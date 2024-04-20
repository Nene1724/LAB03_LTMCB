namespace LAB03
{
    partial class bai4
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(21, 25);
            button1.Name = "button1";
            button1.Size = new Size(199, 41);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(245, 25);
            button2.Name = "button2";
            button2.Size = new Size(255, 41);
            button2.TabIndex = 2;
            button2.Text = "Tạo thêm Client";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // bai4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 116);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "bai4";
            Text = "bai4";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
    }
}