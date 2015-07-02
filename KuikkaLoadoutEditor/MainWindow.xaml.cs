using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KuikkaLoadoutEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         LoadoutList loadoutList;
         String oldWeapon;
         String oldUniform;
         String oldVest;
         String oldBackpack;
         String oldHeadGear;
         String oldItemsInUniform;
         String oldItemsInVest;
         String oldItemsInBackPack;
         String oldOtherItems;
        
        public MainWindow()
        {
            InitializeComponent();
            this.loadoutList = new LoadoutList();
            oldWeapon = weaponBox.Text;
        }




        private void ChangeToSqf_Click(object sender, RoutedEventArgs e)
        {
            loadoutList.createSqfFile();
            MessageBox.Show("loadout tiedostosi on luotu työpöydälle nimellä newLoadOut");
        }





        public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {



            if (roleList.SelectedIndex < 0)
            {
                return;
            }
                int index = roleList.SelectedIndex;
                String roleClicked = roleList.Items[index].ToString();

                loadoutBox.Text = this.loadoutList.getLoadout(roleClicked);
                roleBox.Text = roleClicked;
                weaponBox.Text = this.loadoutList.returnLoadout(roleClicked).weapon;
                oldWeapon = weaponBox.Text;
                uniformBox.Text = this.loadoutList.returnLoadout(roleClicked).uniform;
                oldUniform = uniformBox.Text;
                vestBox.Text = this.loadoutList.returnLoadout(roleClicked).vest;
                oldVest = vestBox.Text;
                backpackBox.Text = this.loadoutList.returnLoadout(roleClicked).backpack;
                oldBackpack = backpackBox.Text;
                headGearBox.Text = this.loadoutList.returnLoadout(roleClicked).headGear;
                oldHeadGear = headGearBox.Text;
                itemsInUniformBox.Text = this.loadoutList.returnLoadout(roleClicked).itemsInUniform;
                oldItemsInUniform = itemsInUniformBox.Text;
                itemsInVestBox.Text = this.loadoutList.returnLoadout(roleClicked).itemsInVest;
                oldItemsInVest = itemsInVestBox.Text;
                itemsInBackPackBox.Text = this.loadoutList.returnLoadout(roleClicked).itemsInBackPack;
                oldItemsInBackPack = itemsInBackPackBox.Text;
                otherItemsBox.Text = this.loadoutList.returnLoadout(roleClicked).otherItems;
                oldOtherItems = otherItemsBox.Text;
            }
        

        



        public void createRole_Click(object sender, RoutedEventArgs e)
        {
            Window luoRooli = new CreateRole(loadoutList, roleList);
            luoRooli.Show();
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Box_Loadout_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void editLoadout_Click(object sender, RoutedEventArgs e)
        {
            if (loadoutList.roleExist(this.roleBox.Text))
            {
               
               loadoutList.editLoadout(this.roleBox.Text, this.loadoutBox.Text);
                                                                
            }
            else
            {
                MessageBox.Show("Roolia ei löytynyt");
            }
            // Following  commands changes Texts from textboxes to loadout
            try
            {
                if (oldUniform.Length > 0 && uniformBox.Text.Length > 0)
                {
                    this.loadoutBox.Text = this.loadoutBox.Text.Replace(oldUniform, uniformBox.Text);
                    oldUniform = uniformBox.Text;
                    }
                if (oldWeapon.Length > 0 && weaponBox.Text.Length > 0)
                    {

                        this.loadoutBox.Text = this.loadoutBox.Text.Replace(oldWeapon, weaponBox.Text);
                        oldWeapon = weaponBox.Text;
                    }
               if (oldVest.Length > 0 && vestBox.Text.Length > 0)
                    {
                        this.loadoutBox.Text = this.loadoutBox.Text.Replace(oldVest, vestBox.Text);
                        oldVest = vestBox.Text;
                    }

                if (oldBackpack.Length > 0 && backpackBox.Text.Length > 0)
                {
                    this.loadoutBox.Text = this.loadoutBox.Text.Replace(oldBackpack, backpackBox.Text);
                    oldBackpack = backpackBox.Text;
                }

                if (oldHeadGear.Length > 0 && headGearBox.Text.Length > 0)
                {
                    this.loadoutBox.Text = this.loadoutBox.Text.Replace(oldHeadGear, headGearBox.Text);
                    oldHeadGear = headGearBox.Text;
                }

                if(oldItemsInUniform.Length > 0 && itemsInUniformBox.Text.Length > 0)
                {
                    this.loadoutBox.Text = this.loadoutBox.Text.Replace(oldUniform, uniformBox.Text);
                    oldItemsInUniform = itemsInUniformBox.Text;
                }

                if (oldItemsInVest.Length > 0 && itemsInVestBox.Text.Length > 0)
                {
                    this.loadoutBox.Text = this.loadoutBox.Text.Replace(oldItemsInVest, itemsInVestBox.Text);
                    oldItemsInVest = itemsInVestBox.Text;
                }
                if (oldItemsInBackPack.Length > 0 && itemsInBackPackBox.Text.Length > 0)
                {
                    this.loadoutBox.Text = this.loadoutBox.Text.Replace(oldItemsInBackPack, itemsInBackPackBox.Text);
                    oldItemsInBackPack = itemsInBackPackBox.Text;
                }
                if (oldOtherItems.Length > 0 && otherItemsBox.Text.Length > 0)
                {
                    this.loadoutBox.Text = this.loadoutBox.Text.Replace(oldOtherItems, otherItemsBox.Text);
                    oldOtherItems = otherItemsBox.Text;
                }
            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void WeaponBox_TextChanged(object sender, TextChangedEventArgs e)
        {
                   
        }

        private void uniformBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void vestBox_TextChanged(object sender, TextChangedEventArgs e)
        {
   
        }

        private void backpackBox_TextChanged(object sender, TextChangedEventArgs e)
        {
 
        }

        private void headGearBox_TextChanged(object sender, TextChangedEventArgs e)
        {
 
        }

        
        private void buttonRemove_Click(object sender, RoutedEventArgs e)
        {
            if (roleList.SelectedIndex >= 0)
            {
                roleList.Items.RemoveAt(roleList.SelectedIndex);
                roleBox.Text = "";
                itemsInUniformBox.Text = "";
                itemsInVestBox.Text = "";
                itemsInBackPackBox.Text = "";
                otherItemsBox.Text = "";
                weaponBox.Text = "";
                uniformBox.Text = "";
                vestBox.Text = "";
                backpackBox.Text = "";
                headGearBox.Text = "";
                loadoutBox.Text = "";
            }

        }

        private void itemsInUniformBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void itemsInVestBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void itemsInBackPacBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void otherItemsBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



    }
}
