﻿
using CommunityToolkit.Mvvm.ComponentModel;

namespace Sample
{
    public partial class SimpleGifPageModel : ObservableObject
    {
        public void Reload()
        {
			ImageUrl = "loadinggif.gif"; // "resource://Sample.tenor.gif";
        }

        [ObservableProperty]
        string imageUrl;
    }
}
