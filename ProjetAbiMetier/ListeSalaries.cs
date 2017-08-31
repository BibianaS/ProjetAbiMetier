/***********************************************************************
 * Module:  ListeSalaries.cs
 * Author:  CDI14
 * Purpose: Definition of the Class ListeSalaries
 ***********************************************************************/

using System;

public class ListeSalaries
{
   public System.Collections.Generic.List<Collaborateur> listeCollaborateurs;
   

   
   /// <pdGenerated>default setter</pdGenerated>
   public void Ajouter (Collaborateur unCOllaborateur)
   {
        listeCollaborateurs.Add(unCOllaborateur);
   }

    public void Modifier(Collaborateur unCollaborateur) { }
   

}