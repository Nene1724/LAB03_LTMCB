using System.Text;

namespace LAB03
{
    partial class bai2
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_04_19_171738;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(749, 452);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(428, 12);
            button1.Name = "button1";
            button1.Size = new Size(209, 71);
            button1.TabIndex = 1;
            button1.Text = "LISTEN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.BorderStyle = BorderStyle.None;
            listView1.Location = new Point(107, 114);
            listView1.Name = "listView1";
            listView1.Size = new Size(421, 301);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 450);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "bai2";
            Text = "bai2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private ListView listView1;
    }
}