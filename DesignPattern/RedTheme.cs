using DesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DesignPattern
{
    public class RedTheme : IWidgetFactory
    {
        string color = "Red";

        RedThemeButton Button = new RedThemeButton();
        public string ThemeLoad()
        {
            return Button.GetRedButtonColor();
        }
    }
}
