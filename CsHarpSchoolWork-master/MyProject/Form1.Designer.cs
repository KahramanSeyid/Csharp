namespace MyProject
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
            this.components = new System.ComponentModel.Container();
            this.labelKronomotre = new System.Windows.Forms.Label();
            this.timerZaman = new System.Windows.Forms.Timer(this.components);
            this.buttonBasla = new System.Windows.Forms.Button();
            this.buttonBekle = new System.Windows.Forms.Button();
            this.buttonTekrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKronomotre
            // 
            this.labelKronomotre.AutoSize = true;
            this.labelKronomotre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKronomotre.Location = new System.Drawing.Point(12, 366);
            this.labelKronomotre.Name = "labelKronomotre";
            this.labelKronomotre.Size = new System.Drawing.Size(266, 37);
            this.labelKronomotre.TabIndex = 0;
            this.labelKronomotre.Text = "00:00:00:00:000";
            // 
            // timerZaman
            // 
            this.timerZaman.Enabled = true;
            this.timerZaman.Interval = 1;
            this.timerZaman.Tick += new System.EventHandler(this.timerZaman_Tick);
            // 
            // buttonBasla
            // 
            this.buttonBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBasla.Location = new System.Drawing.Point(2, 406);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(125, 40);
            this.buttonBasla.TabIndex = 1;
            this.buttonBasla.Text = "Başla";
            this.buttonBasla.UseVisualStyleBackColor = true;
            this.buttonBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // buttonBekle
            // 
            this.buttonBekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBekle.Location = new System.Drawing.Point(133, 406);
            this.buttonBekle.Name = "buttonBekle";
            this.buttonBekle.Size = new System.Drawing.Size(98, 40);
            this.buttonBekle.TabIndex = 2;
            this.buttonBekle.Text = "Bekle";
            this.buttonBekle.UseVisualStyleBackColor = true;
            this.buttonBekle.Click += new System.EventHandler(this.buttonBekle_Click);
            // 
            // buttonTekrar
            // 
            this.buttonTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTekrar.Location = new System.Drawing.Point(237, 406);
            this.buttonTekrar.Name = "buttonTekrar";
            this.buttonTekrar.Size = new System.Drawing.Size(113, 40);
            this.buttonTekrar.TabIndex = 3;
            this.buttonTekrar.Text = "Tekrar";
            this.buttonTekrar.UseVisualStyleBackColor = true;
            this.buttonTekrar.Click += new System.EventHandler(this.buttonTekrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 458);
            this.Controls.Add(this.buttonTekrar);
            this.Controls.Add(this.buttonBekle);
            this.Controls.Add(this.buttonBasla);
            this.Controls.Add(this.labelKronomotre);
            this.Name = "Form1";
            this.Text = "Başla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKronomotre;
        private System.Windows.Forms.Timer timerZaman;
        private System.Windows.Forms.Button buttonBasla;
        private System.Windows.Forms.Button buttonBekle;
        private System.Windows.Forms.Button buttonTekrar;
    }
}

