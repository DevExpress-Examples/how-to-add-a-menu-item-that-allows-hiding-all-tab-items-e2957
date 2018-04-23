using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication3 {
    public class CustomHeaderMenu: HeaderMenu {
        public void Close() {
            PopupClose();
        }
    }
}
