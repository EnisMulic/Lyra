using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Mobile.Models
{
    public enum MenuItemType
    {
        Recommendations,
        Search,
        Activity,
        YourMusic,
        Settings
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
