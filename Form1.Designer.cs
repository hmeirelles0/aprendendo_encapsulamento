namespace prjEncapsulamento
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.btnEnvia = new System.Windows.Forms.Button();
            this.lblLetreiro = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxOperadores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(12, 25);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(189, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // btnEnvia
            // 
            this.btnEnvia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvia.Location = new System.Drawing.Point(201, 262);
            this.btnEnvia.Name = "btnEnvia";
            this.btnEnvia.Size = new System.Drawing.Size(75, 23);
            this.btnEnvia.TabIndex = 1;
            this.btnEnvia.Text = "ENVIAR";
            this.btnEnvia.UseVisualStyleBackColor = true;
            this.btnEnvia.Click += new System.EventHandler(this.BtnEnvia_Click);
            // 
            // lblLetreiro
            // 
            this.lblLetreiro.AutoSize = true;
            this.lblLetreiro.Location = new System.Drawing.Point(12, 9);
            this.lblLetreiro.Name = "lblLetreiro";
            this.lblLetreiro.Size = new System.Drawing.Size(157, 13);
            this.lblLetreiro.TabIndex = 2;
            this.lblLetreiro.Text = "Favor, digite um número abaixo:";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(12, 175);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(189, 20);
            this.txtNum2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Favor, digite outro número abaixo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Escolha a operação que deseja realizar:";
            // 
            // cbxOperadores
            // 
            this.cbxOperadores.FormattingEnabled = true;
            this.cbxOperadores.Items.AddRange(new object[] {
            "Soma ( + )",
            "Subtração ( - )",
            "Multiplicação ( x )",
            "Divisão ( / )"});
            this.cbxOperadores.Location = new System.Drawing.Point(15, 110);
            this.cbxOperadores.Name = "cbxOperadores";
            this.cbxOperadores.Size = new System.Drawing.Size(186, 21);
            this.cbxOperadores.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(288, 297);
            this.Controls.Add(this.cbxOperadores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblLetreiro);
            this.Controls.Add(this.btnEnvia);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Button btnEnvia;
        private System.Windows.Forms.Label lblLetreiro;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxOperadores;
    }
}

