namespace Quermesse
{
    partial class Sorteador
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
            this.btHistorico = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btProximo = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btHistorico
            // 
            this.btHistorico.Location = new System.Drawing.Point(622, 12);
            this.btHistorico.Name = "btHistorico";
            this.btHistorico.Size = new System.Drawing.Size(166, 91);
            this.btHistorico.TabIndex = 0;
            this.btHistorico.Text = "Historico sorteado";
            this.btHistorico.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(622, 347);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(166, 91);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btProximo
            // 
            this.btProximo.Location = new System.Drawing.Point(273, 347);
            this.btProximo.Name = "btProximo";
            this.btProximo.Size = new System.Drawing.Size(166, 91);
            this.btProximo.TabIndex = 2;
            this.btProximo.Text = "Próximo número";
            this.btProximo.UseVisualStyleBackColor = true;
            this.btProximo.Click += new System.EventHandler(this.btProximo_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.Location = new System.Drawing.Point(-1, 142);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(802, 166);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "lblNumero";
            // 
            // Sorteador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btProximo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btHistorico);
            this.Name = "Sorteador";
            this.Text = "Sorteador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btHistorico;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btProximo;
        private System.Windows.Forms.Label lblNumero;
    }
}