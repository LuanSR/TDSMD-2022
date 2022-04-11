
namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSete = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnMultiplica = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnInversao = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnEleva = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnFracao = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSete
            // 
            this.btnSete.Location = new System.Drawing.Point(13, 119);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(53, 40);
            this.btnSete.TabIndex = 0;
            this.btnSete.Text = "7";
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // btnOito
            // 
            this.btnOito.Location = new System.Drawing.Point(72, 119);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(53, 40);
            this.btnOito.TabIndex = 1;
            this.btnOito.Text = "8";
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnNove
            // 
            this.btnNove.Location = new System.Drawing.Point(131, 119);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(53, 40);
            this.btnNove.TabIndex = 1;
            this.btnNove.Text = "9";
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Location = new System.Drawing.Point(13, 165);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(53, 40);
            this.btnQuatro.TabIndex = 0;
            this.btnQuatro.Text = "4";
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(72, 165);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(53, 40);
            this.btnCinco.TabIndex = 1;
            this.btnCinco.Text = "5";
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(131, 165);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(53, 40);
            this.btnSeis.TabIndex = 1;
            this.btnSeis.Text = "6";
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnUm
            // 
            this.btnUm.Location = new System.Drawing.Point(13, 211);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(53, 40);
            this.btnUm.TabIndex = 0;
            this.btnUm.Text = "1";
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btnDois
            // 
            this.btnDois.Location = new System.Drawing.Point(72, 211);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(53, 40);
            this.btnDois.TabIndex = 1;
            this.btnDois.Text = "2";
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(131, 211);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(53, 40);
            this.btnTres.TabIndex = 1;
            this.btnTres.Text = "3";
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(13, 257);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(112, 40);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "0";
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.Location = new System.Drawing.Point(131, 257);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(53, 40);
            this.btnPonto.TabIndex = 1;
            this.btnPonto.Text = ",";
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnMultiplica
            // 
            this.btnMultiplica.Location = new System.Drawing.Point(190, 119);
            this.btnMultiplica.Name = "btnMultiplica";
            this.btnMultiplica.Size = new System.Drawing.Size(53, 40);
            this.btnMultiplica.TabIndex = 1;
            this.btnMultiplica.Text = "*";
            this.btnMultiplica.Click += new System.EventHandler(this.btnMultiplica_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(190, 165);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(53, 40);
            this.btnSubtracao.TabIndex = 1;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(190, 211);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(53, 40);
            this.btnSoma.TabIndex = 1;
            this.btnSoma.Text = "+";
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnInversao
            // 
            this.btnInversao.Location = new System.Drawing.Point(190, 257);
            this.btnInversao.Name = "btnInversao";
            this.btnInversao.Size = new System.Drawing.Size(53, 40);
            this.btnInversao.TabIndex = 1;
            this.btnInversao.Text = "+/-";
            this.btnInversao.Click += new System.EventHandler(this.btnInversao_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(13, 73);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(53, 40);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "C";
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(72, 73);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(53, 40);
            this.btnCE.TabIndex = 1;
            this.btnCE.Text = "CE";
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(131, 73);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(53, 40);
            this.btnBackspace.TabIndex = 1;
            this.btnBackspace.Text = "<=";
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(190, 73);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(53, 40);
            this.btnDivide.TabIndex = 1;
            this.btnDivide.Text = "/";
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(249, 119);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(88, 40);
            this.btnPower.TabIndex = 1;
            this.btnPower.Text = "x^y";
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnEleva
            // 
            this.btnEleva.Location = new System.Drawing.Point(249, 73);
            this.btnEleva.Name = "btnEleva";
            this.btnEleva.Size = new System.Drawing.Size(88, 40);
            this.btnEleva.TabIndex = 1;
            this.btnEleva.Text = "x^2";
            this.btnEleva.Click += new System.EventHandler(this.btnEleva_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(249, 165);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(88, 40);
            this.btnSqrt.TabIndex = 1;
            this.btnSqrt.Text = "Sqrt(x)";
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnFracao
            // 
            this.btnFracao.Location = new System.Drawing.Point(249, 211);
            this.btnFracao.Name = "btnFracao";
            this.btnFracao.Size = new System.Drawing.Size(88, 40);
            this.btnFracao.TabIndex = 1;
            this.btnFracao.Text = "1/x";
            this.btnFracao.Click += new System.EventHandler(this.btnFracao_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(249, 257);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(88, 40);
            this.btnIgual.TabIndex = 1;
            this.btnIgual.Text = "=";
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDisplay.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(13, 13);
            this.txtDisplay.MaxLength = 10;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(324, 50);
            this.txtDisplay.TabIndex = 2;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(352, 311);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnInversao);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btnFracao);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnEleva);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiplica);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnMultiplica;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnInversao;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnEleva;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnFracao;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}

