using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ListviewwithJSON.Models;

using Newtonsoft.Json;
using Xamarin.Forms;

namespace ListviewwithJSON {
    public partial class MainPage : ContentPage {
        List<ProductsData> productsDataFromJson = new List<ProductsData>();

        public MainPage() {
            InitializeComponent();

            ReadInJsonFile();
        }

        private void ReadInJsonFile() {
            string fileName = "ListviewwithJSON.products.json";

            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(fileName);

            using (var reader = new System.IO.StreamReader(stream)) {
                var jsonAsString = reader.ReadToEnd();
                //productsDataFromJson = JsonConvert.DeserializeObject<List<ProductsData>>(jsonAsString);
                productsDataFromJson = ProductsData.FromJson(jsonAsString);
            }


            ProductsListView.ItemsSource = new ObservableCollection<ProductsData>(productsDataFromJson);
        }
    }
}

