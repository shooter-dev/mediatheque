namespace IHM
{
    partial class PersonneViewControl
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNaissance = new System.Windows.Forms.Label();
            this.panelImg = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panelConten = new System.Windows.Forms.Panel();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.panelImg.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.panelConten.SuspendLayout();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(5, 5);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 16);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nom :  ... ... ...";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(5, 21);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(97, 16);
            this.labelPrenom.TabIndex = 4;
            this.labelPrenom.Text = "Prenom : ... ... ...";
            // 
            // labelNaissance
            // 
            this.labelNaissance.AutoSize = true;
            this.labelNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaissance.Location = new System.Drawing.Point(5, 50);
            this.labelNaissance.Name = "labelNaissance";
            this.labelNaissance.Size = new System.Drawing.Size(110, 16);
            this.labelNaissance.TabIndex = 6;
            this.labelNaissance.Text = "Né le :17/07/2017";
            // 
            // panelImg
            // 
            this.panelImg.Controls.Add(this.pictureBoxCover);
            this.panelImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImg.Location = new System.Drawing.Point(0, 0);
            this.panelImg.MaximumSize = new System.Drawing.Size(70, 70);
            this.panelImg.MinimumSize = new System.Drawing.Size(70, 70);
            this.panelImg.Name = "panelImg";
            this.panelImg.Size = new System.Drawing.Size(70, 70);
            this.panelImg.TabIndex = 7;
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.CadetBlue;
            this.panelColor.Controls.Add(this.btnInfo);
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelColor.Location = new System.Drawing.Point(416, 0);
            this.panelColor.MaximumSize = new System.Drawing.Size(25, 0);
            this.panelColor.MinimumSize = new System.Drawing.Size(25, 70);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(25, 100);
            this.panelColor.TabIndex = 9;
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInfo.Location = new System.Drawing.Point(0, 80);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(25, 20);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "...";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // panelConten
            // 
            this.panelConten.Controls.Add(this.labelPrenom);
            this.panelConten.Controls.Add(this.labelNaissance);
            this.panelConten.Controls.Add(this.labelName);
            this.panelConten.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelConten.Location = new System.Drawing.Point(69, 0);
            this.panelConten.Name = "panelConten";
            this.panelConten.Size = new System.Drawing.Size(347, 70);
            this.panelConten.TabIndex = 10;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.panelImg);
            this.panelDetail.Controls.Add(this.panelConten);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(416, 70);
            this.panelDetail.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 195);
            this.panel1.TabIndex = 16;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCover.Image = global::IHM.Properties.Resources.Friend;
            this.pictureBoxCover.InitialImage = global::IHM.Properties.Resources.Friend;
            this.pictureBoxCover.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBoxCover.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 2;
            this.pictureBoxCover.TabStop = false;
            // 
            // PersonneViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelColor);
            this.Name = "PersonneViewControl";
            this.Size = new System.Drawing.Size(441, 100);
            this.Load += new System.EventHandler(this.PersonneViewControl_Load);
            this.panelImg.ResumeLayout(false);
            this.panelColor.ResumeLayout(false);
            this.panelConten.ResumeLayout(false);
            this.panelConten.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNaissance;
        private System.Windows.Forms.Panel panelImg;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Panel panelConten;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
    }
}
