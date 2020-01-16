/*
 * Programmeur  :   Jonathan ZOGONA
 * Date         :   31 Octobre 2019
 * 
 * 
 * Solution     :   ReseauxMobiles.sln
 * Projet       :   ReseauxMobiles.csproj
 * Classe       :   ReseauxMobilesGenerale.cs
 * 
 * 
 * But          :   Apprendre à manipuler les fichiers RTF en C#.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ce = ReseauxMobiles.ReseauxMobilesGenerale.CEMessages;

namespace ReseauxMobiles
{
    class ReseauxMobilesGenerale
    {
        #region Champs

        public static string[] tableauMessagesString = new string[6];

        #endregion

        #region Enumerations

        public enum CEMessages
        {
            chargementFicherErreur,
            changementFontErreur,
            rechercheErreur,
            initialisationPolicesErreur,
            measureItemErreur,
            drawItemErreur
        }

        #endregion

        #region Initialiser messages d'erreurs

        public static void InitialiserMessageDErreurs()
        {
            tableauMessagesString[(int)ce.chargementFicherErreur] = "Une erreur est survenue lors du chargement du fichier RTF";
            tableauMessagesString[(int)ce.rechercheErreur] = "Une erreur est survenue lors de la recherche dans le richTextBox";
            tableauMessagesString[(int)ce.initialisationPolicesErreur] = "Une erreur est survenue lors de l'initialisation des polices";
            tableauMessagesString[(int)ce.changementFontErreur] = "Une erreur est survenue lors de changement de police dans le richTextBox";
            tableauMessagesString[(int)ce.measureItemErreur] = "Une erreur est survenue lors de la mesure de la police MeasureItem";
            tableauMessagesString[(int)ce.drawItemErreur] = "Une erreur est survenue lors du dessin de la police DrawItem";
        }

        #endregion
    }

}
