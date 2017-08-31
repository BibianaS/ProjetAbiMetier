/***********************************************************************
 * Module:  ListeSalaries.cs
 * Author:  CDI14
 * Purpose: Definition of the Class ListeSalaries
 ***********************************************************************/

using System;
using System.Collections;
namespace ABI
{
    public class MListeCollaborateurs
    {
        public System.Collections.Generic.List<MCollaborateur> listeCollaborateurs;

        /// <pdGenerated>default setter</pdGenerated>
        public void Ajouter(MCollaborateur unCOllaborateur)
        {
            listeCollaborateurs.Add(unCOllaborateur);
        }

        public void Modifier(MCollaborateur unCollaborateur) { }
    }
}