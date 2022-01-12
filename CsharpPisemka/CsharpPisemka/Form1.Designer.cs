namespace CsharpPisemka
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.prevod = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.RadioButton();
            this.minus = new System.Windows.Forms.RadioButton();
            this.krat = new System.Windows.Forms.RadioButton();
            this.deleno = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.smazat = new System.Windows.Forms.Button();
            this.kalkulacka = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.mocnina = new System.Windows.Forms.RadioButton();
            this.odmocnina = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.prevod2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.faktorial = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 15;
            // 
            // prevod
            // 
            this.prevod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prevod.Location = new System.Drawing.Point(231, 77);
            this.prevod.Name = "prevod";
            this.prevod.Size = new System.Drawing.Size(75, 33);
            this.prevod.TabIndex = 17;
            this.prevod.Text = "Převod";
            this.prevod.UseVisualStyleBackColor = true;
            this.prevod.Click += new System.EventHandler(this.prevod_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(335, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 18;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(18, 142);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(31, 17);
            this.plus.TabIndex = 19;
            this.plus.TabStop = true;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.CheckedChanged += new System.EventHandler(this.plus_CheckedChanged);
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Location = new System.Drawing.Point(121, 142);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(28, 17);
            this.minus.TabIndex = 20;
            this.minus.TabStop = true;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.CheckedChanged += new System.EventHandler(this.minus_CheckedChanged);
            // 
            // krat
            // 
            this.krat.AutoSize = true;
            this.krat.Location = new System.Drawing.Point(18, 165);
            this.krat.Name = "krat";
            this.krat.Size = new System.Drawing.Size(30, 17);
            this.krat.TabIndex = 21;
            this.krat.TabStop = true;
            this.krat.Text = "x";
            this.krat.UseVisualStyleBackColor = true;
            this.krat.CheckedChanged += new System.EventHandler(this.krat_CheckedChanged);
            // 
            // deleno
            // 
            this.deleno.AutoSize = true;
            this.deleno.Location = new System.Drawing.Point(121, 165);
            this.deleno.Name = "deleno";
            this.deleno.Size = new System.Drawing.Size(30, 17);
            this.deleno.TabIndex = 22;
            this.deleno.TabStop = true;
            this.deleno.Text = "/";
            this.deleno.UseVisualStyleBackColor = true;
            this.deleno.CheckedChanged += new System.EventHandler(this.deleno_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "?";
            // 
            // smazat
            // 
            this.smazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.smazat.Location = new System.Drawing.Point(231, 124);
            this.smazat.Name = "smazat";
            this.smazat.Size = new System.Drawing.Size(75, 35);
            this.smazat.TabIndex = 24;
            this.smazat.Text = "Smazat vše";
            this.smazat.UseVisualStyleBackColor = true;
            this.smazat.Click += new System.EventHandler(this.smazat_Click);
            // 
            // kalkulacka
            // 
            this.kalkulacka.AutoSize = true;
            this.kalkulacka.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kalkulacka.Location = new System.Drawing.Point(120, 11);
            this.kalkulacka.Name = "kalkulacka";
            this.kalkulacka.Size = new System.Drawing.Size(174, 39);
            this.kalkulacka.TabIndex = 25;
            this.kalkulacka.Text = "Kalkulačka";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.kalkulacka);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 57);
            this.panel1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Zadej 1.Cislo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Zadej 2.Číslo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Výsledek";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(18, 272);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 30;
            // 
            // mocnina
            // 
            this.mocnina.AutoSize = true;
            this.mocnina.Location = new System.Drawing.Point(3, 21);
            this.mocnina.Name = "mocnina";
            this.mocnina.Size = new System.Drawing.Size(89, 17);
            this.mocnina.TabIndex = 31;
            this.mocnina.TabStop = true;
            this.mocnina.Text = "mocnina na 2";
            this.mocnina.UseVisualStyleBackColor = true;
            // 
            // odmocnina
            // 
            this.odmocnina.AutoSize = true;
            this.odmocnina.Location = new System.Drawing.Point(3, 44);
            this.odmocnina.Name = "odmocnina";
            this.odmocnina.Size = new System.Drawing.Size(77, 17);
            this.odmocnina.TabIndex = 32;
            this.odmocnina.TabStop = true;
            this.odmocnina.Text = "odmocnina";
            this.odmocnina.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Výsledek";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(335, 272);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(75, 20);
            this.textBox5.TabIndex = 33;
            // 
            // prevod2
            // 
            this.prevod2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prevod2.Location = new System.Drawing.Point(231, 263);
            this.prevod2.Name = "prevod2";
            this.prevod2.Size = new System.Drawing.Size(75, 33);
            this.prevod2.TabIndex = 35;
            this.prevod2.Text = "Převod";
            this.prevod2.UseVisualStyleBackColor = true;
            this.prevod2.Click += new System.EventHandler(this.prevod2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Zadej Číslo";
            // 
            // faktorial
            // 
            this.faktorial.AutoSize = true;
            this.faktorial.Location = new System.Drawing.Point(3, 67);
            this.faktorial.Name = "faktorial";
            this.faktorial.Size = new System.Drawing.Size(62, 17);
            this.faktorial.TabIndex = 37;
            this.faktorial.TabStop = true;
            this.faktorial.Text = "faktorial";
            this.faktorial.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mocnina);
            this.panel2.Controls.Add(this.faktorial);
            this.panel2.Controls.Add(this.odmocnina);
            this.panel2.Location = new System.Drawing.Point(105, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 100);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(-7, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 18);
            this.panel3.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(429, 357);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prevod2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.smazat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleno);
            this.Controls.Add(this.krat);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.prevod);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button prevod;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton plus;
        private System.Windows.Forms.RadioButton minus;
        private System.Windows.Forms.RadioButton krat;
        private System.Windows.Forms.RadioButton deleno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button smazat;
        private System.Windows.Forms.Label kalkulacka;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton mocnina;
        private System.Windows.Forms.RadioButton odmocnina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button prevod2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton faktorial;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

