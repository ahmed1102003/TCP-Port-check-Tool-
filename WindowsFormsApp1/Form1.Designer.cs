namespace WindowsFormsApp1
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtipaddress = new System.Windows.Forms.TextBox();
            this.txtportnumber = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txthostname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtipaddress
            // 
            this.txtipaddress.Location = new System.Drawing.Point(132, 103);
            this.txtipaddress.Name = "txtipaddress";
            this.txtipaddress.Size = new System.Drawing.Size(312, 26);
            this.txtipaddress.TabIndex = 0;
            this.txtipaddress.TextChanged += new System.EventHandler(this.txtipaddress_TextChanged);
            // 
            // txtportnumber
            // 
            this.txtportnumber.Location = new System.Drawing.Point(132, 228);
            this.txtportnumber.Name = "txtportnumber";
            this.txtportnumber.Size = new System.Drawing.Size(312, 26);
            this.txtportnumber.TabIndex = 1;
            this.txtportnumber.TextChanged += new System.EventHandler(this.txtportnumber_TextChanged);
            this.txtportnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtportnumber_KeyPress);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(117, 336);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(137, 110);
            this.Send.TabIndex = 2;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 97);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Host Name";
            // 
            // txthostname
            // 
            this.txthostname.Location = new System.Drawing.Point(132, 169);
            this.txthostname.Name = "txthostname";
            this.txthostname.Size = new System.Drawing.Size(312, 26);
            this.txthostname.TabIndex = 7;
            this.txthostname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthostname_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 482);
            this.Controls.Add(this.txthostname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.txtportnumber);
            this.Controls.Add(this.txtipaddress);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TCP Port check Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtipaddress;
        private System.Windows.Forms.TextBox txtportnumber;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthostname;
    }
}

