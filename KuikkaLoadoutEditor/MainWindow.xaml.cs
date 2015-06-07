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

            }
            else
            {

                int index = roleList.SelectedIndex;
                String roleClicked = roleList.Items[index].ToString();

                loadoutBox.Text = this.loadoutList.getLoadout(roleClicked);
                roleBox.Text = roleClicked;
                weaponBox.Text = this.loadoutList.returnLoadout(roleClicked).weapon;
                oldWeapon = this.loadoutList.returnLoadout(roleClicked).weapon;
                uniformBox.Text = this.loadoutList.returnLoadout(roleClicked).uniform;
                vestBox.Text = this.loadoutList.returnLoadout(roleClicked).vest;
                backpackBox.Text = this.loadoutList.returnLoadout(roleClicked).backpack;
                headGearBox.Text = this.loadoutList.returnLoadout(roleClicked).headGear;
            }

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

            
        }

        private void WeaponBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                if (oldWeapon.Length > 0 && weaponBox.Text.Length > 0)
                {
                    MessageBox.Show("Tämä on ns vanhaAse" + oldWeapon);
                    this.loadoutBox.Text.Replace(oldWeapon, weaponBox.Text);
                    oldWeapon = weaponBox.Text;
                }
            }
            catch (Exception)
            {
                return;
            }
            

            

        }

        private void Box_Uniform_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Box_Vest_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Box_bacpack_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Box_HeadGear_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


    }
}
