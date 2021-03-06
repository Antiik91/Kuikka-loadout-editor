﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuikkaLoadoutEditor
{
  
    public class Loadout
    {
 

        public Loadout(String name, String bodyText)
        {
            
            this.name = name;
            this.bodyText = bodyText;
            this.editToSqfFormat();
            this.seperate();
            
        }


        
        public String name { get; set; }
        public String bodyText{ get; set; }
        public String weapon { get; set; }
        public String uniform { get; set; }
        public String vest { get; set; }
        public String headGear { get; set; }
        public String backpack { get; set; }
        public String itemsInUniform { get; set; }
        public String itemsInVest { get; set; }
        public String itemsInBackPack { get; set; }
        public String otherItems { get; set; }

        public void edit(String newWeapon)
        {
            weapon = newWeapon;
        }

        private void seperate()
        {
            String[] words = this.bodyText.Split(';', ' ' );

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals("addWeapon"))
                {
                    weapon = words[i + 1];
                }
                else if (words[i].Equals("forceAddUniform"))
                {
                    uniform = words[i + 1];
                }
                else if (words[i].Equals("addVest"))
                {
                    vest = words[i + 1];
                }
                else if (words[i].Equals("addHeadgear"))
                {
                    headGear = words[i + 1];
                } else if (words[i].Equals("addBackpack")){
                    backpack = words[i+1];
                }
                else if (words[i].Equals("addItemToUniform"))
                {
                    itemsInUniform += words[i + 1];
                }
                else if (words[i].Equals("addItemToVest"))
                {
                    itemsInVest += words[i + 1];
                }
                else if (words[i].Equals("addItemToBackpack"))
                {
                    itemsInBackPack += words[i + 1];
                }
                else if (words[i].Equals("linkItem")){
                    otherItems  += words[i + 1];
                }
            }

        }
        private void editToSqfFormat()
        {
           this.bodyText = this.bodyText.Replace("this", "_unit");
           this.bodyText = this.bodyText.Replace("tf_anprc152_1", "tf_anprc152");
           this.bodyText = this.bodyText.Replace("tf_rf7800str_1", "tf_rf7800str");
           this.bodyText = this.bodyText.Replace("tf_anprc148jem_1", "tf_anprc148jem");
           this.bodyText = this.bodyText.Replace("tf_fadak_1", "tf_fadak");
           this.bodyText = this.bodyText.Replace("tf_anprc154_1", "tf_anprc154");
           this.bodyText = this.bodyText.Replace("tf_pnr1000a_1", "tf_pnr1000a");
           this.bodyText = this.bodyText.Replace("tf_rt1523g_1", "tf_rt1523g");
           this.bodyText = this.bodyText.Replace("tf_anprc155_1", "tf_anprc155");
           this.bodyText = this.bodyText.Replace("tf_mr3000_1", "tf_mr3000");
           this.bodyText = this.bodyText.Replace("tf_rt1523g_big_1", "tf_rt1523g_big");
           this.bodyText = this.bodyText.Replace("tf_rt1523g_black_1", "tf_rt1523g_black");
           this.bodyText = this.bodyText.Replace("tf_rt1523g_fabric_1", "tf_rt1523g_fabric");
           this.bodyText = this.bodyText.Replace("tf_rt1523g_green_1", "tf_rt1523g_green");
           this.bodyText = this.bodyText.Replace("tf_rt1523g_rhs_1", "tf_rt1523g_rhs");
           this.bodyText = this.bodyText.Replace("tf_rt1523g_sage_1", "tf_rt1523g_sage");
           this.bodyText = this.bodyText.Replace("tf_anprc155_coyote_1", "tf_anprc155_coyote");
           this.bodyText = this.bodyText.Replace("tf_mr3000_multicam_1", "tf_mr3000_multicam");
           this.bodyText = this.bodyText.Replace("tf_mr3000_rhs_1", "tf_mr3000_rhs");
           this.bodyText = this.bodyText.Replace("tf_anarc210_1", "tf_anarc210");
           this.bodyText = this.bodyText.Replace("tf_anarc164_1", "tf_anarc164");
           this.bodyText = this.bodyText.Replace("tf_mr6000l_1", "tf_mr6000l");
        }


        
        public override string ToString()
        {
            return "case " + "\"" + this.name + "\"" + ": {" + "\r\n" + this.bodyText +  "\r\n" + " };" + "\r\n";
        }
    }

   
}
