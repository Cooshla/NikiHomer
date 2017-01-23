using System.Collections.Generic;
using Vega.USiteBuilder;

namespace BelaRose.DocumentType
{
    [DocumentType(IconUrl = "house.png", Description = "Home page document type.", AllowAtRoot = true, DefaultTemplate = "Home", AllowedTemplates = new string[] { "Home" })]
    public class Home : Vega.USiteBuilder.DocumentTypeBase
    {
        public Home()
        {
        }

        [DocumentTypeProperty(UmbracoPropertyType.MediaPicker, Name = "Slide 1", Description = "Slide 1.", Tab = TabNames.Content)]
        public int? Slide1 { get; set; }

    }
}