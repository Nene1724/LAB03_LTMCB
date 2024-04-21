namespace LAB03
{
    partial class Client_bai3
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(40, 25);
            button1.Name = "button1";
            button1.Size = new Size(459, 160);
            button1.TabIndex = 0;
            button1.Text = "SEND";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Client_bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(547, 223);
            Controls.Add(button1);
            Name = "Client_bai3";
            Text = "Client_bai3";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}