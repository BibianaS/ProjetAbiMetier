/***********************************************************************
 * Module:  Contrat.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Contrat
 ***********************************************************************/

using System;

public abstract class Contrat
{
   private String dateDebut;
   DateTime date;
   DateTime aujourdhui;
   private static Int32 numeroContrat; 
   private String qualification;
   private String statut;
   private Decimal salaireBrut;

    public Contrat(String qualification, String statut, int jour, int anne, int mois, Decimal salaireBrut)
    {
        this.Qualification = qualification;
        this.Statut = statut;
        this.SalaireBrut = salaireBrut;
        date = new DateTime(anne, mois, jour);
        dateDebut = date.ToString(); 
    }

      
   public String Qualification
   {
      get
      {
         return qualification;
      }
      set
      {
         
      }
   }
   
   public String Statut
   {
      get
      {
         return statut;
      }
      set
      {
      }
   }

    public string DateDebut
    {
        

        get 
        {
            return this.dateDebut;
        }

        set
        {
            aujourdhui = new DateTime();
            Int32 result = DateTime.Compare(date, DateTime.Now);
            if (result > 0)
            {
                throw new Exception("Merci de reinseigner une date future");
            }
            if (result <= 0)
            {
                this.dateDebut = value;
            }
        }
    }

    public Decimal SalaireBrut
    {
        get
        {
            return salaireBrut;
        }

        set
        {
            salaireBrut = value;
        }
    }

    public override String ToString()
    {
        // TODO: implement
        return null;
    }

}