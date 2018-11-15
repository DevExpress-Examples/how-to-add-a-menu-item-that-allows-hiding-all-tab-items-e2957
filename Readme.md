<!-- default file list -->
*Files to look at*:

* [CustomHeaderMenu.cs](./CS/CustomHeaderMenu.cs) (VB: [CustomHeaderMenu.vb](./VB/CustomHeaderMenu.vb))
* **[MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [TabControl.xaml](./CS/TabControl.xaml) (VB: [TabControl.xaml](./VB/TabControl.xaml))
<!-- default file list end -->
# How to add a menu item that allows hiding all tab items


<p>Handle the TabShown event. In this event handler, call the DXTabControl.HideTabItem method, and call the internal PopupClose method via reflection.<br /><br /><strong>Updated</strong><br />In 15.1, we introduced the HeaderMenuCustomizations property implementing this functionality out of the box.</p>

<br/>


