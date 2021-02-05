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
            this.btn_lancer = new System.Windows.Forms.Button();
            this.dgv_processus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_processus)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ajouterProcessus
            // 
            this.btn_ajouterProcessus.Location = new System.Drawing.Point(12, 12);
            this.btn_ajouterProcessus.Name = "btn_ajouterProcessus";
            this.btn_ajouterProcessus.Size = new System.Drawing.Size(150, 25);
            this.btn_ajouterProcessus.TabIndex = 0;
            this.btn_ajouterProcessus.Text = "Ajouter un processus";
            this.btn_ajouterProcessus.UseVisualStyleBackColor = true;
            this.btn_ajouterProcessus.Click += new System.EventHandler(this.btn_ajouterProcessus_Click);
            // 
            // btn_lancer
            // 
            this.btn_lancer.Location = new System.Drawing.Point(397, 12);
            this.btn_lancer.Name = "btn_lancer";
            this.btn_lancer.Size = new System.Drawing.Size(75, 25);
            this.btn_lancer.TabIndex = 2;
            this.btn_lancer.Text = "Lancer";
            this.btn_lancer.UseVisualStyleBackColor = true;
            this.btn_lancer.Click += new System.EventHandler(this.btn_lancer_Click);
            // 
            // dgv_processus
            // 
            this.dgv_processus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_processus.Location = new System.Drawing.Point(12, 52);
            this.dgv_processus.Name = "dgv_processus";
            this.dgv_processus.Size = new System.Drawing.Size(460, 453);
            this.dgv_processus.TabIndex = 3;
            this.dgv_processus.Text = "dataGridView1";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 517);
            this.Controls.Add(this.dgv_processus);
            this.Controls.Add(this.btn_lancer);
            this.Controls.Add(this.btn_ajouterProcessus);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_processus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouterProcessus;
        private System.Windows.Forms.Button btn_lancer;
        private System.Windows.Forms.DataGridView dgv_processus;
    }
}

