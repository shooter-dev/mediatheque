namespace IHM
{
    partial class FormIndex
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelBtnMenu = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPersonneMod = new System.Windows.Forms.Button();
            this.btnPersonneAdd = new System.Windows.Forms.Button();
            this.btnPersonne = new System.Windows.Forms.Button();
            this.btnPersonneSup = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLivreMod = new System.Windows.Forms.Button();
            this.btnLivreAdd = new System.Windows.Forms.Button();
            this.btnLivre = new System.Windows.Forms.Button();
            this.btnLivreSup = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSerieMod = new System.Windows.Forms.Button();
            this.btnSerieAdd = new System.Windows.Forms.Button();
            this.btnSerie = new System.Windows.Forms.Button();
            this.btnSerieSup = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditionMod = new System.Windows.Forms.Button();
            this.btnEditionAdd = new System.Windows.Forms.Button();
            this.btnEdition = new System.Windows.Forms.Button();
            this.btnEditionSup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenreMod = new System.Windows.Forms.Button();
            this.btnGenreAdd = new System.Windows.Forms.Button();
            this.btnGenre = new System.Windows.Forms.Button();
            this.btnGenreSup = new System.Windows.Forms.Button();
            this.panelFoot = new System.Windows.Forms.Panel();
            this.btnParam = new System.Windows.Forms.Button();
            this.progressBarChargement = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnMiniz = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelIndex = new System.Windows.Forms.Label();
            this.panelModif = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelBtnMenu.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelFoot.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelBtnMenu);
            this.panelMenu.Controls.Add(this.panelFoot);
            this.panelMenu.Controls.Add(this.panelInfo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 728);
            this.panelMenu.TabIndex = 0;
            // 
            // panelBtnMenu
            // 
            this.panelBtnMenu.Controls.Add(this.groupBox5);
            this.panelBtnMenu.Controls.Add(this.groupBox4);
            this.panelBtnMenu.Controls.Add(this.groupBox3);
            this.panelBtnMenu.Controls.Add(this.groupBox2);
            this.panelBtnMenu.Controls.Add(this.groupBox1);
            this.panelBtnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtnMenu.Location = new System.Drawing.Point(0, 210);
            this.panelBtnMenu.Name = "panelBtnMenu";
            this.panelBtnMenu.Size = new System.Drawing.Size(200, 437);
            this.panelBtnMenu.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPersonneMod);
            this.groupBox5.Controls.Add(this.btnPersonneAdd);
            this.groupBox5.Controls.Add(this.btnPersonne);
            this.groupBox5.Controls.Add(this.btnPersonneSup);
            this.groupBox5.Location = new System.Drawing.Point(0, 312);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 78);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // btnPersonneMod
            // 
            this.btnPersonneMod.Location = new System.Drawing.Point(69, 48);
            this.btnPersonneMod.Name = "btnPersonneMod";
            this.btnPersonneMod.Size = new System.Drawing.Size(62, 25);
            this.btnPersonneMod.TabIndex = 8;
            this.btnPersonneMod.Text = "Modifier";
            this.btnPersonneMod.UseVisualStyleBackColor = true;
            this.btnPersonneMod.Click += new System.EventHandler(this.btnSousMenu_Click);
            // 
            // btnPersonneAdd
            // 
            this.btnPersonneAdd.Location = new System.Drawing.Point(3, 48);
            this.btnPersonneAdd.Name = "btnPersonneAdd";
            this.btnPersonneAdd.Size = new System.Drawing.Size(62, 25);
            this.btnPersonneAdd.TabIndex = 6;
            this.btnPersonneAdd.Text = "Ajouter";
            this.btnPersonneAdd.UseVisualStyleBackColor = true;
            this.btnPersonneAdd.Click += new System.EventHandler(this.btnSousMenu_Click);
            // 
            // btnPersonne
            // 
            this.btnPersonne.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonne.Location = new System.Drawing.Point(3, 16);
            this.btnPersonne.Name = "btnPersonne";
            this.btnPersonne.Size = new System.Drawing.Size(194, 30);
            this.btnPersonne.TabIndex = 0;
            this.btnPersonne.Text = "Auteurs / Dessinateurs";
            this.btnPersonne.UseVisualStyleBackColor = true;
            this.btnPersonne.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnPersonneSup
            // 
            this.btnPersonneSup.Location = new System.Drawing.Point(135, 48);
            this.btnPersonneSup.Name = "btnPersonneSup";
            this.btnPersonneSup.Size = new System.Drawing.Size(62, 25);
            this.btnPersonneSup.TabIndex = 7;
            this.btnPersonneSup.Text = "Suprimer";
            this.btnPersonneSup.UseVisualStyleBackColor = true;
            this.btnPersonneSup.Click += new System.EventHandler(this.btnSousMenu_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLivreMod);
            this.groupBox4.Controls.Add(this.btnLivreAdd);
            this.groupBox4.Controls.Add(this.btnLivre);
            this.groupBox4.Controls.Add(this.btnLivreSup);
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 78);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // btnLivreMod
            // 
            this.btnLivreMod.Location = new System.Drawing.Point(69, 48);
            this.btnLivreMod.Name = "btnLivreMod";
            this.btnLivreMod.Size = new System.Drawing.Size(62, 25);
            this.btnLivreMod.TabIndex = 8;
            this.btnLivreMod.Text = "Modifier";
            this.btnLivreMod.UseVisualStyleBackColor = true;
            this.btnLivreMod.Click += new System.EventHandler(this.btnSousMenu_Click);
            // 
            // btnLivreAdd
            // 
            this.btnLivreAdd.Location = new System.Drawing.Point(3, 48);
            this.btnLivreAdd.Name = "btnLivreAdd";
            this.btnLivreAdd.Size = new System.Drawing.Size(62, 25);
            this.btnLivreAdd.TabIndex = 6;
            this.btnLivreAdd.Text = "Ajouter";
            this.btnLivreAdd.UseVisualStyleBackColor = true;
            this.btnLivreAdd.Click += new System.EventHandler(this.btnSousMenu_Click);
            // 
            // btnLivre
            // 
            this.btnLivre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLivre.Location = new System.Drawing.Point(3, 16);
            this.btnLivre.Name = "btnLivre";
            this.btnLivre.Size = new System.Drawing.Size(194, 30);
            this.btnLivre.TabIndex = 0;
            this.btnLivre.Text = "Livres";
            this.btnLivre.UseVisualStyleBackColor = true;
            this.btnLivre.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnLivreSup
            // 
            this.btnLivreSup.Location = new System.Drawing.Point(135, 48);
            this.btnLivreSup.Name = "btnLivreSup";
            this.btnLivreSup.Size = new System.Drawing.Size(62, 25);
            this.btnLivreSup.TabIndex = 7;
            this.btnLivreSup.Text = "Suprimer";
            this.btnLivreSup.UseVisualStyleBackColor = true;
            this.btnLivreSup.Click += new System.EventHandler(this.btnSousMenu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSerieMod);
            this.groupBox3.Controls.Add(this.btnSerieAdd);
            this.groupBox3.Controls.Add(this.btnSerie);
            this.groupBox3.Controls.Add(this.btnSerieSup);
            this.groupBox3.Location = new System.Drawing.Point(0, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 78);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // btnSerieMod
            // 
            this.btnSerieMod.Location = new System.Drawing.Point(69, 48);
            this.btnSerieMod.Name = "btnSerieMod";
            this.btnSerieMod.Size = new System.Drawing.Size(62, 25);
            this.btnSerieMod.TabIndex = 8;
            this.btnSerieMod.Text = "Modifier";
            this.btnSerieMod.UseVisualStyleBackColor = true;
            this.btnSerieMod.Click += new System.EventHandler(this.btnSousMenu_Click);
            // 
            // btnSerieAdd
            // 
            this.btnSerieAdd.Location = new System.Drawing.Point(3, 48);
            this.btnSerieAdd.Name = "btnSerieAdd";
            this.btnSerieAdd.Size = new System.Drawing.Size(62, 25);
            this.btnSerieAdd.TabIndex = 6;
            this.btnSerieAdd.Text = "Ajouter";
            this.btnSerieAdd.UseVisualStyleBackColor = true;
            this.btnSerieAdd.Click += new System.EventHandler(this.btnSousMenu_Click);
            // 
            // btnSerie
            // 
            this.btnSerie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSerie.Location = new System.Drawing.Point(3, 16);
            this.btnSerie.Name = "btnSerie";
            this.btnSerie.Size = new System.Drawing.Size(194, 30);
            this.btnSerie.TabIndex = 0;
            this.btnSerie.Text = "Serie";
            this.btnSerie.UseVisualStyleBackColor = true;
            this.btnSerie.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSerieSup
            // 
            this.btnSerieSup.Location = new System.Drawing.Point(135, 48);
            this.btnSerieSup.Name = "btnSerieSup";
            this.btnSerieSup.Size = new System.Drawing.Size(62, 25);
            this.btnSerieSup.TabIndex = 7;
            this.btnSerieSup.Text = "Suprimer";
            this.btnSerieSup.UseVisualStyleBackColor = true;
            this.btnSerieSup.Click += new System.EventHandler(this.btnSousMenu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditionMod);
            this.groupBox2.Controls.Add(this.btnEditionAdd);
            this.groupBox2.Controls.Add(this.btnEdition);
            this.groupBox2.Controls.Add(this.btnEditionSup);
            this.groupBox2.Location = new System.Drawing.Point(0, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 78);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btnEditionMod
            // 
            this.btnEditionMod.Location = new System.Drawing.Point(69, 48);
            this.btnEditionMod.Name = "btnEditionMod";
            this.btnEditionMod.Size = new System.Drawing.Size(62, 25);
            this.btnEditionMod.TabIndex = 8;
            this.btnEditionMod.Text = "Modifier";
            this.btnEditionMod.UseVisualStyleBackColor = true;
            this.btnEditionMod.Click += new System.EventHandler(this.btnSousMenu_Click);
            // 
            // btnEditionAdd
            // 
            this.btnEditionAdd.Location = new System.Drawing.Point(3, 48);
            this.btnEditionAdd.Name = "btnEditionAdd";
            this.btnEditionAdd.Size = new System.Drawing.Size(62, 25);
            this.btnEditionAdd.TabIndex = 6;
            this.btnEditionAdd.Text = "Ajouter";
            this.btnEditionAdd.UseVisualStyleBackColor = true;
            this.btnEditionAdd.Click += new System.EventHandler(this.btnSousMenu_Click);
            // 
            // btnEdition
            // 
            this.btnEdition.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdition.Location = new System.Drawing.Point(3, 16);
            this.btnEdition.Name = "btnEdition";
            this.btnEdition.Size = new System.Drawing.Size(194, 30);
            this.btnEdition.TabIndex = 0;
            this.btnEdition.Text = "Editions";
            this.btnEdition.UseVisualStyleBackColor = true;
            this.btnEdition.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnEditionSup
            // 
            this.btnEditionSup.Location = new System.Drawing.Point(135, 48);
            this.btnEditionSup.Name = "btnEditionSup";
            this.btnEditionSup.Size = new System.Drawing.Size(62, 25);
            this.btnEditionSup.TabIndex = 7;
            this.btnEditionSup.Text = "Suprimer";
            this.btnEditionSup.UseVisualStyleBackColor = true;
            this.btnEditionSup.Click += new System.EventHandler(this.btnSousMenu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenreMod);
            this.groupBox1.Controls.Add(this.btnGenreAdd);
            this.groupBox1.Controls.Add(this.btnGenre);
            this.groupBox1.Controls.Add(this.btnGenreSup);
            this.groupBox1.Location = new System.Drawing.Point(0, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 78);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnGenreMod
            // 
            this.btnGenreMod.Location = new System.Drawing.Point(69, 48);
            this.btnGenreMod.Name = "btnGenreMod";
            this.btnGenreMod.Size = new System.Drawing.Size(62, 25);
            this.btnGenreMod.TabIndex = 8;
            this.btnGenreMod.Text = "Modifier";
            this.btnGenreMod.UseVisualStyleBackColor = true;
            this.btnGenreMod.Click += new System.EventHandler(this.btnSousMenu_Click);
            // 
            // btnGenreAdd
            // 
            this.btnGenreAdd.Location = new System.Drawing.Point(3, 48);
            this.btnGenreAdd.Name = "btnGenreAdd";
            this.btnGenreAdd.Size = new System.Drawing.Size(62, 25);
            this.btnGenreAdd.TabIndex = 6;
            this.btnGenreAdd.Text = "Ajouter";
            this.btnGenreAdd.UseVisualStyleBackColor = true;
            this.btnGenreAdd.Click += new System.EventHandler(this.btnSousMenu_Click);
            // 
            // btnGenre
            // 
            this.btnGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenre.Location = new System.Drawing.Point(3, 16);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(194, 30);
            this.btnGenre.TabIndex = 0;
            this.btnGenre.Text = "Genres";
            this.btnGenre.UseVisualStyleBackColor = true;
            this.btnGenre.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnGenreSup
            // 
            this.btnGenreSup.Location = new System.Drawing.Point(135, 48);
            this.btnGenreSup.Name = "btnGenreSup";
            this.btnGenreSup.Size = new System.Drawing.Size(62, 25);
            this.btnGenreSup.TabIndex = 7;
            this.btnGenreSup.Text = "Suprimer";
            this.btnGenreSup.UseVisualStyleBackColor = true;
            this.btnGenreSup.Click += new System.EventHandler(this.btnSousMenu_Click);
            // 
            // panelFoot
            // 
            this.panelFoot.Controls.Add(this.btnParam);
            this.panelFoot.Controls.Add(this.progressBarChargement);
            this.panelFoot.Controls.Add(this.label2);
            this.panelFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFoot.Location = new System.Drawing.Point(0, 647);
            this.panelFoot.Name = "panelFoot";
            this.panelFoot.Size = new System.Drawing.Size(200, 81);
            this.panelFoot.TabIndex = 1;
            // 
            // btnParam
            // 
            this.btnParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParam.Location = new System.Drawing.Point(0, 0);
            this.btnParam.Name = "btnParam";
            this.btnParam.Size = new System.Drawing.Size(200, 22);
            this.btnParam.TabIndex = 18;
            this.btnParam.Text = "Parametre";
            this.btnParam.UseVisualStyleBackColor = true;
            // 
            // progressBarChargement
            // 
            this.progressBarChargement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarChargement.Location = new System.Drawing.Point(0, 58);
            this.progressBarChargement.Name = "progressBarChargement";
            this.progressBarChargement.Size = new System.Drawing.Size(200, 23);
            this.progressBarChargement.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.labelNameUser);
            this.panelInfo.Controls.Add(this.pictureBoxUser);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(200, 210);
            this.panelInfo.TabIndex = 0;
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameUser.Location = new System.Drawing.Point(40, 178);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(119, 25);
            this.labelNameUser.TabIndex = 1;
            this.labelNameUser.Text = "Name User";
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::IHM.Properties.Resources.Friend;
            this.pictureBoxUser.Location = new System.Drawing.Point(25, 25);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.btnMiniz);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.labelIndex);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(200, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(750, 40);
            this.panelHeader.TabIndex = 1;
            // 
            // btnMiniz
            // 
            this.btnMiniz.Location = new System.Drawing.Point(681, 4);
            this.btnMiniz.Name = "btnMiniz";
            this.btnMiniz.Size = new System.Drawing.Size(30, 30);
            this.btnMiniz.TabIndex = 2;
            this.btnMiniz.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(717, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndex.Location = new System.Drawing.Point(6, 5);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(95, 31);
            this.labelIndex.TabIndex = 0;
            this.labelIndex.Text = "Index \\";
            // 
            // panelModif
            // 
            this.panelModif.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelModif.Location = new System.Drawing.Point(200, 40);
            this.panelModif.Name = "panelModif";
            this.panelModif.Size = new System.Drawing.Size(750, 120);
            this.panelModif.TabIndex = 2;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 160);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(750, 568);
            this.panelContent.TabIndex = 3;
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 728);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelModif);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mangatheque";
            this.Load += new System.EventHandler(this.FormIndex_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelBtnMenu.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panelFoot.ResumeLayout(false);
            this.panelFoot.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBtnMenu;
        private System.Windows.Forms.Panel panelFoot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Button btnMiniz;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.ProgressBar progressBarChargement;
        private System.Windows.Forms.Panel panelModif;
        private System.Windows.Forms.Button btnParam;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPersonneMod;
        private System.Windows.Forms.Button btnPersonneAdd;
        private System.Windows.Forms.Button btnPersonne;
        private System.Windows.Forms.Button btnPersonneSup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLivreMod;
        private System.Windows.Forms.Button btnLivreAdd;
        private System.Windows.Forms.Button btnLivre;
        private System.Windows.Forms.Button btnLivreSup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSerieMod;
        private System.Windows.Forms.Button btnSerieAdd;
        private System.Windows.Forms.Button btnSerie;
        private System.Windows.Forms.Button btnSerieSup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditionMod;
        private System.Windows.Forms.Button btnEditionAdd;
        private System.Windows.Forms.Button btnEdition;
        private System.Windows.Forms.Button btnEditionSup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenreMod;
        private System.Windows.Forms.Button btnGenreAdd;
        private System.Windows.Forms.Button btnGenre;
        private System.Windows.Forms.Button btnGenreSup;
        private System.Windows.Forms.Panel panelContent;
    }
}

