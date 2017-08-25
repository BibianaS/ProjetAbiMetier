/***********************************************************************
 * Module:  Cdi.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Cdi
 ***********************************************************************/

using System;

public class Cdi : Contrat
{
    
    public Cdi(String qualification, String statut, Int32 jour, Int32 anne, Int32 mois,Decimal salaireBrut) : base (qualification, statut, jour, anne, mois, salaireBrut)
   {
      
   }
   
   public override String ToString()
   {
      // TODO: implement
      return null;
   }

  

}