namespace SIGEFA.Reportes
{
    partial class frmRptNotaDebito
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
            this.crvNotaDebito = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvNotaDebito
            // 
            this.crvNotaDebito.ActiveViewIndex = -1;
            this.crvNotaDebito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvNotaDebito.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvNotaDebito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvNotaDebito.Location = new System.Drawing.Point(0, 0);
            this.crvNotaDebito.Name = "crvNotaDebito";
            this.crvNotaDebito.Size = new System.Drawing.Size(284, 262);
            this.crvNotaDebito.TabIndex = 0;
            // 
            // frmRptNotaDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.crvNotaDebito);
            this.Name = "frmRptNotaDebito";
            this.Text = "frmRptNotaDebito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvNotaDebito;
    }
}