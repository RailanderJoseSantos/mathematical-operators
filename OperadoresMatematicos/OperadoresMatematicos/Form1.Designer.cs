namespace OperadoresMatematicos
{
    partial class Form1
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
            this.btn_executar = new System.Windows.Forms.Button();
            this.label_resultado = new System.Windows.Forms.Label();
            this.text_parcela1 = new System.Windows.Forms.TextBox();
            this.text_parcela2 = new System.Windows.Forms.TextBox();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_menos = new System.Windows.Forms.Button();
            this.btn_multiplica = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_modulo = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(12, 295);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(77, 29);
            this.btn_executar.TabIndex = 0;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.Btn_executar_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Location = new System.Drawing.Point(12, 248);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(0, 13);
            this.label_resultado.TabIndex = 1;
            // 
            // text_parcela1
            // 
            this.text_parcela1.Location = new System.Drawing.Point(12, 42);
            this.text_parcela1.Name = "text_parcela1";
            this.text_parcela1.Size = new System.Drawing.Size(137, 20);
            this.text_parcela1.TabIndex = 2;
            // 
            // text_parcela2
            // 
            this.text_parcela2.Location = new System.Drawing.Point(12, 79);
            this.text_parcela2.Name = "text_parcela2";
            this.text_parcela2.Size = new System.Drawing.Size(137, 20);
            this.text_parcela2.TabIndex = 3;
            // 
            // btn_soma
            // 
            this.btn_soma.Location = new System.Drawing.Point(166, 58);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(36, 23);
            this.btn_soma.TabIndex = 4;
            this.btn_soma.Text = "+";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.Btn_soma_Click);
            // 
            // btn_menos
            // 
            this.btn_menos.Location = new System.Drawing.Point(208, 58);
            this.btn_menos.Name = "btn_menos";
            this.btn_menos.Size = new System.Drawing.Size(36, 23);
            this.btn_menos.TabIndex = 5;
            this.btn_menos.Text = "-";
            this.btn_menos.UseVisualStyleBackColor = true;
            this.btn_menos.Click += new System.EventHandler(this.Btn_menos_Click);
            // 
            // btn_multiplica
            // 
            this.btn_multiplica.Location = new System.Drawing.Point(250, 58);
            this.btn_multiplica.Name = "btn_multiplica";
            this.btn_multiplica.Size = new System.Drawing.Size(36, 23);
            this.btn_multiplica.TabIndex = 6;
            this.btn_multiplica.Text = "x";
            this.btn_multiplica.UseVisualStyleBackColor = true;
            this.btn_multiplica.Click += new System.EventHandler(this.Btn_multiplica_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(292, 58);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(36, 23);
            this.btn_divide.TabIndex = 7;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.Btn_divide_Click);
            // 
            // btn_modulo
            // 
            this.btn_modulo.Location = new System.Drawing.Point(334, 58);
            this.btn_modulo.Name = "btn_modulo";
            this.btn_modulo.Size = new System.Drawing.Size(44, 23);
            this.btn_modulo.TabIndex = 8;
            this.btn_modulo.Text = "MOD";
            this.btn_modulo.UseVisualStyleBackColor = true;
            this.btn_modulo.Click += new System.EventHandler(this.Btn_modulo_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(110, 295);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(77, 29);
            this.bt_limpar.TabIndex = 9;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.Bt_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 336);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.btn_modulo);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_multiplica);
            this.Controls.Add(this.btn_menos);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.text_parcela2);
            this.Controls.Add(this.text_parcela1);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.btn_executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.TextBox text_parcela1;
        private System.Windows.Forms.TextBox text_parcela2;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_menos;
        private System.Windows.Forms.Button btn_multiplica;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_modulo;
        private System.Windows.Forms.Button bt_limpar;
    }
}

