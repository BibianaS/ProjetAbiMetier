/***********************************************************************
 * Module:  Collaborateur.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Collaborateur
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace ABI
{

    public class MCollaborateur
    {
        private Int32 matricule;
        private String prenomCollabo;
        private String nomCollabo;
        private string photoCollabo;
        private String numeroSS;
        private String statutCollaborateur;
        private System.Collections.Generic.SortedDictionary<Int32, MContrat> Contrats;
        private System.Data.DataTable dtContrats;
        private Int32 quantiteContrats = 0;

        public MCollaborateur(Int32 Matricule, String prenom, String nom, String numeroSS, String statut)
        {
            this.PrenomCollabo = prenom;
            this.NomCollabo = nom;
            this.NumeroSS = numeroSS;
            this.StatutCollaborateur = statut;
            this.Matricule = Matricule;

            Contrats = new SortedDictionary<Int32, MContrat>();
            dtContrats = new System.Data.DataTable();
            dtContrats.Columns.Add("Num Contrat", typeof(Int32));
            dtContrats.Columns.Add("Qualification", typeof(String));
            dtContrats.Columns.Add("Statut", typeof(String));
            dtContrats.Columns.Add("Date Debut", typeof(DateTime));
        }

        /// <summary>
        /// Propriete Matricule
        /// </summary>
      

        /// <summary>
        /// Propriete prenom du collaborateur
        /// </summary>

        public String PrenomCollabo
        {
            get
            {
                return this.PrenomCollabo;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Merci de reinseigner un Pr�nom");
                }
                else
                {
                    this.prenomCollabo = value.Trim().ToLower();
                }

            }
        }

        /// <summary>
        /// Propriete Nom du collaborateur
        /// </summary>
        public String NomCollabo
        {
            get
            {
                return nomCollabo;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Merci de reinseigner un Nom");
                }
                else
                {
                    nomCollabo = value.Trim().ToUpper();
                }
            }
        }
        
        public string PhotoCollabo
        {
            get
            {
                return photoCollabo;
            }
            set
            {
                if (this.photoCollabo != value)
                    this.photoCollabo = value;
            }
        }


        //TODO
        //CHANGER LE NOMBRE DE NUMEROS A 13


        /// <summary>
        /// Propriete du Securite sociale
        /// </summary>
        public String NumeroSS
        {
            get
            {
                return this.numeroSS;
            }
            set
            {
                // l'appelant doit fournir un code postal valide � 13 chiffres
                Int32 i;               // variable  de boucle
                Boolean erreur = false; // indicateur erreur
                if (value.Length == 3) // 5 car. attendus : OK ==> contr�ler un � un
                {
                    for (i = 0; i < value.Length; i++)  // controle chiffres par boucle
                    {
                        if (!(Char.IsDigit(value[i]))) // charabia ??
                        { erreur = true; }

                    } // fin de boucle controle chiffres
                    if (erreur) //on a rencontre un non-chiffre
                    {
                        // lev�e d'exception
                        throw new Exception(value.ToString() + "\n" + "n'est pas un numero valide : uniquement des chiffres");
                    }
                    else
                    {
                        this.numeroSS = value;  // tout est bon, on affecte la propri�t�
                    }
                }
                else // il n'y a pas 13 caract�res
                {
                    // lev�e d'exception
                    throw new Exception(value.ToString() + "\n" + "n'est pas un numero de SS valide : 3 chiffres, pas plus, pas moins");
                }

            }
        }

        /// <summary>
        /// Propriete qui define le statud d'un commaborateur
        /// Actif ou inactif
        /// </summary>
        public String StatutCollaborateur
        {
            get
            {
                return statutCollaborateur;
            }
            set
            {
                this.statutCollaborateur = value;
            }
        }

        public int Matricule
        {
            get
            {
                return matricule;
            }

            set
            {
                matricule = value;
            }
        }

        public int QuantiteContrats
        {
            get
            {
                return quantiteContrats;
            }
        }

        public void AjouterContrat(MContrat unContrat)
        {
            if (Contrats.ContainsKey(unContrat.NumeroContrat) || unContrat.NumeroContrat == 0)
            {
                throw new Exception("Le numero de contrat existe deja ou il est de valeur 0");
            }
            else
            {
                Contrats.Add(unContrat.NumeroContrat, unContrat);
                quantiteContrats += 1;
            }
        }
        
        public void ModifierContrat(MContrat unContrat)
        {

        }

        public MContrat RestituerContrat(Int32 numContrat)
        {
            return Contrats[numContrat];
        }

        public void AjouterContratListe(MContrat unContrat)
        {
             Contrats.Add(unContrat.NumeroContrat, unContrat);
        }

        public System.Data.DataTable ListerContrats()
        {
            foreach(MContrat unContrat in this.Contrats.Values)
            {
                dtContrats.Rows.Add(unContrat.NumeroContrat, unContrat.Qualification, unContrat.Statut, unContrat.DateDebut);
            }
            return dtContrats;
        }

        public override String ToString()
        {
            // TODO: implement
            return "Matricule : " + Matricule + ". Nom : " + NomCollabo + ". Prenom : " + PrenomCollabo;
        }
    }
}