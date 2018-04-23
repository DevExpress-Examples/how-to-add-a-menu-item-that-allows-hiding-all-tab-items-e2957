# How to add a menu item that allows hiding all tab items


<p>Handle the TabShown event. In this event handler, call the DXTabControl.HideTabItem method, and call the internal PopupClose method via reflection.<br /><br /><strong>Updated</strong><br />In 15.1, we introduced the HeaderMenuCustomizations property implementing this functionality out of the box.</p>

<br/>


