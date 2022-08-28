namespace BMS
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.dataGridViewInv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBloodUnits = new System.Windows.Forms.Button();
            this.RemoveBloodUnits = new System.Windows.Forms.Button();
            this.txtSerial = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtBloodGroup = new System.Windows.Forms.ComboBox();
            this.txtBloodUnits = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInv
            // 
            this.dataGridViewInv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInv.Location = new System.Drawing.Point(630, 102);
            this.dataGridViewInv.Name = "dataGridViewInv";
            this.dataGridViewInv.Size = new System.Drawing.Size(500, 331);
            this.dataGridViewInv.TabIndex = 0;
            this.dataGridViewInv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(180, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blood Group";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(180, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Blood Units";
            // 
            // AddBloodUnits
            // 
            this.AddBloodUnits.BackColor = System.Drawing.Color.LightSalmon;
            this.AddBloodUnits.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.AddBloodUnits.Image = ((System.Drawing.Image)(resources.GetObject("AddBloodUnits.Image")));
            this.AddBloodUnits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBloodUnits.Location = new System.Drawing.Point(294, 198);
            this.AddBloodUnits.Name = "AddBloodUnits";
            this.AddBloodUnits.Size = new System.Drawing.Size(178, 38);
            this.AddBloodUnits.TabIndex = 5;
            this.AddBloodUnits.Text = "Add Blood Units";
            this.AddBloodUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBloodUnits.UseVisualStyleBackColor = false;
            this.AddBloodUnits.Click += new System.EventHandler(this.AddBloodUnits_Click);
            // 
            // RemoveBloodUnits
            // 
            this.RemoveBloodUnits.BackColor = System.Drawing.Color.LightSalmon;
            this.RemoveBloodUnits.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.RemoveBloodUnits.Image = ((System.Drawing.Image)(resources.GetObject("RemoveBloodUnits.Image")));
            this.RemoveBloodUnits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveBloodUnits.Location = new System.Drawing.Point(275, 242);
            this.RemoveBloodUnits.Name = "RemoveBloodUnits";
            this.RemoveBloodUnits.Size = new System.Drawing.Size(215, 43);
            this.RemoveBloodUnits.TabIndex = 6;
            this.RemoveBloodUnits.Text = "Remove Blood Units";
            this.RemoveBloodUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveBloodUnits.UseVisualStyleBackColor = false;
            this.RemoveBloodUnits.Click += new System.EventHandler(this.RemoveBloodUnits_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.AutoSize = true;
            this.txtSerial.Location = new System.Drawing.Point(98, 45);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(0, 13);
            this.txtSerial.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSalmon;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 33);
            this.label3.TabIndex = 61;
            this.label3.Text = "BLOOD INVENTORY";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1034, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 45);
            this.button2.TabIndex = 63;
            this.button2.Text = "Print";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBloodGroup.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.txtBloodGroup.FormattingEnabled = true;
            this.txtBloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.txtBloodGroup.Location = new System.Drawing.Point(285, 101);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(227, 27);
            this.txtBloodGroup.TabIndex = 64;
            // 
            // txtBloodUnits
            // 
            this.txtBloodUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBloodUnits.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.txtBloodUnits.FormattingEnabled = true;
            this.txtBloodUnits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.txtBloodUnits.Location = new System.Drawing.Point(285, 145);
            this.txtBloodUnits.Name = "txtBloodUnits";
            this.txtBloodUnits.Size = new System.Drawing.Size(227, 27);
            this.txtBloodUnits.TabIndex = 65;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1195, 445);
            this.Controls.Add(this.txtBloodUnits);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.RemoveBloodUnits);
            this.Controls.Add(this.AddBloodUnits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewInv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBloodUnits;
        private System.Windows.Forms.Button RemoveBloodUnits;
        private System.Windows.Forms.Label txtSerial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox txtBloodGroup;
        private System.Windows.Forms.ComboBox txtBloodUnits;
    }
}