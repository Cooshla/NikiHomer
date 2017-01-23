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


        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "MetaTitle", Description = "MetaTitle.", Tab = TabNames.Page)]
        public string MetaTitle { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "MetaDescription", Description = "MetaDescription.", Tab = TabNames.Page)]
        public string MetaDescription { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "MetaKeywords", Description = "MetaKeywords.", Tab = TabNames.Page)]
        public string MetaKeywords { get; set; }


        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "GooglePlus", Description = "GooglePlus.", Tab = TabNames.Page)]
        public string GooglePlus { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "FaceBook", Description = "FaceBook.", Tab = TabNames.Page)]
        public string FaceBook { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Twitter", Description = "Twitter.", Tab = TabNames.Page)]
        public string Twitter { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "LinkedIn", Description = "LinkedIn.", Tab = TabNames.Page)]
        public string LinkedIn { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Instagram", Description = "Instagram.", Tab = TabNames.Page)]
        public string Instagram { get; set; }




        [DocumentTypeProperty(UmbracoPropertyType.MediaPicker, Name = "BackgroundImage", Description = "BackgroundImage.", Tab = TabNames.Content)]
        public int? BackgroundImage { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "H1Tag", Description = "H1Tag.", Tab = TabNames.Content)]
        public string H1Tag { get; set; }


        

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "CTATitle", Description = "CTATitle.", Tab = TabNames.CTA)]
        public string CTATitle { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "CTAText", Description = "CTAText.", Tab = TabNames.CTA)]
        public string CTAText { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "CTAButtonText", Description = "CTAButtonText.", Tab = TabNames.CTA)]
        public string CTAButtonText { get; set; }



        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "ServicesTitle", Description = "ServicesTitle.", Tab = TabNames.Services)]
        public string ServicesTitle { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "ServicesSubTitle", Description = "ServicesSubTitle.", Tab = TabNames.Services)]
        public string ServicesSubTitle { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "ServicesContent", Description = "ServicesContent.", Tab = TabNames.Services)]
        public string ServicesContent { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.ContentPicker, Name = "ServicePanels", Description = "ServicePanels.", Tab = TabNames.Services)]
        public string ServicePanels { get; set; }





        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "AboutTitle", Description = "AboutTitle.", Tab = TabNames.About)]
        public string AboutTitle { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "AboutSubTitle", Description = "AboutSubTitle.", Tab = TabNames.About)]
        public string AboutSubTitle { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "AboutContent", Description = "AboutContent.", Tab = TabNames.About)]
        public string AboutContent { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.ContentPicker, Name = "AboutCarousel1", Description = "AboutCarousel1.", Tab = TabNames.Services)]
        public string AboutCarousel1 { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.ContentPicker, Name = "AboutPanels", Description = "AboutPanels.", Tab = TabNames.Services)]
        public string AboutPanels { get; set; }


        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "PricesTitle", Description = "PricesTitle.", Tab = TabNames.Prices)]
        public string PricesTitle { get; set; }
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "ListTitle", Description = "ListTitle.", Tab = TabNames.Prices)]
        public string ListTitle { get; set; }
        [DocumentTypeProperty(UmbracoPropertyType.ContentPicker, Name = "PriceList", Description = "PriceList.", Tab = TabNames.Prices)]
        public string PriceList { get; set; }
        [DocumentTypeProperty(UmbracoPropertyType.ContentPicker, Name = "PriceList2", Description = "PriceList2.", Tab = TabNames.Prices)]
        public string PriceList2 { get; set; }


        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "GalleryTitle", Description = "GalleryTitle.", Tab = TabNames.Gallery)]
        public string GalleryTitle { get; set; }


        [DocumentTypeProperty(UmbracoPropertyType.MediaPicker, Name = "Images", Description = "Images.", Tab = TabNames.Gallery)]
        public List<int?> Images { get; set; }


        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Contact Blurb", Description = "Contact Blurb.", Tab = TabNames.Contact)]
        public string ContactBlurb { get; set; }
        


        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Email", Description = "Email.", Tab = TabNames.Info)]
        public string InfoEmail { get; set; }
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Phone", Description = "Phone.", Tab = TabNames.Info)]
        public string InfoPhone { get; set; }
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Address", Description = "Address.", Tab = TabNames.Info)]
        public string InfoAddress { get; set; }
        

    }
}