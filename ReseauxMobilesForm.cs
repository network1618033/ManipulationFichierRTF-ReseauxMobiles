/*
 * Programmeur  :   Jonathan ZOGONA
 * Date         :   31 Octobre 2019
 * 
 * 
 * Solution     :   ReseauxMobiles.sln
 * Projet       :   ReseauxMobiles.csproj
 * Classe       :   ReseauxMobilesForm.cs
 * 
 * 
 * But          :   Apprendre à manipuler les fichiers RTF en C#.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Text;

using g = ReseauxMobiles.ReseauxMobilesGenerale;
using ce = ReseauxMobiles.ReseauxMobilesGenerale.CEMessages;

namespace ReseauxMobiles
{
    public partial class ReseauxMobilesForm : Form
    {
        #region Champs

        private const string COURSE_FILE_PATH_CONST_STRING = @"../../Data/Cours.rtf";
        private const string DEFAULT_SELECTION_CONST_STRING = "Types de réseaux mobiles.";
        private ComboBox myComboBox;

        #endregion

        #region Initialisation et Chargement du formulaire

        #region Initialisation du formulaire

        public ReseauxMobilesForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Chargement du formulaire

        private void ReseauxMobilesForm_Load(object sender, EventArgs e)
        {
            // Messages d'erreur
            g.InitialiserMessageDErreurs();


            // Combobox Polices
            policesToolStripComboBox.SelectedIndexChanged -= PolicesToolStripComboBox_SelectedIndexChanged;

            myComboBox = policesToolStripComboBox.ComboBox;
            myComboBox.DisplayMember = "Name";
            myComboBox.ItemHeight = 20;
            myComboBox.DrawMode = DrawMode.OwnerDrawVariable;

            myComboBox.DrawItem += MyComboBox_DrawItem;
            myComboBox.MeasureItem += MyComboBox_MeasureItem;

            InitialiserPolices();
            policesToolStripComboBox.SelectedIndexChanged += PolicesToolStripComboBox_SelectedIndexChanged;


            // Chargement du fichier
            ChargerFichierRTF();

            // Configuration de l'impression
            ReseauxMobilesPrintPreviewDialog.WindowState = FormWindowState.Maximized;
            ReseauxMobilesPrintDocument.DefaultPageSettings.Landscape = true;
            ReseauxMobilesPrintPreviewDialog.UseAntiAlias = true;
            ReseauxMobilesPrintPreviewDialog.PrintPreviewControl.Zoom = 2.0;
        }

        #endregion

        #endregion

        #region Changer la police du RichTextBox

        private void PolicesToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                Font oPolice = listeCoursRichTextBox.Font;
                listeCoursRichTextBox.Font = new Font(policesToolStripComboBox.Text, oPolice.Size, oPolice.Style);
            }
            catch(Exception ex)
            {
                MessageBox.Show(g.tableauMessagesString[(int)ce.changementFontErreur] +
                   " : \n\n" + ex.ToString());
            }               
        }

        #endregion

        #region Remplir ComboBox avec les polices installer

        #region DrawItem

        private void MyComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {

            try
            {
                Graphics g = e.Graphics;

                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                e.DrawBackground();

                if ((e.State & DrawItemState.Focus) != 0)
                    e.DrawFocusRectangle();

                g.DrawString(((Font)myComboBox.Items[e.Index]).Name, (Font)myComboBox.Items[e.Index], Brushes.Black, e.Bounds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(g.tableauMessagesString[(int)ce.drawItemErreur] +
                   " : \n\n" + ex.ToString());
            }

        }

        #endregion

        #region MeasureItem
        private void MyComboBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            try
            {
                ComboBox oComboBox = sender as ComboBox;
                int lastIndex = oComboBox.Items.Count - 1;
                Font oFont = oComboBox.Items[lastIndex] as Font;
                float size = e.Graphics.MeasureString(oFont.Name, oFont).Width;

                if (size > myComboBox.DropDownWidth)
                    oComboBox.DropDownWidth = (int)(size + 1);
                oComboBox.Width = oComboBox.DropDownWidth;
            }
            catch (Exception ex)
            {
                MessageBox.Show(g.tableauMessagesString[(int)ce.measureItemErreur] +
                   " : \n\n" + ex.ToString());
            }

        }

        #endregion

        #region Afficher Polices        

        private void InitialiserPolices()
        {
            myComboBox.Font = new Font("Microsoft Sans Serif", 11.25F);
            try
            {
                Font oFont = null;
                InstalledFontCollection polices = new InstalledFontCollection();
                List<Font> orderedPolices = new List<Font>();

                foreach (FontFamily oPolice in polices.Families)
                {
                    if (oPolice.IsStyleAvailable(FontStyle.Regular))
                        oFont = new Font(oPolice, 12.0F, FontStyle.Regular);

                    orderedPolices.Add(oFont);
                }
                orderedPolices.Reverse();
                policesToolStripComboBox.Items.AddRange(orderedPolices.ToArray());
            }
            catch(Exception ex)
            {
                MessageBox.Show(g.tableauMessagesString[(int)ce.initialisationPolicesErreur] +
                   " : \n\n" + ex.ToString());
            }

            

            //try
            //{
            //    Font oFont = null;

            //    FontCollection oPolicesInstallees = new InstalledFontCollection();

            //    foreach (FontFamily oPolice in oPolicesInstallees.Families)
            //    {
            //        if (oPolice.IsStyleAvailable(FontStyle.Regular))
            //            oFont = new Font(oPolice, 12.0F, FontStyle.Regular);

            //        myComboBox.Items.Add(oFont);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        #endregion

        #endregion

        #region Charger le fichier RTF dans le RichTextBox

        private void ChargerFichierRTF()
        {
            try
            {
                listeCoursRichTextBox.LoadFile(COURSE_FILE_PATH_CONST_STRING);
                listeCoursRichTextBox.Find(DEFAULT_SELECTION_CONST_STRING, 0, RichTextBoxFinds.None);
            }
            catch(Exception ex)
            {
                MessageBox.Show(g.tableauMessagesString[(int)ce.chargementFicherErreur] + 
                    " : \n\n" + ex.ToString());
            }
        }

        #endregion

        #region Imprimer le formulaire

        #region Imprimer Click

        private void ImprimerButton_Click(object sender, EventArgs e)
        {
            ReseauxMobilesPrintPreviewDialog.ShowDialog();
        }

        #endregion

        #region PrintPage
        private void ReseauxMobilesPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Variables usuelles
            Graphics g = e.Graphics;
            Single largeurPageSingle = e.PageBounds.Width;

            // Definitions de polices
            Font enteteFont = new Font("Segoe Print", 24.0F, FontStyle.Bold | FontStyle.Italic);
            Font enteteDetailFont = new Font("Arial", 14.0F, FontStyle.Bold);
            Font detailFont = new Font("Courier New", 12.0F, FontStyle.Regular);

            // Recuperation des tailles des différentes polices
            Single hauteurPoliceEnteteSingle = enteteFont.GetHeight();
            Single hauteurPoliceEnteteDetailSingle = enteteDetailFont.GetHeight();
            Single hauteurPoliceDetailSingle = detailFont.GetHeight();

            // Définition de la valeur du titre (Entete)
            string titreString = "Cours de Réseaux Mobiles";

            // Largeur du titre
            Single largeurTitreSingle = g.MeasureString(titreString, enteteFont).Width;

            // Image à imprimer
            Image impressionImage = reseauxMobilesPictureBox.Image;

            // Mesure de l'image
            Single largeurImageSingle = (impressionImage.Width / impressionImage.HorizontalResolution) * 100.0F;
            Single hauteurImageSingle = (impressionImage.Height / impressionImage.VerticalResolution) * 100.0F;

            // Positionnement du crayon
            Single xSingle = (largeurPageSingle - largeurImageSingle) / 2;
            Single ySingle = e.MarginBounds.Y;

            // Dessiner l'image
            g.DrawImage(impressionImage, xSingle, ySingle);

            // Repositionnement du crayon
            xSingle = (largeurPageSingle - largeurTitreSingle) / 2;
            ySingle += hauteurImageSingle * 1.15F;

            // Dessin du titre
            g.DrawString(titreString, enteteFont, Brushes.BurlyWood, xSingle, ySingle);

            // Repositionnement du crayon
            ySingle += hauteurPoliceEnteteSingle;

            // Dessin de la ligne de soulignement
            g.DrawLine(new Pen(Brushes.BurlyWood, 4.0F), xSingle, ySingle, xSingle + largeurTitreSingle, ySingle);

            // Repositionnement du crayon
            ySingle += hauteurPoliceEnteteSingle * 1.1F;
            xSingle = e.MarginBounds.X;

            // Dessin de l'entete des détails
            string enteteDetailString = String.Format("{0, 4} {1, 24}", "Type", "Cours");
            g.DrawString(enteteDetailString, enteteDetailFont, Brushes.Black, xSingle, ySingle);

            // Repositionnement du crayon
            ySingle += hauteurPoliceDetailSingle * 2.0F;

            // Dessin
            string detailString = listeCoursRichTextBox.Text;

            g.DrawString(detailString, detailFont, Brushes.Blue, xSingle, ySingle);


        }

        #endregion

        #endregion

        #region Recherche

        private void RechercheAfficherNombreDeCoursButton_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rtb = listeCoursRichTextBox;

                string mot = rechercheTexteARechercherTextBox.Text.Trim();

                int nombreDeMot = 0;
                if(rtb.Text.Length != 0 && mot != string.Empty)
                {
                    for (int depart = 0; 
                        rtb.Find(mot, depart, RichTextBoxFinds.None) != -1;
                        depart = rtb.SelectionStart + 1)
                    {
                        nombreDeMot++;
                    }

                    rtb.SelectionLength = 0;
                    MessageBox.Show("Nombre de mots du cours = " + nombreDeMot);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(g.tableauMessagesString[(int)ce.rechercheErreur] +
                    " : \n\n" + ex.ToString());
            }
        }

        #endregion
    }
}
