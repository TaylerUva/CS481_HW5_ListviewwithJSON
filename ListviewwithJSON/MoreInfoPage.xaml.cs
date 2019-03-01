using System;
using System.Collections.Generic;
using ListviewwithJSON.Models;
using Xamarin.Forms;

namespace ListviewwithJSON {
    public partial class MoreInfoPage : ContentPage {

        public MoreInfoPage(ProductsData itemClicked) {
            InitializeComponent();
            BindingContext = itemClicked;
        }
    }
}
