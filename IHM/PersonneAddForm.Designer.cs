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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxContent = new System.Windows.Forms.GroupBox();
            this.groupBoxBtn = new System.Windows.Forms.GroupBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBoxNaissance = new System.Windows.Forms.GroupBox();
            this.groupBoxPrenom = new System.Windows.Forms.GroupBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.panelImg = new System.Windows.Forms.Panel();
            this.btnImage = new System.Windows.Forms.Button();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.dateTimeNaissance = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxContent.SuspendLayout();
            this.groupBoxBtn.SuspendLayout();
            this.groupBoxName.SuspendLayout();
            this.groupBoxNaissance.SuspendLayout();
            this.groupBoxPrenom.SuspendLayout();
            this.panelImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panelImg);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxContent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(183, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 180);
            this.panel2.TabIndex = 2;
            // 
            // groupBoxContent
            // 
            this.groupBoxContent.Controls.Add(this.groupBoxBtn);
            this.groupBoxContent.Controls.Add(this.groupBoxName);
            this.groupBoxContent.Controls.Add(this.groupBoxNaissance);
            this.groupBoxContent.Controls.Add(this.groupBoxPrenom);
            this.groupBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxContent.Location = new System.Drawing.Point(0, 0);
            this.groupBoxContent.Name = "groupBoxContent";
            this.groupBoxContent.Size = new System.Drawing.Size(793, 180);
            this.groupBoxContent.TabIndex = 2;
            this.groupBoxContent.TabStop = false;
            this.groupBoxContent.Enter += new System.EventHandler(this.groupBoxContent_Enter);
            // 
            // groupBoxBtn
            // 
            this.groupBoxBtn.Controls.Add(this.btnValider);
            this.groupBoxBtn.Controls.Add(this.buttonAnnuler);
            this.groupBoxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxBtn.Location = new System.Drawing.Point(658, 16);
            this.groupBoxBtn.Name = "groupBoxBtn";
            this.groupBoxBtn.Size = new System.Drawing.Size(132, 161);
            this.groupBoxBtn.TabIndex = 2;
            this.groupBoxBtn.TabStop = false;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(6, 59);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(120, 45);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(6, 110);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(120, 45);
            this.buttonAnnuler.TabIndex = 1;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.tbName);
            this.groupBoxName.Location = new System.Drawing.Point(6, 19);
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
            this.groupBoxNaissance.Location = new System.Drawing.Point(212, 19);
            this.groupBoxNaissance.Name = "groupBoxNaissance";
            this.groupBoxNaissance.Size = new System.Drawing.Size(200, 38);
            this.groupBoxNaissance.TabIndex = 1;
            this.groupBoxNaissance.TabStop = false;
            this.groupBoxNaissance.Text = "Date Naissance ::";
            // 
            // groupBoxPrenom
            // 
            this.groupBoxPrenom.Controls.Add(this.tbPrenom);
            this.groupBoxPrenom.Location = new System.Drawing.Point(6, 63);
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
            // panelImg
            // 
            this.panelImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImg.Controls.Add(this.btnImage);
            this.panelImg.Controls.Add(this.pictureBoxCover);
            this.panelImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImg.Location = new System.Drawing.Point(3, 16);
            this.panelImg.Name = "panelImg";
            this.panelImg.Size = new System.Drawing.Size(180, 180);
            this.panelImg.TabIndex = 1;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(94, 154);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(83, 23);
            this.btnImage.TabIndex = 3;
            this.btnImage.Text = "Choisir Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackgroundImage = global::IHM.Properties.Resources.Friend;
            this.pictureBoxCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCover.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxCover.TabIndex = 4;
            this.pictureBoxCover.TabStop = false;
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
            // PersonneAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 200);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonneAddForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonneAddForm_FormClosing);
            this.Load += new System.EventHandler(this.PersonneAddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxContent.ResumeLayout(false);
            this.groupBoxBtn.ResumeLayout(false);
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.groupBoxNaissance.ResumeLayout(false);
            this.groupBoxPrenom.ResumeLayout(false);
            this.groupBoxPrenom.PerformLayout();
            this.panelImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxContent;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.GroupBox groupBoxBtn;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBoxNaissance;
        private System.Windows.Forms.GroupBox groupBoxPrenom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Panel panelImg;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.DateTimePicker dateTimeNaissance;
    }
}
