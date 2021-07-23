using System;
using System.Collections.Generic;
using System.Text;

namespace ToolIca.Geographie
{
    public enum ProvincesBE
    {
        BruxellesCapitale,
        BrabantWallon,
        BrabantFlamand,
        Anvers,
        Limbourg,
        Liege,
        Namur,
        Hainaut,
        Luxembourg,
        FlandreOccidentale,
        FlandreOrientale
    }
    public abstract class AdresseBE
    {
        public string Ville { get; set; }
        public int CodePostal { get; set; }
        public ProvincesBE Province => NomProvince();
        public string Rue { get; set; }
        public string Numero { get; set; }
        
        private ProvincesBE NomProvince()
        {
            switch ((int)(CodePostal / 1000))
            {
                case 1:
                    if (CodePostal <= 1299) { return ProvincesBE.BruxellesCapitale; }
                    if (CodePostal <= 1499) { return ProvincesBE.BrabantWallon; }
                    else { return ProvincesBE.BrabantFlamand; }
                case 2: return ProvincesBE.Anvers;
                case 3:
                    if (CodePostal <= 3499) { return ProvincesBE.BrabantFlamand; }
                    else { return ProvincesBE.Limbourg; }
                case 4: return ProvincesBE.Liege;
                case 5: return ProvincesBE.Namur;
                case 6:
                    if (CodePostal <= 6599) { return ProvincesBE.Hainaut; }
                    else { return ProvincesBE.Luxembourg; }
                case 7: return ProvincesBE.Hainaut;
                case 8: return ProvincesBE.FlandreOccidentale;
                case 9: return ProvincesBE.FlandreOrientale;
                default: throw new Exception("Ce code postal ne correspond a aucune province");
            }
        }

        public override string ToString()
        {
            return "" + Rue + ", " + Numero + "\n" + CodePostal + " " + Ville + "(" + Province + ")";
        }
    }
}
