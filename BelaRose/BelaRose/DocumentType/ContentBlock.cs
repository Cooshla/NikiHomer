
using System;
using Vega.USiteBuilder;

namespace BelaRose.DocumentType
{
    [DocumentType(IconUrl = "house.png", Description = "Content Block.", AllowAtRoot = false, AllowedChildNodeTypeOf = new Type[]
    {
        typeof(Home)
    })]
    public class ContentBlock : Vega.USiteBuilder.DocumentTypeBase
    {

        [DocumentTypeProperty(UmbracoPropertyType.MediaPicker, Name = "Image", Description = "Image.", Tab = TabNames.Content)]
        public int? Image { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Title", Description = "Title.", Tab = TabNames.Content)]
        public string Title { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "SubHeading", Description = "SubHeading.", Tab = TabNames.Content)]
        public string SubHeading { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Description", Description = "Description.", Tab = TabNames.Content)]
        public string Description { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Link", Description = "Link.", Tab = TabNames.Content)]
        public string Link { get; set; }
    }
}