using System;
using System.Collections.Generic;
using System.Text;
using ToolIca.Enums;

namespace ToolIca.Geographie
{
    public abstract class AdresseBelgique
    {
        public string Ville { get; set; }
        public int CodePostal { get; set; }
        public ProvincesBelgique Province => NomProvince();
        public string Rue { get; set; }
        public string Numero { get; set; }
        
        private ProvincesBelgique NomProvince()
        {
            switch ((int)(CodePostal / 1000))
            {
                case 1:
                    if (CodePostal <= 1299) { return ProvincesBelgique.BruxellesCapitale; }
                    if (CodePostal <= 1499) { return ProvincesBelgique.BrabantWallon; }
                    else { return ProvincesBelgique.BrabantFlamand; }
                case 2: return ProvincesBelgique.Anvers;
                case 3:
                    if (CodePostal <= 3499) { return ProvincesBelgique.BrabantFlamand; }
                    else { return ProvincesBelgique.Limbourg; }
                case 4: return ProvincesBelgique.Liege;
                case 5: return ProvincesBelgique.Namur;
                case 6:
                    if (CodePostal <= 6599) { return ProvincesBelgique.Hainaut; }
                    else { return ProvincesBelgique.Luxembourg; }
                case 7: return ProvincesBelgique.Hainaut;
                case 8: return ProvincesBelgique.FlandreOccidentale;
                case 9: return ProvincesBelgique.FlandreOrientale;
                default: throw new Exception("Ce code postal ne correspond a aucune province");
            }
        }

        public override string ToString()
        {
            return "" + Rue + ", " + Numero + "\n" + CodePostal + " " + Ville + "(" + Province + ")";
        }
    }
}
