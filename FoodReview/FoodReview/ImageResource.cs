using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodReview
{
    [ContentProperty(nameof(Source))]
    class ImageResource : IMarkupExtension
    {
        public String Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null) return null;

            var imgSource = ImageSource.FromResource(Source, typeof(ImageResource).GetTypeInfo().Assembly);
            return imgSource;
        }
    }
}
