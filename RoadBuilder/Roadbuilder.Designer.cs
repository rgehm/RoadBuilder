namespace Roadbuilder
{
    partial class Roadbuilder
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Roadbuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 519);
            this.Name = "Roadbuilder";
            this.Text = "Roadbuilder";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Roadbuilder_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Roadbuilder_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Roadbuilder_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

