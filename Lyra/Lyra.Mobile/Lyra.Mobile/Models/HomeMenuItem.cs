using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
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
