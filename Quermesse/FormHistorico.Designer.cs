namespace Quermesse
{
    partial class FormHistorico
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
            this.lbxHistorico = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxHistorico
            // 
            this.lbxHistorico.FormattingEnabled = true;
            this.lbxHistorico.Location = new System.Drawing.Point(12, 12);
            this.lbxHistorico.Name = "lbxHistorico";
            this.lbxHistorico.Size = new System.Drawing.Size(264, 550);
            this.lbxHistorico.TabIndex = 0;
            // 
            // FormHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 570);
            this.Controls.Add(this.lbxHistorico);
            this.Name = "FormHistorico";
            this.Text = "FormHistorico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxHistorico;
    }
}