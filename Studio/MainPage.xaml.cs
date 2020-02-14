using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Studio
{
    public class CustomObject
    {
        public Color BackColor { get; set; }
    }

    public class CustomListObject
    {
        public List<CustomObject> Items { get; set; }
        public Color BackColor { get; set; }
    }

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            var rnd = new Random();

            var items = new List<CustomListObject>
            {
                new CustomListObject
                {
                    Items = new List<CustomObject>
                    {
                        new CustomObject
                        {
                            BackColor = Color.FromRgb(rnd.Next(1,240),rnd.Next(1,240), rnd.Next(1,240))
                        },
                        new CustomObject
                        {
                            BackColor = Color.FromRgb(rnd.Next(1,240),rnd.Next(1,240), rnd.Next(1,240))
                        },
                        new CustomObject
                        {
                            BackColor = Color.FromRgb(rnd.Next(1,240),rnd.Next(1,240), rnd.Next(1,240))
                        },
                        new CustomObject
                        {
                            BackColor = Color.FromRgb(rnd.Next(1,240),rnd.Next(1,240), rnd.Next(1,240))
                        },
                    },
                    BackColor = Color.FromRgb(rnd.Next(1,240),rnd.Next(1,240), rnd.Next(1,240))
                },
                new CustomListObject
                {
                    Items = new List<CustomObject>
                    {
                        new CustomObject
                        {
                            BackColor = Color.FromRgb(rnd.Next(1,240),rnd.Next(1,240), rnd.Next(1,240))
                        },
                        new CustomObject
                        {
                            BackColor = Color.FromRgb(rnd.Next(1,240),rnd.Next(1,240), rnd.Next(1,240))
                        },
                        new CustomObject
                        {
                            BackColor = Color.FromRgb(rnd.Next(1,240),rnd.Next(1,240), rnd.Next(1,240))
                        },
                        new CustomObject
                        {
                            BackColor = Color.FromRgb(rnd.Next(1,240),rnd.Next(1,240), rnd.Next(1,240))
                        },
                    },
                    BackColor = Color.FromRgb(rnd.Next(1,240),rnd.Next(1,240), rnd.Next(1,240))
                }

            };

            FirstCarousel.ItemsSource = items;

        }
    }
}
