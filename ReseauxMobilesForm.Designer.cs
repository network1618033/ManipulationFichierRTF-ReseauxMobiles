namespace ReseauxMobiles
{
    partial class ReseauxMobilesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReseauxMobilesForm));
            this.ReseauxMobilesMenuStrip = new System.Windows.Forms.MenuStrip();
            this.policesToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.listeCoursRichTextBox = new System.Windows.Forms.RichTextBox();
            this.imprimerButton = new System.Windows.Forms.Button();
            this.rechercheGroupBox = new System.Windows.Forms.GroupBox();
            this.rechercheTypeDeCoursLabel = new System.Windows.Forms.Label();
            this.rechercheAfficherNombreDeCoursButton = new System.Windows.Forms.Button();
            this.rechercheTexteARechercherTextBox = new System.Windows.Forms.TextBox();
            this.reseauxMobilesPictureBox = new System.Windows.Forms.PictureBox();
            this.titreRichTextBoxLabel = new System.Windows.Forms.Label();
            this.ReseauxMobilesPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.ReseauxMobilesPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.ReseauxMobilesMenuStrip.SuspendLayout();
            this.rechercheGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reseauxMobilesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ReseauxMobilesMenuStrip
            // 
            this.ReseauxMobilesMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ReseauxMobilesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.policesToolStripComboBox});
            this.ReseauxMobilesMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ReseauxMobilesMenuStrip.Name = "ReseauxMobilesMenuStrip";
            this.ReseauxMobilesMenuStrip.Size = new System.Drawing.Size(754, 32);
            this.ReseauxMobilesMenuStrip.TabIndex = 0;
            this.ReseauxMobilesMenuStrip.Text = "menuStrip1";
            // 
            // policesToolStripComboBox
            // 
            this.policesToolStripComboBox.Name = "policesToolStripComboBox";
            this.policesToolStripComboBox.Size = new System.Drawing.Size(121, 28);
            this.policesToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.PolicesToolStripComboBox_SelectedIndexChanged);
            // 
            // listeCoursRichTextBox
            // 
            this.listeCoursRichTextBox.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeCoursRichTextBox.HideSelection = false;
            this.listeCoursRichTextBox.Location = new System.Drawing.Point(31, 308);
            this.listeCoursRichTextBox.Name = "listeCoursRichTextBox";
            this.listeCoursRichTextBox.Size = new System.Drawing.Size(688, 167);
            this.listeCoursRichTextBox.TabIndex = 1;
            this.listeCoursRichTextBox.Text = "";
            // 
            // imprimerButton
            // 
            this.imprimerButton.Location = new System.Drawing.Point(31, 484);
            this.imprimerButton.Name = "imprimerButton";
            this.imprimerButton.Size = new System.Drawing.Size(688, 40);
            this.imprimerButton.TabIndex = 2;
            this.imprimerButton.Text = "Imprimer la liste des cours";
            this.imprimerButton.UseVisualStyleBackColor = true;
            this.imprimerButton.Click += new System.EventHandler(this.ImprimerButton_Click);
            // 
            // rechercheGroupBox
            // 
            this.rechercheGroupBox.Controls.Add(this.rechercheTypeDeCoursLabel);
            this.rechercheGroupBox.Controls.Add(this.rechercheAfficherNombreDeCoursButton);
            this.rechercheGroupBox.Controls.Add(this.rechercheTexteARechercherTextBox);
            this.rechercheGroupBox.Location = new System.Drawing.Point(31, 531);
            this.rechercheGroupBox.Name = "rechercheGroupBox";
            this.rechercheGroupBox.Size = new System.Drawing.Size(688, 149);
            this.rechercheGroupBox.TabIndex = 3;
            this.rechercheGroupBox.TabStop = false;
            this.rechercheGroupBox.Text = "Recherche : ";
            // 
            // rechercheTypeDeCoursLabel
            // 
            this.rechercheTypeDeCoursLabel.AutoSize = true;
            this.rechercheTypeDeCoursLabel.Location = new System.Drawing.Point(23, 32);
            this.rechercheTypeDeCoursLabel.Name = "rechercheTypeDeCoursLabel";
            this.rechercheTypeDeCoursLabel.Size = new System.Drawing.Size(315, 17);
            this.rechercheTypeDeCoursLabel.TabIndex = 2;
            this.rechercheTypeDeCoursLabel.Text = "Type de cours recherché (Théorie ou Pratique) :";
            // 
            // rechercheAfficherNombreDeCoursButton
            // 
            this.rechercheAfficherNombreDeCoursButton.Location = new System.Drawing.Point(26, 94);
            this.rechercheAfficherNombreDeCoursButton.Name = "rechercheAfficherNombreDeCoursButton";
            this.rechercheAfficherNombreDeCoursButton.Size = new System.Drawing.Size(642, 45);
            this.rechercheAfficherNombreDeCoursButton.TabIndex = 1;
            this.rechercheAfficherNombreDeCoursButton.Text = "Afficher le nombre de cours";
            this.rechercheAfficherNombreDeCoursButton.UseVisualStyleBackColor = true;
            this.rechercheAfficherNombreDeCoursButton.Click += new System.EventHandler(this.RechercheAfficherNombreDeCoursButton_Click);
            // 
            // rechercheTexteARechercherTextBox
            // 
            this.rechercheTexteARechercherTextBox.Location = new System.Drawing.Point(26, 52);
            this.rechercheTexteARechercherTextBox.Name = "rechercheTexteARechercherTextBox";
            this.rechercheTexteARechercherTextBox.Size = new System.Drawing.Size(642, 22);
            this.rechercheTexteARechercherTextBox.TabIndex = 0;
            // 
            // reseauxMobilesPictureBox
            // 
            this.reseauxMobilesPictureBox.Image = global::ReseauxMobiles.Properties.Resources.reseauxmobiles;
            this.reseauxMobilesPictureBox.Location = new System.Drawing.Point(208, 44);
            this.reseauxMobilesPictureBox.Name = "reseauxMobilesPictureBox";
            this.reseauxMobilesPictureBox.Size = new System.Drawing.Size(343, 232);
            this.reseauxMobilesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reseauxMobilesPictureBox.TabIndex = 4;
            this.reseauxMobilesPictureBox.TabStop = false;
            // 
            // titreRichTextBoxLabel
            // 
            this.titreRichTextBoxLabel.AutoSize = true;
            this.titreRichTextBoxLabel.Location = new System.Drawing.Point(31, 288);
            this.titreRichTextBoxLabel.Name = "titreRichTextBoxLabel";
            this.titreRichTextBoxLabel.Size = new System.Drawing.Size(336, 17);
            this.titreRichTextBoxLabel.TabIndex = 5;
            this.titreRichTextBoxLabel.Text = "Type de cours : (sélection indique le cours de base)";
            // 
            // ReseauxMobilesPrintDocument
            // 
            this.ReseauxMobilesPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ReseauxMobilesPrintDocument_PrintPage);
            // 
            // ReseauxMobilesPrintPreviewDialog
            // 
            this.ReseauxMobilesPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ReseauxMobilesPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ReseauxMobilesPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.ReseauxMobilesPrintPreviewDialog.Document = this.ReseauxMobilesPrintDocument;
            this.ReseauxMobilesPrintPreviewDialog.Enabled = true;
            this.ReseauxMobilesPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("ReseauxMobilesPrintPreviewDialog.Icon")));
            this.ReseauxMobilesPrintPreviewDialog.Name = "ReseauxMobilesPrintPreviewDialog";
            this.ReseauxMobilesPrintPreviewDialog.Visible = false;
            // 
            // ReseauxMobilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 722);
            this.Controls.Add(this.titreRichTextBoxLabel);
            this.Controls.Add(this.reseauxMobilesPictureBox);
            this.Controls.Add(this.rechercheGroupBox);
            this.Controls.Add(this.imprimerButton);
            this.Controls.Add(this.listeCoursRichTextBox);
            this.Controls.Add(this.ReseauxMobilesMenuStrip);
            this.MainMenuStrip = this.ReseauxMobilesMenuStrip;
            this.Name = "ReseauxMobilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cours de Réseaux Mobiles";
            this.Load += new System.EventHandler(this.ReseauxMobilesForm_Load);
            this.ReseauxMobilesMenuStrip.ResumeLayout(false);
            this.ReseauxMobilesMenuStrip.PerformLayout();
            this.rechercheGroupBox.ResumeLayout(false);
            this.rechercheGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reseauxMobilesPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ReseauxMobilesMenuStrip;
        private System.Windows.Forms.ToolStripComboBox policesToolStripComboBox;
        private System.Windows.Forms.RichTextBox listeCoursRichTextBox;
        private System.Windows.Forms.Button imprimerButton;
        private System.Windows.Forms.GroupBox rechercheGroupBox;
        private System.Windows.Forms.Button rechercheAfficherNombreDeCoursButton;
        private System.Windows.Forms.TextBox rechercheTexteARechercherTextBox;
        private System.Windows.Forms.PictureBox reseauxMobilesPictureBox;
        private System.Windows.Forms.Label rechercheTypeDeCoursLabel;
        private System.Windows.Forms.Label titreRichTextBoxLabel;
        private System.Drawing.Printing.PrintDocument ReseauxMobilesPrintDocument;
        private System.Windows.Forms.PrintPreviewDialog ReseauxMobilesPrintPreviewDialog;
    }
}

