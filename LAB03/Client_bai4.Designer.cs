namespace LAB03
{
    partial class Client_bai4
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
            tbSend = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btSend = new Button();
            tbRespond = new TextBox();
            tbName = new TextBox();
            SuspendLayout();
            // 
            // tbSend
            // 
            tbSend.Location = new Point(134, 401);
            tbSend.Name = "tbSend";
            tbSend.Size = new Size(475, 31);
            tbSend.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightBlue;
            label1.Location = new Point(29, 354);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 3;
            label1.Text = "Your Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PowderBlue;
            label2.Location = new Point(29, 401);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 4;
            label2.Text = "Message";
            // 
            // btSend
            // 
            btSend.BackColor = Color.PaleVioletRed;
            btSend.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSend.Location = new Point(637, 348);
            btSend.Name = "btSend";
            btSend.Size = new Size(146, 84);
            btSend.TabIndex = 5;
            btSend.Text = "SEND";
            btSend.UseVisualStyleBackColor = false;
            btSend.Click += btSend_Click;
            // 
            // tbRespond
            // 
            tbRespond.BackColor = SystemColors.Info;
            tbRespond.Location = new Point(27, 15);
            tbRespond.Multiline = true;
            tbRespond.Name = "tbRespond";
            tbRespond.Size = new Size(756, 311);
            tbRespond.TabIndex = 6;
            // 
            // tbName
            // 
            tbName.Location = new Point(134, 354);
            tbName.Name = "tbName";
            tbName.Size = new Size(186, 31);
            tbName.TabIndex = 7;
            // 
            // Client_bai4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(tbName);
            Controls.Add(tbRespond);
            Controls.Add(btSend);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbSend);
            Name = "Client_bai4";
            Text = "Client_bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private TextBox textBox1;
        private TextBox tbSend;
        private Label label1;
        private Label label2;
        private Button btSend;
        private TextBox tbRespond;
        private TextBox tbName;
    }
}