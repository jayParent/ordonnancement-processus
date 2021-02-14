namespace Ordonnancement_processus
{
    partial class MenuCreationProcessus
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
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.groupBox_infoProcessus = new System.Windows.Forms.GroupBox();
            this.label_instructionsEsProcessus = new System.Windows.Forms.Label();
            this.label_instructionsCalculProcessus = new System.Windows.Forms.Label();
            this.label_prioriteProcessus = new System.Windows.Forms.Label();
            this.label_nomProcessus = new System.Windows.Forms.Label();
            this.numericUpDown_es = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_calculs = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_priorite = new System.Windows.Forms.NumericUpDown();
            this.groupBox_threads = new System.Windows.Forms.GroupBox();
            this.radioButton_threeThreads = new System.Windows.Forms.RadioButton();
            this.radioButton_twoThreads = new System.Windows.Forms.RadioButton();
            this.radioButton_monoThread = new System.Windows.Forms.RadioButton();
            this.button_creerProcesses = new System.Windows.Forms.Button();
            this.button_annulerProcessus = new System.Windows.Forms.Button();
            this.groupBox_infoProcessus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_es)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_calculs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_priorite)).BeginInit();
            this.groupBox_threads.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(154, 22);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(200, 23);
            this.textBox_nom.TabIndex = 0;
            this.textBox_nom.Text = "Processus 1";
            // 
            // groupBox_infoProcessus
            // 
            this.groupBox_infoProcessus.Controls.Add(this.label_instructionsEsProcessus);
            this.groupBox_infoProcessus.Controls.Add(this.label_instructionsCalculProcessus);
            this.groupBox_infoProcessus.Controls.Add(this.label_prioriteProcessus);
            this.groupBox_infoProcessus.Controls.Add(this.label_nomProcessus);
            this.groupBox_infoProcessus.Controls.Add(this.numericUpDown_es);
            this.groupBox_infoProcessus.Controls.Add(this.numericUpDown_calculs);
            this.groupBox_infoProcessus.Controls.Add(this.numericUpDown_priorite);
            this.groupBox_infoProcessus.Controls.Add(this.textBox_nom);
            this.groupBox_infoProcessus.Location = new System.Drawing.Point(12, 12);
            this.groupBox_infoProcessus.Name = "groupBox_infoProcessus";
            this.groupBox_infoProcessus.Size = new System.Drawing.Size(360, 147);
            this.groupBox_infoProcessus.TabIndex = 1;
            this.groupBox_infoProcessus.TabStop = false;
            this.groupBox_infoProcessus.Text = "Processus";
            // 
            // label_instructionsEsProcessus
            // 
            this.label_instructionsEsProcessus.AutoSize = true;
            this.label_instructionsEsProcessus.Location = new System.Drawing.Point(77, 111);
            this.label_instructionsEsProcessus.Name = "label_instructionsEsProcessus";
            this.label_instructionsEsProcessus.Size = new System.Drawing.Size(152, 15);
            this.label_instructionsEsProcessus.TabIndex = 2;
            this.label_instructionsEsProcessus.Text = "Instructions d\'entrée/sortie:";
            // 
            // label_instructionsCalculProcessus
            // 
            this.label_instructionsCalculProcessus.AutoSize = true;
            this.label_instructionsCalculProcessus.Location = new System.Drawing.Point(77, 82);
            this.label_instructionsCalculProcessus.Name = "label_instructionsCalculProcessus";
            this.label_instructionsCalculProcessus.Size = new System.Drawing.Size(122, 15);
            this.label_instructionsCalculProcessus.TabIndex = 2;
            this.label_instructionsCalculProcessus.Text = "Instructions de calcul:";
            // 
            // label_prioriteProcessus
            // 
            this.label_prioriteProcessus.AutoSize = true;
            this.label_prioriteProcessus.Location = new System.Drawing.Point(77, 53);
            this.label_prioriteProcessus.Name = "label_prioriteProcessus";
            this.label_prioriteProcessus.Size = new System.Drawing.Size(48, 15);
            this.label_prioriteProcessus.TabIndex = 2;
            this.label_prioriteProcessus.Text = "Priorité:";
            // 
            // label_nomProcessus
            // 
            this.label_nomProcessus.AutoSize = true;
            this.label_nomProcessus.Location = new System.Drawing.Point(77, 25);
            this.label_nomProcessus.Name = "label_nomProcessus";
            this.label_nomProcessus.Size = new System.Drawing.Size(37, 15);
            this.label_nomProcessus.TabIndex = 2;
            this.label_nomProcessus.Text = "Nom:";
            // 
            // numericUpDown_es
            // 
            this.numericUpDown_es.Location = new System.Drawing.Point(234, 109);
            this.numericUpDown_es.Name = "numericUpDown_es";
            this.numericUpDown_es.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_es.TabIndex = 1;
            this.numericUpDown_es.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown_calculs
            // 
            this.numericUpDown_calculs.Location = new System.Drawing.Point(234, 80);
            this.numericUpDown_calculs.Name = "numericUpDown_calculs";
            this.numericUpDown_calculs.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_calculs.TabIndex = 1;
            this.numericUpDown_calculs.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numericUpDown_priorite
            // 
            this.numericUpDown_priorite.Location = new System.Drawing.Point(234, 51);
            this.numericUpDown_priorite.Name = "numericUpDown_priorite";
            this.numericUpDown_priorite.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_priorite.TabIndex = 1;
            // 
            // groupBox_threads
            // 
            this.groupBox_threads.Controls.Add(this.radioButton_threeThreads);
            this.groupBox_threads.Controls.Add(this.radioButton_twoThreads);
            this.groupBox_threads.Controls.Add(this.radioButton_monoThread);
            this.groupBox_threads.Location = new System.Drawing.Point(12, 165);
            this.groupBox_threads.Name = "groupBox_threads";
            this.groupBox_threads.Size = new System.Drawing.Size(360, 105);
            this.groupBox_threads.TabIndex = 2;
            this.groupBox_threads.TabStop = false;
            this.groupBox_threads.Text = "Threads";
            // 
            // radioButton_threeThreads
            // 
            this.radioButton_threeThreads.AutoSize = true;
            this.radioButton_threeThreads.Location = new System.Drawing.Point(77, 72);
            this.radioButton_threeThreads.Name = "radioButton_threeThreads";
            this.radioButton_threeThreads.Size = new System.Drawing.Size(75, 19);
            this.radioButton_threeThreads.TabIndex = 0;
            this.radioButton_threeThreads.Text = "3 Threads";
            this.radioButton_threeThreads.UseVisualStyleBackColor = true;
            // 
            // radioButton_twoThreads
            // 
            this.radioButton_twoThreads.AutoSize = true;
            this.radioButton_twoThreads.Location = new System.Drawing.Point(77, 47);
            this.radioButton_twoThreads.Name = "radioButton_twoThreads";
            this.radioButton_twoThreads.Size = new System.Drawing.Size(75, 19);
            this.radioButton_twoThreads.TabIndex = 0;
            this.radioButton_twoThreads.Text = "2 Threads";
            this.radioButton_twoThreads.UseVisualStyleBackColor = true;
            // 
            // radioButton_monoThread
            // 
            this.radioButton_monoThread.AutoSize = true;
            this.radioButton_monoThread.Checked = true;
            this.radioButton_monoThread.Location = new System.Drawing.Point(77, 22);
            this.radioButton_monoThread.Name = "radioButton_monoThread";
            this.radioButton_monoThread.Size = new System.Drawing.Size(98, 19);
            this.radioButton_monoThread.TabIndex = 0;
            this.radioButton_monoThread.TabStop = true;
            this.radioButton_monoThread.Text = "Mono-Thread";
            this.radioButton_monoThread.UseVisualStyleBackColor = true;
            // 
            // button_creerProcesses
            // 
            this.button_creerProcesses.Location = new System.Drawing.Point(112, 283);
            this.button_creerProcesses.Name = "button_creerProcesses";
            this.button_creerProcesses.Size = new System.Drawing.Size(75, 25);
            this.button_creerProcesses.TabIndex = 3;
            this.button_creerProcesses.Text = "Créer";
            this.button_creerProcesses.UseVisualStyleBackColor = true;
            this.button_creerProcesses.Click += new System.EventHandler(this.button_creerProcessus_Click);
            // 
            // button_annulerProcessus
            // 
            this.button_annulerProcessus.Location = new System.Drawing.Point(193, 283);
            this.button_annulerProcessus.Name = "button_annulerProcessus";
            this.button_annulerProcessus.Size = new System.Drawing.Size(75, 25);
            this.button_annulerProcessus.TabIndex = 4;
            this.button_annulerProcessus.Text = "Annuler";
            this.button_annulerProcessus.UseVisualStyleBackColor = true;
            this.button_annulerProcessus.Click += new System.EventHandler(this.button_annulerProcessus_Click);
            // 
            // MenuCreationProcessus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 320);
            this.Controls.Add(this.button_annulerProcessus);
            this.Controls.Add(this.button_creerProcesses);
            this.Controls.Add(this.groupBox_threads);
            this.Controls.Add(this.groupBox_infoProcessus);
            this.Name = "MenuCreationProcessus";
            this.Text = "Nouveau Processus";
            this.groupBox_infoProcessus.ResumeLayout(false);
            this.groupBox_infoProcessus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_es)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_calculs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_priorite)).EndInit();
            this.groupBox_threads.ResumeLayout(false);
            this.groupBox_threads.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.GroupBox groupBox_infoProcessus;
        private System.Windows.Forms.Label label_instructionsEsProcessus;
        private System.Windows.Forms.Label label_instructionsCalculProcessus;
        private System.Windows.Forms.Label label_prioriteProcessus;
        private System.Windows.Forms.Label label_nomProcessus;
        private System.Windows.Forms.NumericUpDown numericUpDown_es;
        private System.Windows.Forms.NumericUpDown numericUpDown_calculs;
        private System.Windows.Forms.NumericUpDown numericUpDown_priorite;
        private System.Windows.Forms.GroupBox groupBox_threads;
        private System.Windows.Forms.RadioButton radioButton_threeThreads;
        private System.Windows.Forms.RadioButton radioButton_twoThreads;
        private System.Windows.Forms.RadioButton radioButton_monoThread;
        private System.Windows.Forms.Button button_creerProcesses;
        private System.Windows.Forms.Button button_annulerProcessus;
    }
}