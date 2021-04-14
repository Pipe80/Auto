namespace Autokauppa.view
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaTietokantayhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Hintatextbox = new System.Windows.Forms.TextBox();
            this.TilavuusTextBox = new System.Windows.Forms.TextBox();
            this.MalliTextBox = new System.Windows.Forms.TextBox();
            this.MalliBox = new System.Windows.Forms.ComboBox();
            this.MerkkiBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tallennabtn = new System.Windows.Forms.Button();
            this.Poistabtn = new System.Windows.Forms.Button();
            this.Edellinenbtn = new System.Windows.Forms.Button();
            this.Seuraavabtn = new System.Windows.Forms.Button();
            this.BensaBox = new System.Windows.Forms.ComboBox();
            this.VariTextBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TallennaComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(833, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantayhteyttäToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            this.testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            this.testaaTietokantayhteyttäToolStripMenuItem.Size = new System.Drawing.Size(310, 34);
            this.testaaTietokantayhteyttäToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            this.testaaTietokantayhteyttäToolStripMenuItem.Click += new System.EventHandler(this.TestaaTietokantayhteytta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Automerkki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Malli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mittarilukema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Moottorin tilavuus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 415);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hinta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(337, 446);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(429, 30);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 415);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rekisteröintipäivämäärä";
            // 
            // Hintatextbox
            // 
            this.Hintatextbox.Location = new System.Drawing.Point(32, 446);
            this.Hintatextbox.Margin = new System.Windows.Forms.Padding(6);
            this.Hintatextbox.Name = "Hintatextbox";
            this.Hintatextbox.Size = new System.Drawing.Size(258, 30);
            this.Hintatextbox.TabIndex = 8;
            // 
            // TilavuusTextBox
            // 
            this.TilavuusTextBox.Location = new System.Drawing.Point(32, 370);
            this.TilavuusTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.TilavuusTextBox.Name = "TilavuusTextBox";
            this.TilavuusTextBox.Size = new System.Drawing.Size(258, 30);
            this.TilavuusTextBox.TabIndex = 9;
            // 
            // MalliTextBox
            // 
            this.MalliTextBox.Location = new System.Drawing.Point(31, 278);
            this.MalliTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.MalliTextBox.Name = "MalliTextBox";
            this.MalliTextBox.Size = new System.Drawing.Size(258, 30);
            this.MalliTextBox.TabIndex = 10;
            // 
            // MalliBox
            // 
            this.MalliBox.FormattingEnabled = true;
            this.MalliBox.Location = new System.Drawing.Point(32, 192);
            this.MalliBox.Margin = new System.Windows.Forms.Padding(6);
            this.MalliBox.Name = "MalliBox";
            this.MalliBox.Size = new System.Drawing.Size(258, 33);
            this.MalliBox.TabIndex = 11;
            // 
            // MerkkiBox
            // 
            this.MerkkiBox.FormattingEnabled = true;
            this.MerkkiBox.Location = new System.Drawing.Point(32, 108);
            this.MerkkiBox.Margin = new System.Windows.Forms.Padding(6);
            this.MerkkiBox.Name = "MerkkiBox";
            this.MerkkiBox.Size = new System.Drawing.Size(258, 33);
            this.MerkkiBox.TabIndex = 12;
            this.MerkkiBox.SelectedIndexChanged += new System.EventHandler(this.ComboAutonmerkki_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(606, 98);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Uusi tietue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tallennabtn
            // 
            this.Tallennabtn.BackColor = System.Drawing.Color.Lime;
            this.Tallennabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tallennabtn.Location = new System.Drawing.Point(606, 161);
            this.Tallennabtn.Margin = new System.Windows.Forms.Padding(6);
            this.Tallennabtn.Name = "Tallennabtn";
            this.Tallennabtn.Size = new System.Drawing.Size(149, 37);
            this.Tallennabtn.TabIndex = 14;
            this.Tallennabtn.Text = "Tallenna";
            this.Tallennabtn.UseVisualStyleBackColor = false;
            this.Tallennabtn.Click += new System.EventHandler(this.Tallennabtn_Click);
            // 
            // Poistabtn
            // 
            this.Poistabtn.BackColor = System.Drawing.Color.Red;
            this.Poistabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poistabtn.Location = new System.Drawing.Point(606, 210);
            this.Poistabtn.Margin = new System.Windows.Forms.Padding(6);
            this.Poistabtn.Name = "Poistabtn";
            this.Poistabtn.Size = new System.Drawing.Size(149, 47);
            this.Poistabtn.TabIndex = 15;
            this.Poistabtn.Text = "Poista";
            this.Poistabtn.UseVisualStyleBackColor = false;
            // 
            // Edellinenbtn
            // 
            this.Edellinenbtn.BackColor = System.Drawing.Color.Lime;
            this.Edellinenbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edellinenbtn.Location = new System.Drawing.Point(606, 269);
            this.Edellinenbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Edellinenbtn.Name = "Edellinenbtn";
            this.Edellinenbtn.Size = new System.Drawing.Size(149, 43);
            this.Edellinenbtn.TabIndex = 17;
            this.Edellinenbtn.Text = "Edellinen";
            this.Edellinenbtn.UseVisualStyleBackColor = false;
            // 
            // Seuraavabtn
            // 
            this.Seuraavabtn.BackColor = System.Drawing.Color.Lime;
            this.Seuraavabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seuraavabtn.Location = new System.Drawing.Point(606, 324);
            this.Seuraavabtn.Margin = new System.Windows.Forms.Padding(6);
            this.Seuraavabtn.Name = "Seuraavabtn";
            this.Seuraavabtn.Size = new System.Drawing.Size(149, 42);
            this.Seuraavabtn.TabIndex = 18;
            this.Seuraavabtn.Text = "Seuraava";
            this.Seuraavabtn.UseVisualStyleBackColor = false;
            // 
            // BensaBox
            // 
            this.BensaBox.FormattingEnabled = true;
            this.BensaBox.Location = new System.Drawing.Point(378, 108);
            this.BensaBox.Name = "BensaBox";
            this.BensaBox.Size = new System.Drawing.Size(121, 33);
            this.BensaBox.TabIndex = 19;
            // 
            // VariTextBox
            // 
            this.VariTextBox.FormattingEnabled = true;
            this.VariTextBox.Location = new System.Drawing.Point(378, 192);
            this.VariTextBox.Name = "VariTextBox";
            this.VariTextBox.Size = new System.Drawing.Size(121, 33);
            this.VariTextBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Polttoaine";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Väri";
            // 
            // TallennaComboBox
            // 
            this.TallennaComboBox.FormattingEnabled = true;
            this.TallennaComboBox.Location = new System.Drawing.Point(378, 291);
            this.TallennaComboBox.Name = "TallennaComboBox";
            this.TallennaComboBox.Size = new System.Drawing.Size(121, 33);
            this.TallennaComboBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Tallennetut autot";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(833, 526);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TallennaComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VariTextBox);
            this.Controls.Add(this.BensaBox);
            this.Controls.Add(this.Seuraavabtn);
            this.Controls.Add(this.Edellinenbtn);
            this.Controls.Add(this.Poistabtn);
            this.Controls.Add(this.Tallennabtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MerkkiBox);
            this.Controls.Add(this.MalliBox);
            this.Controls.Add(this.MalliTextBox);
            this.Controls.Add(this.TilavuusTextBox);
            this.Controls.Add(this.Hintatextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Hintatextbox;
        private System.Windows.Forms.TextBox TilavuusTextBox;
        private System.Windows.Forms.TextBox MalliTextBox;
        private System.Windows.Forms.ComboBox MalliBox;
        private System.Windows.Forms.ComboBox MerkkiBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Tallennabtn;
        private System.Windows.Forms.Button Poistabtn;
        private System.Windows.Forms.Button Edellinenbtn;
        private System.Windows.Forms.Button Seuraavabtn;
        private System.Windows.Forms.ComboBox BensaBox;
        private System.Windows.Forms.ComboBox VariTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox TallennaComboBox;
        private System.Windows.Forms.Label label9;
    }
}