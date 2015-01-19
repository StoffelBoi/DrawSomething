namespace DrawSomething
{
    partial class Test
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
            this.txtOut = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.isServer = new System.Windows.Forms.CheckBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(12, 30);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(266, 202);
            this.txtOut.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(12, 4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(67, 20);
            this.txtIP.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(85, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(39, 20);
            this.txtPort.TabIndex = 3;
            // 
            // isServer
            // 
            this.isServer.AutoSize = true;
            this.isServer.Location = new System.Drawing.Point(211, 6);
            this.isServer.Name = "isServer";
            this.isServer.Size = new System.Drawing.Size(57, 17);
            this.isServer.TabIndex = 4;
            this.isServer.Text = "Server";
            this.isServer.UseVisualStyleBackColor = true;
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(12, 238);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(153, 20);
            this.txtIn.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 264);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.isServer);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOut);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.CheckBox isServer;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Button button2;
    }
}