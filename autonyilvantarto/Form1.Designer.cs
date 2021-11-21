
namespace autonyilvantarto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_rendszam = new System.Windows.Forms.TextBox();
            this.textBox_Gyartmany = new System.Windows.Forms.TextBox();
            this.textBox_Tipus = new System.Windows.Forms.TextBox();
            this.Datum = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Szin = new System.Windows.Forms.ComboBox();
            this.groupBox_erv = new System.Windows.Forms.GroupBox();
            this.radioButton_nem = new System.Windows.Forms.RadioButton();
            this.radioButton_igen = new System.Windows.Forms.RadioButton();
            this.button = new System.Windows.Forms.Button();
            this.kiir = new System.Windows.Forms.Label();
            this.ho = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Datum)).BeginInit();
            this.groupBox_erv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autó nyilvántartás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Irja be a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gyártmányt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipusát";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Üzembehelyezés dátumát";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "színét";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "érvényes-e a műszakija";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Rendszámot";
            // 
            // textBox_rendszam
            // 
            this.textBox_rendszam.Location = new System.Drawing.Point(211, 54);
            this.textBox_rendszam.Name = "textBox_rendszam";
            this.textBox_rendszam.Size = new System.Drawing.Size(100, 20);
            this.textBox_rendszam.TabIndex = 8;
            // 
            // textBox_Gyartmany
            // 
            this.textBox_Gyartmany.Location = new System.Drawing.Point(211, 76);
            this.textBox_Gyartmany.Name = "textBox_Gyartmany";
            this.textBox_Gyartmany.Size = new System.Drawing.Size(100, 20);
            this.textBox_Gyartmany.TabIndex = 9;
            // 
            // textBox_Tipus
            // 
            this.textBox_Tipus.Location = new System.Drawing.Point(211, 98);
            this.textBox_Tipus.Name = "textBox_Tipus";
            this.textBox_Tipus.Size = new System.Drawing.Size(100, 20);
            this.textBox_Tipus.TabIndex = 10;
            // 
            // Datum
            // 
            this.Datum.Location = new System.Drawing.Point(211, 121);
            this.Datum.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.Datum.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(51, 20);
            this.Datum.TabIndex = 11;
            this.Datum.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // comboBox_Szin
            // 
            this.comboBox_Szin.FormattingEnabled = true;
            this.comboBox_Szin.Items.AddRange(new object[] {
            "Fekete",
            "Ezüst",
            "Piros",
            "Zöld",
            "egyéb"});
            this.comboBox_Szin.Location = new System.Drawing.Point(211, 145);
            this.comboBox_Szin.Name = "comboBox_Szin";
            this.comboBox_Szin.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Szin.TabIndex = 12;
            // 
            // groupBox_erv
            // 
            this.groupBox_erv.Controls.Add(this.radioButton_nem);
            this.groupBox_erv.Controls.Add(this.radioButton_igen);
            this.groupBox_erv.Location = new System.Drawing.Point(187, 172);
            this.groupBox_erv.Name = "groupBox_erv";
            this.groupBox_erv.Size = new System.Drawing.Size(150, 34);
            this.groupBox_erv.TabIndex = 13;
            this.groupBox_erv.TabStop = false;
            // 
            // radioButton_nem
            // 
            this.radioButton_nem.AutoSize = true;
            this.radioButton_nem.Location = new System.Drawing.Point(76, 11);
            this.radioButton_nem.Name = "radioButton_nem";
            this.radioButton_nem.Size = new System.Drawing.Size(45, 17);
            this.radioButton_nem.TabIndex = 1;
            this.radioButton_nem.TabStop = true;
            this.radioButton_nem.Text = "nem";
            this.radioButton_nem.UseVisualStyleBackColor = true;
            // 
            // radioButton_igen
            // 
            this.radioButton_igen.AutoSize = true;
            this.radioButton_igen.Location = new System.Drawing.Point(24, 11);
            this.radioButton_igen.Name = "radioButton_igen";
            this.radioButton_igen.Size = new System.Drawing.Size(45, 17);
            this.radioButton_igen.TabIndex = 0;
            this.radioButton_igen.TabStop = true;
            this.radioButton_igen.Text = "igen";
            this.radioButton_igen.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(135, 222);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(108, 29);
            this.button.TabIndex = 14;
            this.button.Text = "Mentés";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // kiir
            // 
            this.kiir.AutoSize = true;
            this.kiir.Location = new System.Drawing.Point(67, 264);
            this.kiir.Name = "kiir";
            this.kiir.Size = new System.Drawing.Size(0, 13);
            this.kiir.TabIndex = 15;
            // 
            // ho
            // 
            this.ho.Location = new System.Drawing.Point(263, 121);
            this.ho.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.ho.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ho.Name = "ho";
            this.ho.Size = new System.Drawing.Size(48, 20);
            this.ho.TabIndex = 16;
            this.ho.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Hó";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 349);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ho);
            this.Controls.Add(this.kiir);
            this.Controls.Add(this.button);
            this.Controls.Add(this.groupBox_erv);
            this.Controls.Add(this.comboBox_Szin);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.textBox_Tipus);
            this.Controls.Add(this.textBox_Gyartmany);
            this.Controls.Add(this.textBox_rendszam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Autó nyilvántartás";
            ((System.ComponentModel.ISupportInitialize)(this.Datum)).EndInit();
            this.groupBox_erv.ResumeLayout(false);
            this.groupBox_erv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_rendszam;
        private System.Windows.Forms.TextBox textBox_Gyartmany;
        private System.Windows.Forms.TextBox textBox_Tipus;
        private System.Windows.Forms.NumericUpDown Datum;
        private System.Windows.Forms.ComboBox comboBox_Szin;
        private System.Windows.Forms.GroupBox groupBox_erv;
        private System.Windows.Forms.RadioButton radioButton_nem;
        private System.Windows.Forms.RadioButton radioButton_igen;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label kiir;
        private System.Windows.Forms.NumericUpDown ho;
        private System.Windows.Forms.Label label9;
    }
}

