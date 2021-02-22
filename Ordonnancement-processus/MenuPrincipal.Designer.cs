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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_paps = new System.Windows.Forms.RadioButton();
            this.radioButton_pp = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_deletePid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_processus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ajouterProcessus
            // 
            this.btn_ajouterProcessus.Location = new System.Drawing.Point(12, 13);
            this.btn_ajouterProcessus.Name = "btn_ajouterProcessus";
            this.btn_ajouterProcessus.Size = new System.Drawing.Size(126, 25);
            this.btn_ajouterProcessus.TabIndex = 0;
            this.btn_ajouterProcessus.Text = "Ajouter un processus";
            this.btn_ajouterProcessus.UseVisualStyleBackColor = true;
            this.btn_ajouterProcessus.Click += new System.EventHandler(this.btn_ajouterProcessus_Click);
            // 
            // btn_lancer
            // 
            this.btn_lancer.Location = new System.Drawing.Point(119, 15);
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
            this.dgv_processus.Location = new System.Drawing.Point(12, 82);
            this.dgv_processus.Name = "dgv_processus";
            this.dgv_processus.RowHeadersVisible = false;
            this.dgv_processus.Size = new System.Drawing.Size(460, 423);
            this.dgv_processus.TabIndex = 3;
            this.dgv_processus.Text = "dataGridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_paps);
            this.groupBox1.Controls.Add(this.radioButton_pp);
            this.groupBox1.Controls.Add(this.btn_lancer);
            this.groupBox1.Location = new System.Drawing.Point(256, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_paps
            // 
            this.radioButton_paps.AutoSize = true;
            this.radioButton_paps.Location = new System.Drawing.Point(65, 17);
            this.radioButton_paps.Name = "radioButton_paps";
            this.radioButton_paps.Size = new System.Drawing.Size(52, 19);
            this.radioButton_paps.TabIndex = 4;
            this.radioButton_paps.TabStop = true;
            this.radioButton_paps.Text = "PAPS";
            this.radioButton_paps.UseVisualStyleBackColor = true;
            this.radioButton_paps.CheckedChanged += new System.EventHandler(this.radioButton_pca_CheckedChanged);
            // 
            // radioButton_pp
            // 
            this.radioButton_pp.AutoSize = true;
            this.radioButton_pp.Checked = true;
            this.radioButton_pp.Location = new System.Drawing.Point(20, 17);
            this.radioButton_pp.Name = "radioButton_pp";
            this.radioButton_pp.Size = new System.Drawing.Size(39, 19);
            this.radioButton_pp.TabIndex = 3;
            this.radioButton_pp.TabStop = true;
            this.radioButton_pp.Text = "PP";
            this.radioButton_pp.UseVisualStyleBackColor = true;
            this.radioButton_pp.CheckedChanged += new System.EventHandler(this.radioButton_pp_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Réinitialiser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(276, 56);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "Supprimer";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_deletePid
            // 
            this.textBox_deletePid.Location = new System.Drawing.Point(228, 56);
            this.textBox_deletePid.Name = "textBox_deletePid";
            this.textBox_deletePid.Size = new System.Drawing.Size(35, 23);
            this.textBox_deletePid.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Entrez le PID du processus à supprimer";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_deletePid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_processus);
            this.Controls.Add(this.btn_ajouterProcessus);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_processus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouterProcessus;
        private System.Windows.Forms.Button btn_lancer;
        private System.Windows.Forms.DataGridView dgv_processus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_pp;
        private System.Windows.Forms.RadioButton radioButton_paps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_deletePid;
        private System.Windows.Forms.Label label1;
    }
}

