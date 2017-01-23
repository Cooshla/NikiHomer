using System.Collections.Generic;
using Vega.USiteBuilder;

namespace BelaRose.DocumentType
{
    [DocumentType(IconUrl = "house.png", Description = "Holding page document type.", AllowAtRoot = true, DefaultTemplate = "HoldingPage", AllowedTemplates = new string[] { "HoldingPage" })]
    public class HoldingPage : Vega.USiteBuilder.DocumentTypeBase
    {
        public HoldingPage()
        {
        }


        [DocumentTypeProperty(UmbracoPropertyType.MediaPicker, Name = "BackgroundImage", Description = "BackgroundImage.", Tab = TabNames.Content)]
        public int? BackgroundImage { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.MediaPicker, Name = "Logo", Description = "Logo.", Tab = TabNames.Content)]
        public int? Logo { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Title", Description = "Title.", Tab = TabNames.Content)]
        public string Title { get; set; }


        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Description", Description = "Description.", Tab = TabNames.Content)]
        public string Description { get; set; }


        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Facebook", Description = "Facebook.", Tab = TabNames.Content)]
        public string Facebook { get; set; }


        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Twitter", Description = "Twitter.", Tab = TabNames.Content)]
        public string Twitter { get; set; }


        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "LinkedIn", Description = "LinkedIn.", Tab = TabNames.Content)]
        public string LinkedIn { get; set; }

    }
}