namespace Ordonnancement_processus
{
    partial class MenuPrincipal
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
            this.btn_ajouterProcessus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ajouterProcessus
            // 
            this.btn_ajouterProcessus.Location = new System.Drawing.Point(70, 52);
            this.btn_ajouterProcessus.Name = "btn_ajouterProcessus";
            this.btn_ajouterProcessus.Size = new System.Drawing.Size(150, 25);
            this.btn_ajouterProcessus.TabIndex = 0;
            this.btn_ajouterProcessus.Text = "Ajouter un processus";
            this.btn_ajouterProcessus.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.btn_ajouterProcessus);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouterProcessus;
    }
}

