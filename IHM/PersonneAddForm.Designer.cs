namespace IHM
{
    partial class PersonneAddForm
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxBtn = new System.Windows.Forms.GroupBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBoxNaissance = new System.Windows.Forms.GroupBox();
            this.dateTimeNaissance = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPrenom = new System.Windows.Forms.GroupBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.groupBoxBtn.SuspendLayout();
            this.groupBoxName.SuspendLayout();
            this.groupBoxNaissance.SuspendLayout();
            this.groupBoxPrenom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(32, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 180);
            this.panel2.TabIndex = 2;
            // 
            // groupBoxBtn
            // 
            this.groupBoxBtn.Controls.Add(this.btnValider);
            this.groupBoxBtn.Controls.Add(this.buttonAnnuler);
            this.groupBoxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxBtn.Location = new System.Drawing.Point(684, 0);
            this.groupBoxBtn.Name = "groupBoxBtn";
            this.groupBoxBtn.Size = new System.Drawing.Size(133, 120);
            this.groupBoxBtn.TabIndex = 2;
            this.groupBoxBtn.TabStop = false;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(6, 13);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(120, 26);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(6, 40);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(120, 26);
            this.buttonAnnuler.TabIndex = 1;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.tbName);
            this.groupBoxName.Location = new System.Drawing.Point(126, 15);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(200, 38);
            this.groupBoxName.TabIndex = 0;
            this.groupBoxName.TabStop = false;
            this.groupBoxName.Text = "Nom ::";
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Location = new System.Drawing.Point(3, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(194, 20);
            this.tbName.TabIndex = 0;
            // 
            // groupBoxNaissance
            // 
            this.groupBoxNaissance.Controls.Add(this.dateTimeNaissance);
            this.groupBoxNaissance.Controls.Add(this.panel2);
            this.groupBoxNaissance.Location = new System.Drawing.Point(329, 15);
            this.groupBoxNaissance.Name = "groupBoxNaissance";
            this.groupBoxNaissance.Size = new System.Drawing.Size(200, 38);
            this.groupBoxNaissance.TabIndex = 1;
            this.groupBoxNaissance.TabStop = false;
            this.groupBoxNaissance.Text = "Date Naissance ::";
            // 
            // dateTimeNaissance
            // 
            this.dateTimeNaissance.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNaissance.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimeNaissance.CustomFormat = "";
            this.dateTimeNaissance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNaissance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimeNaissance.Location = new System.Drawing.Point(3, 16);
            this.dateTimeNaissance.Name = "dateTimeNaissance";
            this.dateTimeNaissance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimeNaissance.RightToLeftLayout = true;
            this.dateTimeNaissance.Size = new System.Drawing.Size(194, 22);
            this.dateTimeNaissance.TabIndex = 3;
            this.dateTimeNaissance.Value = new System.DateTime(2017, 7, 21, 0, 0, 0, 0);
            // 
            // groupBoxPrenom
            // 
            this.groupBoxPrenom.Controls.Add(this.tbPrenom);
            this.groupBoxPrenom.Location = new System.Drawing.Point(126, 70);
            this.groupBoxPrenom.Name = "groupBoxPrenom";
            this.groupBoxPrenom.Size = new System.Drawing.Size(200, 38);
            this.groupBoxPrenom.TabIndex = 1;
            this.groupBoxPrenom.TabStop = false;
            this.groupBoxPrenom.Text = "Prénom ::";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPrenom.Location = new System.Drawing.Point(3, 16);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(194, 20);
            this.tbPrenom.TabIndex = 0;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackgroundImage = global::IHM.Properties.Resources.Friend;
            this.pictureBoxCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCover.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxCover.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxCover.TabIndex = 4;
            this.pictureBoxCover.TabStop = false;
            // 
            // PersonneAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 120);
            this.Controls.Add(this.groupBoxPrenom);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.groupBoxBtn);
            this.Controls.Add(this.groupBoxName);
            this.Controls.Add(this.groupBoxNaissance);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonneAddForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonneAddForm_FormClosing);
            this.Load += new System.EventHandler(this.PersonneAddForm_Load);
            this.groupBoxBtn.ResumeLayout(false);
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.groupBoxNaissance.ResumeLayout(false);
            this.groupBoxPrenom.ResumeLayout(false);
            this.groupBoxPrenom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxBtn;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBoxNaissance;
        private System.Windows.Forms.GroupBox groupBoxPrenom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.DateTimePicker dateTimeNaissance;
    }
}
