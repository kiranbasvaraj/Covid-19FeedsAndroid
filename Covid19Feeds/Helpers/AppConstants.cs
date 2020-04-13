using System;
using System.Collections.Generic;
using Covid19Feeds.Helpers;

namespace WantToWork.Helpers
{
    public class AppConstants
    {
        public AppConstants()
        {
        }

        public static string TabChanged = "TabChange";


        public static string BaseUrl = "https://corona.lmao.ninja/v2/";
        public static string LoadGlobalCasesAPi = BaseUrl+"all?yesterday=true";
        public static string LoadAllCountryCasesAPi = BaseUrl + "countries?yesterday=true&sort=cases";

        public static List<Colors> ColorList { get;  set; }=
            new List<Colors>() { 
      
            new Colors() {Color= "#EC4849" },
            new Colors() {Color= "#D63031" },
            new Colors() {Color= "#0A79DF" },
            new Colors() {Color= "#74B9FF" },
             new Colors() {Color= "#26ae60" },
            new Colors() {Color= "#2ecc72" },
            new Colors() {Color= "#F4C724" },
            new Colors() {Color= "#F5C469" },
            new Colors() {Color= "#25CCF7" },
            new Colors() {Color= "#0ABDE3" },};
        }


    }





