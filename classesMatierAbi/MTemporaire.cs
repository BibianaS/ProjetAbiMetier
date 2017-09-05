/***********************************************************************
 * Module:  Classe6.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Classe6
 ***********************************************************************/

using System;

namespace ABI
{
    public abstract class MTemporaire : MContrat
    {
        private String motif = null;
        private String mission = null;

        /// <summary>
        /// Constructeur avec Motif liee au CDD 
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        public MTemporaire(Int32 numContrat, String qualification, String statut, Decimal salaireBrut, DateTime dateDebut, DateTime dateFin, String motif) : base(numContrat, qualification, statut, salaireBrut, dateDebut, dateFin)
        {
            this.Motif = motif;
        }

        /// <summary>
        /// Constructeur avec Motif liee Interim
        /// </summary>
        /// <param name="numContrat"></param>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        public MTemporaire(Int32 numContrat, String qualification, String statut, DateTime dateDebut, DateTime dateFin, String motif) : base(numContrat, qualification, statut, dateDebut, dateFin)
        {
            this.Motif = motif;
        }

        /// <summary>
        /// Constructeur avec Mission liee au stagiaire
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        /// <param name="mission"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        public MTemporaire(Int32 numContrat, String qualification, String statut, Decimal salaireBrut, String mission, DateTime dateDebut, DateTime dateFin) : base(numContrat, qualification, statut, salaireBrut, dateDebut, dateFin)
        {
            this.Mission = mission;
        }

        /// <summary>
        /// Constructeur qui prend en compte un motif et une mission
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="mission"></param>
        /// <param name="motif"></param>
        public MTemporaire(Int32 numContrat, String qualification, String statut, Decimal salaireBrut, DateTime dateDebut, DateTime dateFin, String mission, String motif) : base(numContrat, qualification, statut, salaireBrut, dateDebut, dateFin)
        {
            this.Mission = mission;
            this.Motif = motif;
        }

        /// <summary>
        /// Propriete du motif du contrat li�e au CDD et Interim 
        /// </summary>
        public string Motif
        {
            get
            {
                return this.motif;
            }

            set
            {
                this.motif = value;
            }
        }

        /// <summary>
        /// Propriete de la mission du contrat li�e au stagiaire
        /// </summary>
        public string Mission
        {
            get
            {
                return this.mission;
            }

            set
            {
                this.mission = value;
            }
        }

        /// <summary>
        /// Propriete qui decrit le contrat temporaire
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            // TODO: implement
            return base.ToString() + ". Motif du contrat : " + Motif + ".";
        }

    }
}