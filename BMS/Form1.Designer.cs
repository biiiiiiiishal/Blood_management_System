namespace BMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtuname = new System.Windows.Forms.TextBox();
            this.lbluname = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnpassShow = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtuname
            // 
            this.txtuname.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.txtuname.ForeColor = System.Drawing.Color.Black;
            this.txtuname.Location = new System.Drawing.Point(783, 138);
            this.txtuname.Multiline = true;
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(228, 41);
            this.txtuname.TabIndex = 0;
            // 
            // lbluname
            // 
            this.lbluname.BackColor = System.Drawing.Color.Transparent;
            this.lbluname.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold);
            this.lbluname.Image = ((System.Drawing.Image)(resources.GetObject("lbluname.Image")));
            this.lbluname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbluname.Location = new System.Drawing.Point(627, 150);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(150, 29);
            this.lbluname.TabIndex = 1;
            this.lbluname.Text = "Username";
            this.lbluname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblpass
            // 
            this.lblpass.BackColor = System.Drawing.Color.Transparent;
            this.lblpass.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold);
            this.lblpass.Image = ((System.Drawing.Image)(resources.GetObject("lblpass.Image")));
            this.lblpass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblpass.Location = new System.Drawing.Point(627, 213);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(154, 27);
            this.lblpass.TabIndex = 2;
            this.lblpass.Text = "Password";
            this.lblpass.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.txtpass.Location = new System.Drawing.Point(787, 213);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(228, 41);
            this.txtpass.TabIndex = 3;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightSalmon;
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(834, 323);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(127, 43);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnpassShow
            // 
            this.btnpassShow.ActiveLinkColor = System.Drawing.Color.Red;
            this.btnpassShow.BackColor = System.Drawing.Color.Transparent;
            this.btnpassShow.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnpassShow.Image = ((System.Drawing.Image)(resources.GetObject("btnpassShow.Image")));
            this.btnpassShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpassShow.LinkColor = System.Drawing.Color.Black;
            this.btnpassShow.Location = new System.Drawing.Point(1021, 221);
            this.btnpassShow.Name = "btnpassShow";
            this.btnpassShow.Size = new System.Drawing.Size(78, 19);
            this.btnpassShow.TabIndex = 5;
            this.btnpassShow.TabStop = true;
            this.btnpassShow.Text = "Show";
            this.btnpassShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpassShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(645, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "BLOOD BANK MANAGEMENT SYSTEM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpassShow);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.txtuname);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Blood Bank Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel btnpassShow;
        private System.Windows.Forms.Label label1;
    }
}

