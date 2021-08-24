using System;
using System.Collections.Generic;
using System.Text;

namespace ToolIca.DataBases.ADO
{
    public static class ModusOperandiDB
    {
        /// <summary>
        /// Dans visual studio, créer un projet de type : Projet de Base de donénes SQL Server
        /// </summary>
        public static void CreationProjet() { }
        /// <summary>
        /// ajouter les dossiers suivants : 
        /// - Tables
        /// - Scripts (dont PostDeployment = 1 fichier)
        /// - Views
        /// - StoredProcedures
        /// - ...
        /// </summary>
        public static void MiseEnPlaceDossiers() { }
        /// <summary>
        /// clic droit sur le dossier "tables" -> ajouter -> table...
        /// écrire le code en sql dans la fenetre en bas
        /// </summary>
        public static void CreationTables() { }
        /// <summary>
        /// clic droit sur le dossier "PostDeployment" -> ajouter -> script... 
        /// sélectionner le script de post-deploiement
        /// y écrire les données en sql
        /// </summary>
        public static void PostDeployment() { }
        /// <summary>
        /// clic droit sur le projet -> publier...
        /// "enregistrer le profil permet de retenir les informations.
        /// pour publier une MAJ, il suffira de publier via le profil enregistrer (double clics)
        /// </summary>
        public static void Publication() { }
    }
}
