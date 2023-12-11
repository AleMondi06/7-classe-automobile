namespace _7_classe_automobile
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Accensione = new System.Windows.Forms.Button();
            this.Spegnimento = new System.Windows.Forms.Button();
            this.Accelleratore = new System.Windows.Forms.Button();
            this.Freno = new System.Windows.Forms.Button();
            this.Aumentare = new System.Windows.Forms.Button();
            this.Diminuire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Accensione
            // 
            this.Accensione.Location = new System.Drawing.Point(71, 62);
            this.Accensione.Name = "Accensione";
            this.Accensione.Size = new System.Drawing.Size(112, 75);
            this.Accensione.TabIndex = 0;
            this.Accensione.Text = "ON";
            this.Accensione.UseVisualStyleBackColor = true;
            this.Accensione.Click += new System.EventHandler(this.Accensione_Click);
            // 
            // Spegnimento
            // 
            this.Spegnimento.Location = new System.Drawing.Point(71, 143);
            this.Spegnimento.Name = "Spegnimento";
            this.Spegnimento.Size = new System.Drawing.Size(112, 75);
            this.Spegnimento.TabIndex = 1;
            this.Spegnimento.Text = "OFF";
            this.Spegnimento.UseVisualStyleBackColor = true;
            this.Spegnimento.Click += new System.EventHandler(this.Spegnimento_Click);
            // 
            // Accelleratore
            // 
            this.Accelleratore.Location = new System.Drawing.Point(216, 62);
            this.Accelleratore.Name = "Accelleratore";
            this.Accelleratore.Size = new System.Drawing.Size(112, 75);
            this.Accelleratore.TabIndex = 2;
            this.Accelleratore.Text = "THROTTLE";
            this.Accelleratore.UseVisualStyleBackColor = true;
            this.Accelleratore.Click += new System.EventHandler(this.Accelleratore_Click);
            // 
            // Freno
            // 
            this.Freno.Location = new System.Drawing.Point(216, 143);
            this.Freno.Name = "Freno";
            this.Freno.Size = new System.Drawing.Size(112, 75);
            this.Freno.TabIndex = 3;
            this.Freno.Text = "BRAKE";
            this.Freno.UseVisualStyleBackColor = true;
            this.Freno.Click += new System.EventHandler(this.Freno_Click);
            // 
            // Aumentare
            // 
            this.Aumentare.Location = new System.Drawing.Point(366, 62);
            this.Aumentare.Name = "Aumentare";
            this.Aumentare.Size = new System.Drawing.Size(112, 75);
            this.Aumentare.TabIndex = 4;
            this.Aumentare.Text = "UP";
            this.Aumentare.UseVisualStyleBackColor = true;
            this.Aumentare.Click += new System.EventHandler(this.Aumentare_Click);
            // 
            // Diminuire
            // 
            this.Diminuire.Location = new System.Drawing.Point(366, 143);
            this.Diminuire.Name = "Diminuire";
            this.Diminuire.Size = new System.Drawing.Size(112, 75);
            this.Diminuire.TabIndex = 5;
            this.Diminuire.Text = "DOWN";
            this.Diminuire.UseVisualStyleBackColor = true;
            this.Diminuire.Click += new System.EventHandler(this.Diminuire_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Diminuire);
            this.Controls.Add(this.Aumentare);
            this.Controls.Add(this.Freno);
            this.Controls.Add(this.Accelleratore);
            this.Controls.Add(this.Spegnimento);
            this.Controls.Add(this.Accensione);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Accensione;
        private System.Windows.Forms.Button Spegnimento;
        private System.Windows.Forms.Button Accelleratore;
        private System.Windows.Forms.Button Freno;
        private System.Windows.Forms.Button Aumentare;
        private System.Windows.Forms.Button Diminuire;
    }
}

