using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KuikkaLoadoutEditor
{
    class VisibilityHandler
    {
         public VisibilityHandler(MainWindow windowIn)
        {
            window = windowIn;
        }

        private MainWindow window { get; set; }

        public void showCreateRole()
        {
            this.hideAll();
            window.Visibility = Visibility.Visible;
        }



        private void hideAll()
        {
            //window.Visibility = Visibility.Hidden;

        }
    }
    }

