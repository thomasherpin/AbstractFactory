using DesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class BlueTheme : IWidgetFactory
    {
        string color = "Cyan";

        BlueThemeButton Button = new BlueThemeButton();
        public string ThemeLoad()
        {
            return Button.GetCyanButtonColor();
        }
    }
}
