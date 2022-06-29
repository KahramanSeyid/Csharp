namespace MyProject
{
    partial class MyForm2
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
            this.components = new System.ComponentModel.Container();
            this.labelZaman = new System.Windows.Forms.Label();
            this.numericUpDownSaat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDakika = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSaniye = new System.Windows.Forms.NumericUpDown();
            this.buttonBASLA = new System.Windows.Forms.Button();
            this.buttonDur = new System.Windows.Forms.Button();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxSaat = new System.Windows.Forms.PictureBox();
            this.pictureBoxAkrep = new System.Windows.Forms.PictureBox();
            this.pictureBoxYelkovan = new System.Windows.Forms.PictureBox();
            this.pictureBoxSaniye = new System.Windows.Forms.PictureBox();
            this.timerZaman1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaniye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAkrep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYelkovan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaniye)).BeginInit();
            this.SuspendLayout();
            // 
            // labelZaman
            // 
            this.labelZaman.AutoSize = true;
            this.labelZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelZaman.Location = new System.Drawing.Point(632, 28);
            this.labelZaman.Name = "labelZaman";
            this.labelZaman.Size = new System.Drawing.Size(128, 31);
            this.labelZaman.TabIndex = 0;
            this.labelZaman.Text = "00:00:00";
            // 
            // numericUpDownSaat
            // 
            this.numericUpDownSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownSaat.Location = new System.Drawing.Point(608, 62);
            this.numericUpDownSaat.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownSaat.Name = "numericUpDownSaat";
            this.numericUpDownSaat.Size = new System.Drawing.Size(58, 31);
            this.numericUpDownSaat.TabIndex = 1;
            // 
            // numericUpDownDakika
            // 
            this.numericUpDownDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownDakika.Location = new System.Drawing.Point(684, 62);
            this.numericUpDownDakika.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownDakika.Name = "numericUpDownDakika";
            this.numericUpDownDakika.Size = new System.Drawing.Size(58, 31);
            this.numericUpDownDakika.TabIndex = 2;
            // 
            // numericUpDownSaniye
            // 
            this.numericUpDownSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownSaniye.Location = new System.Drawing.Point(757, 62);
            this.numericUpDownSaniye.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSaniye.Name = "numericUpDownSaniye";
            this.numericUpDownSaniye.Size = new System.Drawing.Size(58, 31);
            this.numericUpDownSaniye.TabIndex = 3;
            // 
            // buttonBASLA
            // 
            this.buttonBASLA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBASLA.Location = new System.Drawing.Point(608, 99);
            this.buttonBASLA.Name = "buttonBASLA";
            this.buttonBASLA.Size = new System.Drawing.Size(92, 35);
            this.buttonBASLA.TabIndex = 4;
            this.buttonBASLA.Text = "Başla";
            this.buttonBASLA.UseVisualStyleBackColor = true;
            this.buttonBASLA.Click += new System.EventHandler(this.buttonBASLA_Click);
            // 
            // buttonDur
            // 
            this.buttonDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDur.Location = new System.Drawing.Point(722, 99);
            this.buttonDur.Name = "buttonDur";
            this.buttonDur.Size = new System.Drawing.Size(93, 35);
            this.buttonDur.TabIndex = 5;
            this.buttonDur.Text = "Dur";
            this.buttonDur.UseVisualStyleBackColor = true;
            this.buttonDur.Click += new System.EventHandler(this.buttonDur_Click);
            // 
            // timerSaat
            // 
            this.timerSaat.Interval = 1000;
            this.timerSaat.Tick += new System.EventHandler(this.timerZaman_Tick);
            // 
            // pictureBoxSaat
            // 
            this.pictureBoxSaat.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSaat.Image = global::MyProject.Properties.Resources.kadran__1_;
            this.pictureBoxSaat.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSaat.Name = "pictureBoxSaat";
            this.pictureBoxSaat.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxSaat.TabIndex = 6;
            this.pictureBoxSaat.TabStop = false;
            // 
            // pictureBoxAkrep
            // 
            this.pictureBoxAkrep.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAkrep.Image = global::MyProject.Properties.Resources.akrep;
            this.pictureBoxAkrep.Location = new System.Drawing.Point(12, 211);
            this.pictureBoxAkrep.Name = "pictureBoxAkrep";
            this.pictureBoxAkrep.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxAkrep.TabIndex = 7;
            this.pictureBoxAkrep.TabStop = false;
            // 
            // pictureBoxYelkovan
            // 
            this.pictureBoxYelkovan.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxYelkovan.Image = global::MyProject.Properties.Resources.yelkovan;
            this.pictureBoxYelkovan.Location = new System.Drawing.Point(75, 247);
            this.pictureBoxYelkovan.Name = "pictureBoxYelkovan";
            this.pictureBoxYelkovan.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxYelkovan.TabIndex = 8;
            this.pictureBoxYelkovan.TabStop = false;
            // 
            // pictureBoxSaniye
            // 
            this.pictureBoxSaniye.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSaniye.Image = global::MyProject.Properties.Resources.saniye;
            this.pictureBoxSaniye.Location = new System.Drawing.Point(118, 292);
            this.pictureBoxSaniye.Name = "pictureBoxSaniye";
            this.pictureBoxSaniye.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxSaniye.TabIndex = 9;
            this.pictureBoxSaniye.TabStop = false;
            // 
            // timerZaman1
            // 
            this.timerZaman1.Enabled = true;
            this.timerZaman1.Interval = 1;
            this.timerZaman1.Tick += new System.EventHandler(this.timerZaman1_Tick);
            // 
            // MyForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 516);
            this.Controls.Add(this.pictureBoxSaniye);
            this.Controls.Add(this.pictureBoxYelkovan);
            this.Controls.Add(this.pictureBoxAkrep);
            this.Controls.Add(this.pictureBoxSaat);
            this.Controls.Add(this.buttonDur);
            this.Controls.Add(this.buttonBASLA);
            this.Controls.Add(this.numericUpDownSaniye);
            this.Controls.Add(this.numericUpDownDakika);
            this.Controls.Add(this.numericUpDownSaat);
            this.Controls.Add(this.labelZaman);
            this.Name = "MyForm2";
            this.Text = "MyForm2";
            this.Load += new System.EventHandler(this.MyForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaniye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAkrep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYelkovan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaniye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZaman;
        private System.Windows.Forms.NumericUpDown numericUpDownSaat;
        private System.Windows.Forms.NumericUpDown numericUpDownDakika;
        private System.Windows.Forms.NumericUpDown numericUpDownSaniye;
        private System.Windows.Forms.Button buttonBASLA;
        private System.Windows.Forms.Button buttonDur;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.PictureBox pictureBoxSaat;
        private System.Windows.Forms.PictureBox pictureBoxAkrep;
        private System.Windows.Forms.PictureBox pictureBoxYelkovan;
        private System.Windows.Forms.PictureBox pictureBoxSaniye;
        private System.Windows.Forms.Timer timerZaman1;
    }
}