using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Core;
using System;
using System.Reflection;

namespace WpfApplication3 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DXTabControl.TabShown += new TabControlTabShownEventHandler(DXTabControl_TabShown);
        }


        void DXTabControl_TabShown(object sender, TabControlTabShownEventArgs e) {
            var tabItem = DXTabControl.Items[e.TabIndex];
            if(DXTabItem != tabItem) return;
            foreach(DXTabItem item in DXTabControl.Items) {
                DXTabControl.HideTabItem(item);
            }
            CloseHeaderMenu();
        }

        void CloseHeaderMenu() {
            (DXTabControl.HeaderMenu as CustomHeaderMenu).Close();
        //    Type headerMenu = DXTabControl.HeaderMenu.GetType();
            //MethodInfo mi = headerMenu.GetMethod("PopupClose", BindingFlags.NonPublic | BindingFlags.Instance);
            //mi.Invoke(DXTabControl.HeaderMenu, null);
        }        
    }
}
