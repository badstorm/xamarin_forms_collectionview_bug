using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Studio
{
    public partial class CustomContentView : ContentView
    {
        public CustomContentView()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var item = (CustomObject)BindingContext;

            BackgroundColor = item.BackColor;
        }
    }
}
