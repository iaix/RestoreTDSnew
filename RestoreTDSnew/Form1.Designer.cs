namespace RestoreTDSnew
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonShrink = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.radioLab1 = new System.Windows.Forms.RadioButton();
            this.radioLab2 = new System.Windows.Forms.RadioButton();
            this.radioLab3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioSpik2 = new System.Windows.Forms.RadioButton();
            this.radioSpik4 = new System.Windows.Forms.RadioButton();
            this.radioSpik5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioSpik8 = new System.Windows.Forms.RadioButton();
            this.radioSpik7 = new System.Windows.Forms.RadioButton();
            this.radioSpik6 = new System.Windows.Forms.RadioButton();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(280, 412);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(108, 30);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonShrink
            // 
            this.buttonShrink.Location = new System.Drawing.Point(13, 13);
            this.buttonShrink.Name = "buttonShrink";
            this.buttonShrink.Size = new System.Drawing.Size(375, 30);
            this.buttonShrink.TabIndex = 1;
            this.buttonShrink.Text = "Zrób miejsce na SPIKu";
            this.buttonShrink.UseVisualStyleBackColor = true;
            this.buttonShrink.Click += new System.EventHandler(this.buttonShrink_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 412);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(224, 30);
            this.progressBar1.TabIndex = 2;
            // 
            // radioLab1
            // 
            this.radioLab1.AutoSize = true;
            this.radioLab1.Location = new System.Drawing.Point(9, 17);
            this.radioLab1.Name = "radioLab1";
            this.radioLab1.Size = new System.Drawing.Size(61, 21);
            this.radioLab1.TabIndex = 3;
            this.radioLab1.TabStop = true;
            this.radioLab1.Text = "Lab1";
            this.radioLab1.UseVisualStyleBackColor = true;
            this.radioLab1.CheckedChanged += new System.EventHandler(this.radioLab1_CheckedChanged);
            // 
            // radioLab2
            // 
            this.radioLab2.AutoSize = true;
            this.radioLab2.Location = new System.Drawing.Point(9, 45);
            this.radioLab2.Name = "radioLab2";
            this.radioLab2.Size = new System.Drawing.Size(61, 21);
            this.radioLab2.TabIndex = 4;
            this.radioLab2.TabStop = true;
            this.radioLab2.Text = "Lab2";
            this.radioLab2.UseVisualStyleBackColor = true;
            this.radioLab2.CheckedChanged += new System.EventHandler(this.radioLab2_CheckedChanged);
            // 
            // radioLab3
            // 
            this.radioLab3.AutoSize = true;
            this.radioLab3.Location = new System.Drawing.Point(9, 73);
            this.radioLab3.Name = "radioLab3";
            this.radioLab3.Size = new System.Drawing.Size(61, 21);
            this.radioLab3.TabIndex = 5;
            this.radioLab3.TabStop = true;
            this.radioLab3.Text = "Lab3";
            this.radioLab3.UseVisualStyleBackColor = true;
            this.radioLab3.CheckedChanged += new System.EventHandler(this.radioLab3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            // 
            // radioSpik2
            // 
            this.radioSpik2.AutoSize = true;
            this.radioSpik2.Location = new System.Drawing.Point(15, 21);
            this.radioSpik2.Name = "radioSpik2";
            this.radioSpik2.Size = new System.Drawing.Size(91, 21);
            this.radioSpik2.TabIndex = 8;
            this.radioSpik2.TabStop = true;
            this.radioSpik2.Text = "0002SPIK";
            this.radioSpik2.UseVisualStyleBackColor = true;
            this.radioSpik2.CheckedChanged += new System.EventHandler(this.radioSpik2_CheckedChanged);
            // 
            // radioSpik4
            // 
            this.radioSpik4.AutoSize = true;
            this.radioSpik4.Location = new System.Drawing.Point(15, 48);
            this.radioSpik4.Name = "radioSpik4";
            this.radioSpik4.Size = new System.Drawing.Size(91, 21);
            this.radioSpik4.TabIndex = 10;
            this.radioSpik4.TabStop = true;
            this.radioSpik4.Text = "0004SPIK";
            this.radioSpik4.UseVisualStyleBackColor = true;
            this.radioSpik4.CheckedChanged += new System.EventHandler(this.radioSpik4_CheckedChanged);
            // 
            // radioSpik5
            // 
            this.radioSpik5.AutoSize = true;
            this.radioSpik5.Checked = global::RestoreTDSnew.Properties.Settings.Default.test;
            this.radioSpik5.Location = new System.Drawing.Point(14, 75);
            this.radioSpik5.Name = "radioSpik5";
            this.radioSpik5.Size = new System.Drawing.Size(91, 21);
            this.radioSpik5.TabIndex = 12;
            this.radioSpik5.TabStop = true;
            this.radioSpik5.Text = "0005SPIK";
            this.radioSpik5.UseVisualStyleBackColor = true;
            this.radioSpik5.CheckedChanged += new System.EventHandler(this.radioSpik5_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioLab3);
            this.groupBox1.Controls.Add(this.radioLab1);
            this.groupBox1.Controls.Add(this.radioLab2);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz Lab";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioSpik8);
            this.groupBox2.Controls.Add(this.radioSpik7);
            this.groupBox2.Controls.Add(this.radioSpik6);
            this.groupBox2.Controls.Add(this.radioSpik2);
            this.groupBox2.Controls.Add(this.radioSpik5);
            this.groupBox2.Controls.Add(this.radioSpik4);
            this.groupBox2.Location = new System.Drawing.Point(13, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 189);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wybierz serwer";
            // 
            // radioSpik8
            // 
            this.radioSpik8.AutoSize = true;
            this.radioSpik8.Checked = global::RestoreTDSnew.Properties.Settings.Default.test;
            this.radioSpik8.Location = new System.Drawing.Point(14, 157);
            this.radioSpik8.Name = "radioSpik8";
            this.radioSpik8.Size = new System.Drawing.Size(91, 21);
            this.radioSpik8.TabIndex = 18;
            this.radioSpik8.TabStop = true;
            this.radioSpik8.Text = "0008SPIK";
            this.radioSpik8.UseVisualStyleBackColor = true;
            this.radioSpik8.CheckedChanged += new System.EventHandler(this.radioSpik8_CheckedChanged);
            // 
            // radioSpik7
            // 
            this.radioSpik7.AutoSize = true;
            this.radioSpik7.Checked = global::RestoreTDSnew.Properties.Settings.Default.test;
            this.radioSpik7.Location = new System.Drawing.Point(14, 129);
            this.radioSpik7.Name = "radioSpik7";
            this.radioSpik7.Size = new System.Drawing.Size(91, 21);
            this.radioSpik7.TabIndex = 16;
            this.radioSpik7.TabStop = true;
            this.radioSpik7.Text = "0007SPIK";
            this.radioSpik7.UseVisualStyleBackColor = true;
            this.radioSpik7.CheckedChanged += new System.EventHandler(this.radioSpik7_CheckedChanged);
            // 
            // radioSpik6
            // 
            this.radioSpik6.AutoSize = true;
            this.radioSpik6.Location = new System.Drawing.Point(15, 102);
            this.radioSpik6.Name = "radioSpik6";
            this.radioSpik6.Size = new System.Drawing.Size(91, 21);
            this.radioSpik6.TabIndex = 14;
            this.radioSpik6.TabStop = true;
            this.radioSpik6.Text = "0006SPIK";
            this.radioSpik6.UseVisualStyleBackColor = true;
            this.radioSpik6.CheckedChanged += new System.EventHandler(this.radioSpik6_CheckedChanged);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(193, 325);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(195, 30);
            this.buttonRestore.TabIndex = 15;
            this.buttonRestore.Text = "Odśwież wybraną bazę";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pojazd",
            "Kierowca",
            "CepikDictionaties"});
            this.comboBox1.Location = new System.Drawing.Point(215, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 24);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(193, 366);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(195, 32);
            this.buttonConfirm.TabIndex = 21;
            this.buttonConfirm.Text = "Potwierdź";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 453);
            this.ControlBox = false;
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonShrink);
            this.Controls.Add(this.buttonClose);
            this.MinimumSize = new System.Drawing.Size(420, 500);
            this.Name = "Form1";
            this.Text = "Restore TDS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonShrink;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton radioLab1;
        private System.Windows.Forms.RadioButton radioLab2;
        private System.Windows.Forms.RadioButton radioLab3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioSpik2;
        private System.Windows.Forms.RadioButton radioSpik4;
        private System.Windows.Forms.RadioButton radioSpik5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.RadioButton radioSpik7;
        private System.Windows.Forms.RadioButton radioSpik6;
        private System.Windows.Forms.RadioButton radioSpik8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConfirm;
    }
}

