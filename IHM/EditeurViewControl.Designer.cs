namespace IHM
{
    partial class EditeurViewControl
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
            this.panelImg = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelConten = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panelColor.SuspendLayout();
            this.panelConten.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(5, 5);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nom : ... ... ...";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // panelImg
            // 
            this.panelImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImg.Location = new System.Drawing.Point(0, 0);
            this.panelImg.Margin = new System.Windows.Forms.Padding(5);
            this.panelImg.Name = "panelImg";
            this.panelImg.Padding = new System.Windows.Forms.Padding(5);
            this.panelImg.Size = new System.Drawing.Size(70, 70);
            this.panelImg.TabIndex = 3;
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.btnInfo);
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelColor.Location = new System.Drawing.Point(275, 0);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(25, 70);
            this.panelColor.TabIndex = 4;
            // 
            // panelConten
            // 
            this.panelConten.Controls.Add(this.labelName);
            this.panelConten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConten.Location = new System.Drawing.Point(70, 0);
            this.panelConten.Name = "panelConten";
            this.panelConten.Size = new System.Drawing.Size(205, 70);
            this.panelConten.TabIndex = 5;
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInfo.Location = new System.Drawing.Point(0, 50);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(25, 20);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "...";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // EditeurViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelConten);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panelImg);
            this.Name = "EditeurViewControl";
            this.Size = new System.Drawing.Size(300, 70);
            this.panelColor.ResumeLayout(false);
            this.panelConten.ResumeLayout(false);
            this.panelConten.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelImg;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel panelConten;
    }
}
