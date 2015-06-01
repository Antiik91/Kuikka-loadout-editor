using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuikkaLoadoutEditor
{
  
    class Loadout
    {
 

        public Loadout(String name, String bodyText)
        {
            
            this.name = name;
            this.bodyText = bodyText;
            this.editToSqfFormat();
            
        }


        
        public String name { get; set; }
        public String bodyText{ get; set; }

        private void editToSqfFormat()
        {
           this.bodyText = this.bodyText.Replace("this", "_unit");
        }


        
        public override string ToString()
        {
            return "case " + "\"" + this.name + "\"" + ": {" + "\r\n" + this.bodyText +  "\r\n" + " };" + "\r\n";
        }
    }

   
}
