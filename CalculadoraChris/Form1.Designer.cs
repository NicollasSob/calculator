namespace CalculadoraChris
{
    partial class FrmCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculator));
            this.lblTextResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.rest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextResult
            // 
            this.lblTextResult.AutoSize = true;
            this.lblTextResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextResult.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTextResult.Location = new System.Drawing.Point(8, 14);
            this.lblTextResult.Name = "lblTextResult";
            this.lblTextResult.Size = new System.Drawing.Size(137, 20);
            this.lblTextResult.TabIndex = 0;
            this.lblTextResult.Text = "Nossa Calculadora";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(8, 47);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(258, 29);
            this.txtResult.TabIndex = 1;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.SeaGreen;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnC.Location = new System.Drawing.Point(8, 91);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(60, 46);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPonto.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPonto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPonto.Location = new System.Drawing.Point(140, 302);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(60, 46);
            this.btnPonto.TabIndex = 3;
            this.btnPonto.Text = ".";
            this.btnPonto.UseVisualStyleBackColor = false;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMenos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenos.Location = new System.Drawing.Point(206, 198);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(60, 46);
            this.btnMenos.TabIndex = 4;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDividir.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDividir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDividir.Location = new System.Drawing.Point(206, 91);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(60, 46);
            this.btnDividir.TabIndex = 5;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnVezes
            // 
            this.btnVezes.BackColor = System.Drawing.Color.SeaGreen;
            this.btnVezes.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVezes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVezes.Location = new System.Drawing.Point(206, 143);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(60, 46);
            this.btnVezes.TabIndex = 6;
            this.btnVezes.Text = "*";
            this.btnVezes.UseVisualStyleBackColor = false;
            this.btnVezes.Click += new System.EventHandler(this.btnVezes_Click);
            // 
            // btnDois
            // 
            this.btnDois.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDois.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDois.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDois.Location = new System.Drawing.Point(74, 250);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(60, 46);
            this.btnDois.TabIndex = 7;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = false;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTres.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTres.Location = new System.Drawing.Point(140, 250);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(60, 46);
            this.btnTres.TabIndex = 8;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCinco.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCinco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCinco.Location = new System.Drawing.Point(74, 198);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(60, 46);
            this.btnCinco.TabIndex = 9;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnOito
            // 
            this.btnOito.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOito.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOito.Location = new System.Drawing.Point(74, 143);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(60, 46);
            this.btnOito.TabIndex = 10;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = false;
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnNove
            // 
            this.btnNove.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNove.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNove.Location = new System.Drawing.Point(140, 143);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(60, 46);
            this.btnNove.TabIndex = 11;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = false;
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnMais
            // 
            this.btnMais.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMais.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMais.Location = new System.Drawing.Point(206, 250);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(60, 46);
            this.btnMais.TabIndex = 12;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = false;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSeis.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeis.Location = new System.Drawing.Point(140, 198);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(60, 46);
            this.btnSeis.TabIndex = 13;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.SeaGreen;
            this.btnIgual.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIgual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIgual.Location = new System.Drawing.Point(206, 302);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(60, 46);
            this.btnIgual.TabIndex = 14;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnUm
            // 
            this.btnUm.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUm.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUm.Location = new System.Drawing.Point(8, 250);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(60, 46);
            this.btnUm.TabIndex = 15;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = false;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.BackColor = System.Drawing.Color.SeaGreen;
            this.btnQuatro.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuatro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuatro.Location = new System.Drawing.Point(8, 198);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(60, 46);
            this.btnQuatro.TabIndex = 16;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = false;
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnSete
            // 
            this.btnSete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSete.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSete.Location = new System.Drawing.Point(8, 143);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(60, 46);
            this.btnSete.TabIndex = 17;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = false;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.SeaGreen;
            this.btnZero.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZero.Location = new System.Drawing.Point(8, 302);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(126, 46);
            this.btnZero.TabIndex = 18;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // rest
            // 
            this.rest.BackColor = System.Drawing.Color.SeaGreen;
            this.rest.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rest.Location = new System.Drawing.Point(140, 91);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(60, 46);
            this.rest.TabIndex = 19;
            this.rest.Text = "%";
            this.rest.UseVisualStyleBackColor = false;
            this.rest.Click += new System.EventHandler(this.rest_Click);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(274, 354);
            this.Controls.Add(this.rest);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnVezes);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblTextResult);
            this.Name = "FrmCalculator";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTextResult;
        private TextBox txtResult;
        private Button btnC;
        private Button btnPonto;
        private Button btnMenos;
        private Button btnDividir;
        private Button btnVezes;
        private Button btnDois;
        private Button btnTres;
        private Button btnCinco;
        private Button btnOito;
        private Button btnNove;
        private Button btnMais;
        private Button btnSeis;
        private Button btnIgual;
        private Button btnUm;
        private Button btnQuatro;
        private Button btnSete;
        private Button btnZero;
        private Button rest;
    }
}