using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Studio
{
    public partial class CustomView : ContentView
    {
        public CustomView()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var item = (CustomListObject)BindingContext;

            SecondCarousel.ItemsSource = item.Items;
        }
    }
}
