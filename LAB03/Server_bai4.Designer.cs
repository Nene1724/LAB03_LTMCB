namespace LAB03
{
    partial class Server_bai4
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
            btStart = new Button();
            tbMessage = new TextBox();
            SuspendLayout();
            // 
            // btStart
            // 
            btStart.Location = new Point(644, 12);
            btStart.Name = "btStart";
            btStart.Size = new Size(134, 56);
            btStart.TabIndex = 0;
            btStart.Text = "LISTEN";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(12, 12);
            tbMessage.Multiline = true;
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(626, 412);
            tbMessage.TabIndex = 1;
            // 
            // Server_bai4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbMessage);
            Controls.Add(btStart);
            Name = "Server_bai4";
            Text = "Server_bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btStart;
        private TextBox tbMessage;
    }
}