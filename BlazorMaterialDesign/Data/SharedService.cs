using MatBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMaterialDesign.Data
{
    public class SharedService
    {
        public AppTheme Theme { get; set; } = new AppTheme();
        public Action UpdateLayout { get; set; }
        public MatTheme LightTheme => new MatTheme()
        {
            Primary = "#1976D2",
            Secondary = "#ffffff",
            Background = "#ffffff",
            Surface = "#ffffff",
            OnPrimary = "#ffffff",
            OnSecondary = "#ffffff",
            OnSurface = "#000000"
        };
        public MatTheme DarkTheme => new MatTheme()
        {
            Primary = "#1976D2",
            Secondary = "#9C27B0",
            Background = "#303030",
            Surface = "#333333",
            OnPrimary = "#fff",
            OnSecondary = "#201317",
            OnSurface = "#fff"
        };
        public bool DrawerState { get; set; } = true;

    }
    public class AppTheme
    {
        public MatTheme Theme { get; set; }
        public string Name { get; set; }
    }
}
