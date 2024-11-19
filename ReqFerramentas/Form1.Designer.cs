namespace ReqFerramentas
{
    partial class FrmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btncolaboradores = new System.Windows.Forms.Button();
            this.btnFerramentas = new System.Windows.Forms.Button();
            this.btnrequisicoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btncolaboradores
            // 
            this.btncolaboradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncolaboradores.Location = new System.Drawing.Point(157, 174);
            this.btncolaboradores.Name = "btncolaboradores";
            this.btncolaboradores.Size = new System.Drawing.Size(167, 58);
            this.btncolaboradores.TabIndex = 1;
            this.btncolaboradores.Text = "Gerir Colaboradores";
            this.btncolaboradores.UseVisualStyleBackColor = true;
            // 
            // btnFerramentas
            // 
            this.btnFerramentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFerramentas.Location = new System.Drawing.Point(589, 174);
            this.btnFerramentas.Name = "btnFerramentas";
            this.btnFerramentas.Size = new System.Drawing.Size(167, 58);
            this.btnFerramentas.TabIndex = 1;
            this.btnFerramentas.Text = "Gerir Ferramentas";
            this.btnFerramentas.UseVisualStyleBackColor = true;
            // 
            // btnrequisicoes
            // 
            this.btnrequisicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrequisicoes.Location = new System.Drawing.Point(369, 174);
            this.btnrequisicoes.Name = "btnrequisicoes";
            this.btnrequisicoes.Size = new System.Drawing.Size(167, 58);
            this.btnrequisicoes.TabIndex = 1;
            this.btnrequisicoes.Text = "Gerir Requisições";
            this.btnrequisicoes.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnrequisicoes);
            this.Controls.Add(this.btnFerramentas);
            this.Controls.Add(this.btncolaboradores);
            this.Controls.Add(this.label1);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncolaboradores;
        private System.Windows.Forms.Button btnFerramentas;
        private System.Windows.Forms.Button btnrequisicoes;
    }
}

