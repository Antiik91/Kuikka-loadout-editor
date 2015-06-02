﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace KuikkaLoadoutEditor
{
   public class LoadoutList
    {
        public List<Loadout> loadoutList;

        public LoadoutList()
        {
            this.loadoutList = new List<Loadout>();
        }

        public void add(Loadout loadout)
        {
            this.loadoutList.Add(loadout);
        }

        public bool roleExist(String SearchableString)
        {
            foreach (Loadout l in loadoutList)
            {
                if (l.name.Equals(SearchableString))
                {
                    return true;
                }
            }
            return false;
        }

        public void editLoadout(String roleToEdit, String newBodyText)
        {
            foreach (Loadout l in loadoutList)
            {
                if(l.name.Equals(roleToEdit)){
                    l.bodyText = newBodyText;
                }
            }
        }

        public String getLoadout(String role)
        {
            String roleFound = "";
            foreach (Loadout l in loadoutList)
            {
                if (l.name.Equals(role))
                {
                    roleFound = l.bodyText;
                }
            }
            return roleFound;
        }

        public void createSqfFile()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\User\Desktop\newLoadOut.sqf"))
            {
                file.WriteLine("_unit = _this select 0;");
                file.WriteLine("_role = _this select 1;");
                file.WriteLine("if (!(local _unit)) exitwith {};");
                file.WriteLine("switch(_role) do {");
                file.WriteLine("");

                foreach (Loadout l in loadoutList)
                {
                    file.Write(l);
                }

                file.WriteLine("   };");
                file.WriteLine("titleText[\"\",\"PLAIN\"];");
                
            }
        }
       
    }
}
