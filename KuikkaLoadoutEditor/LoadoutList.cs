using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;



namespace KuikkaLoadoutEditor
{
    class LoadoutList
    {
        private List<Loadout> loadoutList;

        public LoadoutList()
        {
            this.loadoutList = new List<Loadout>();
        }

        public void add(Loadout loadout)
        {
            this.loadoutList.Add(loadout);
        }


        public void createSqfFile()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\newLoadOut.txt"))
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

                file.WriteLine("};");
                file.WriteLine("titleText[\"\",\"PLAIN\"];");
                // titleText["","PLAIN"];
            }
        }
       
    }
}
