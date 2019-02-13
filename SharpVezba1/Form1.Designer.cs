namespace SharpVezba1
{
    partial class Form1
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
            this.buttonIspitSelect = new System.Windows.Forms.Button();
            this.dataGridViewIspiti = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxPredmeti = new System.Windows.Forms.ComboBox();
            this.buttonStudentInsert = new System.Windows.Forms.Button();
            this.listViewPredmetIspit = new System.Windows.Forms.ListView();
            this.buttonStudentSelect = new System.Windows.Forms.Button();
            this.dataGridViewRazno = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIspiti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRazno)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIspitSelect
            // 
            this.buttonIspitSelect.Location = new System.Drawing.Point(58, 12);
            this.buttonIspitSelect.Name = "buttonIspitSelect";
            this.buttonIspitSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonIspitSelect.TabIndex = 0;
            this.buttonIspitSelect.Text = "Ispit Select";
            this.buttonIspitSelect.UseVisualStyleBackColor = true;
            this.buttonIspitSelect.Click += new System.EventHandler(this.buttonIspitSelect_Click);
            // 
            // dataGridViewIspiti
            // 
            this.dataGridViewIspiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIspiti.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewIspiti.Name = "dataGridViewIspiti";
            this.dataGridViewIspiti.Size = new System.Drawing.Size(264, 337);
            this.dataGridViewIspiti.TabIndex = 1;
            this.dataGridViewIspiti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIspiti_CellContentClick);
            // 
            // comboBoxPredmeti
            // 
            this.comboBoxPredmeti.FormattingEnabled = true;
            this.comboBoxPredmeti.Location = new System.Drawing.Point(322, 12);
            this.comboBoxPredmeti.Name = "comboBoxPredmeti";
            this.comboBoxPredmeti.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPredmeti.TabIndex = 2;
            this.comboBoxPredmeti.SelectedIndexChanged += new System.EventHandler(this.comboBoxPredmeti_SelectedIndexChanged);
            // 
            // buttonStudentInsert
            // 
            this.buttonStudentInsert.Location = new System.Drawing.Point(478, 10);
            this.buttonStudentInsert.Name = "buttonStudentInsert";
            this.buttonStudentInsert.Size = new System.Drawing.Size(105, 23);
            this.buttonStudentInsert.TabIndex = 3;
            this.buttonStudentInsert.Text = "Student Insert";
            this.buttonStudentInsert.UseVisualStyleBackColor = true;
            this.buttonStudentInsert.Click += new System.EventHandler(this.buttonStudentInsert_Click);
            // 
            // listViewPredmetIspit
            // 
            this.listViewPredmetIspit.Location = new System.Drawing.Point(322, 66);
            this.listViewPredmetIspit.Name = "listViewPredmetIspit";
            this.listViewPredmetIspit.Size = new System.Drawing.Size(278, 155);
            this.listViewPredmetIspit.TabIndex = 4;
            this.listViewPredmetIspit.UseCompatibleStateImageBehavior = false;
            this.listViewPredmetIspit.SelectedIndexChanged += new System.EventHandler(this.listViewPredmetIspit_SelectedIndexChanged);
            // 
            // buttonStudentSelect
            // 
            this.buttonStudentSelect.Location = new System.Drawing.Point(450, 224);
            this.buttonStudentSelect.Name = "buttonStudentSelect";
            this.buttonStudentSelect.Size = new System.Drawing.Size(133, 23);
            this.buttonStudentSelect.TabIndex = 5;
            this.buttonStudentSelect.Text = "Student Select";
            this.buttonStudentSelect.UseVisualStyleBackColor = true;
            this.buttonStudentSelect.Click += new System.EventHandler(this.buttonStudentSelect_Click);
            // 
            // dataGridViewRazno
            // 
            this.dataGridViewRazno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRazno.Location = new System.Drawing.Point(322, 253);
            this.dataGridViewRazno.Name = "dataGridViewRazno";
            this.dataGridViewRazno.Size = new System.Drawing.Size(278, 150);
            this.dataGridViewRazno.TabIndex = 6;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 415);
            this.Controls.Add(this.dataGridViewRazno);
            this.Controls.Add(this.buttonStudentSelect);
            this.Controls.Add(this.listViewPredmetIspit);
            this.Controls.Add(this.buttonStudentInsert);
            this.Controls.Add(this.comboBoxPredmeti);
            this.Controls.Add(this.dataGridViewIspiti);
            this.Controls.Add(this.buttonIspitSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIspiti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRazno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIspitSelect;
        private System.Windows.Forms.DataGridView dataGridViewIspiti;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox comboBoxPredmeti;
        private System.Windows.Forms.Button buttonStudentInsert;
        private System.Windows.Forms.ListView listViewPredmetIspit;
        private System.Windows.Forms.Button buttonStudentSelect;
        private System.Windows.Forms.DataGridView dataGridViewRazno;
    }
}

