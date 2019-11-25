using System;
using System.Collections.Generic;
using System.Text;

namespace SkripsiInventory.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        LoginPrep,
        Login
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
