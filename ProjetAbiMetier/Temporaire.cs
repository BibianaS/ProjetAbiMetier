/***********************************************************************
 * Module:  Classe6.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Classe6
 ***********************************************************************/

using System;

public abstract class Temporaire : Contrat
{
   public Temporaire(date dateDeb, DateTime dateFin, String qualification, String statut, String motif)
   {
      // TODO: implement
   }
   
   public override String ToString()
   {
      // TODO: implement
      return null;
   }

   private String Motif;

   public String _Motif
   {
      get
      {
         return Motif;
      }
      set
      {
         if (this.Motif != value)
            this.Motif = value;
      }
   }

}