namespace projeto_perimetro_retangulo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VALORBASE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VALORALTURA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CALCULARAREA = new System.Windows.Forms.Button();
            this.CALCULARPERIMETRO = new System.Windows.Forms.Button();
            this.resultadoarea = new System.Windows.Forms.Label();
            this.resultadoperimetro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(34, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 145);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "b";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "a";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // VALORBASE
            // 
            this.VALORBASE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VALORBASE.Location = new System.Drawing.Point(494, 59);
            this.VALORBASE.Name = "VALORBASE";
            this.VALORBASE.Size = new System.Drawing.Size(222, 22);
            this.VALORBASE.TabIndex = 3;
            this.VALORBASE.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "valor da base";
            // 
            // VALORALTURA
            // 
            this.VALORALTURA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VALORALTURA.Location = new System.Drawing.Point(494, 155);
            this.VALORALTURA.Name = "VALORALTURA";
            this.VALORALTURA.Size = new System.Drawing.Size(222, 22);
            this.VALORALTURA.TabIndex = 5;
            this.VALORALTURA.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(555, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "valor da altura";
            // 
            // CALCULARAREA
            // 
            this.CALCULARAREA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CALCULARAREA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CALCULARAREA.ForeColor = System.Drawing.Color.BlueViolet;
            this.CALCULARAREA.Location = new System.Drawing.Point(494, 205);
            this.CALCULARAREA.Name = "CALCULARAREA";
            this.CALCULARAREA.Size = new System.Drawing.Size(233, 87);
            this.CALCULARAREA.TabIndex = 7;
            this.CALCULARAREA.Text = "CALCULAR ÁREA";
            this.CALCULARAREA.UseVisualStyleBackColor = false;
            this.CALCULARAREA.Click += new System.EventHandler(this.button1_Click);
            // 
            // CALCULARPERIMETRO
            // 
            this.CALCULARPERIMETRO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CALCULARPERIMETRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CALCULARPERIMETRO.ForeColor = System.Drawing.Color.BlueViolet;
            this.CALCULARPERIMETRO.Location = new System.Drawing.Point(494, 331);
            this.CALCULARPERIMETRO.Name = "CALCULARPERIMETRO";
            this.CALCULARPERIMETRO.Size = new System.Drawing.Size(233, 87);
            this.CALCULARPERIMETRO.TabIndex = 8;
            this.CALCULARPERIMETRO.Text = "CALCULAR  PERÍMETRO";
            this.CALCULARPERIMETRO.UseVisualStyleBackColor = false;
            this.CALCULARPERIMETRO.Click += new System.EventHandler(this.button2_Click);
            // 
            // resultadoarea
            // 
            this.resultadoarea.AutoSize = true;
            this.resultadoarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoarea.Location = new System.Drawing.Point(591, 295);
            this.resultadoarea.Name = "resultadoarea";
            this.resultadoarea.Size = new System.Drawing.Size(31, 33);
            this.resultadoarea.TabIndex = 9;
            this.resultadoarea.Text = "0";
            // 
            // resultadoperimetro
            // 
            this.resultadoperimetro.AutoSize = true;
            this.resultadoperimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoperimetro.Location = new System.Drawing.Point(591, 421);
            this.resultadoperimetro.Name = "resultadoperimetro";
            this.resultadoperimetro.Size = new System.Drawing.Size(31, 33);
            this.resultadoperimetro.TabIndex = 10;
            this.resultadoperimetro.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultadoperimetro);
            this.Controls.Add(this.resultadoarea);
            this.Controls.Add(this.CALCULARPERIMETRO);
            this.Controls.Add(this.CALCULARAREA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VALORALTURA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VALORBASE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VALORBASE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VALORALTURA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CALCULARAREA;
        private System.Windows.Forms.Button CALCULARPERIMETRO;
        private System.Windows.Forms.Label resultadoarea;
        private System.Windows.Forms.Label resultadoperimetro;
    }
}

