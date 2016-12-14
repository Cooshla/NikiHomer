using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "a62654c4da706921")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.5.96
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Master</summary>
	[PublishedContentModel("umbMaster")]
	public partial class UmbMaster : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbMaster";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbMaster(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbMaster, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Page title: The page title overrules the name this page was given. So if the page name is "About us" the title could be "About Our Company Name".
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// Hide in navigation?: If set to "Yes", this page will be hidden from the navigation menu at the top.
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Home</summary>
	[PublishedContentModel("umbHomePage")]
	public partial class UmbHomePage : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbHomePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbHomePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbHomePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// AboutText
		///</summary>
		[ImplementPropertyType("aboutText")]
		public IHtmlString AboutText
		{
			get { return this.GetPropertyValue<IHtmlString>("aboutText"); }
		}

		///<summary>
		/// About Title
		///</summary>
		[ImplementPropertyType("aboutTitle")]
		public string AboutTitle
		{
			get { return this.GetPropertyValue<string>("aboutTitle"); }
		}

		///<summary>
		/// Banner background image
		///</summary>
		[ImplementPropertyType("bannerBackgroundImage")]
		public object BannerBackgroundImage
		{
			get { return this.GetPropertyValue("bannerBackgroundImage"); }
		}

		///<summary>
		/// Banner Header
		///</summary>
		[ImplementPropertyType("bannerHeader")]
		public string BannerHeader
		{
			get { return this.GetPropertyValue<string>("bannerHeader"); }
		}

		///<summary>
		/// Banner link
		///</summary>
		[ImplementPropertyType("bannerLink")]
		public object BannerLink
		{
			get { return this.GetPropertyValue("bannerLink"); }
		}

		///<summary>
		/// Banner link text
		///</summary>
		[ImplementPropertyType("bannerLinkText")]
		public string BannerLinkText
		{
			get { return this.GetPropertyValue<string>("bannerLinkText"); }
		}

		///<summary>
		/// Banner Subheader
		///</summary>
		[ImplementPropertyType("bannerSubheader")]
		public string BannerSubheader
		{
			get { return this.GetPropertyValue<string>("bannerSubheader"); }
		}

		///<summary>
		/// Byline
		///</summary>
		[ImplementPropertyType("byline")]
		public string Byline
		{
			get { return this.GetPropertyValue<string>("byline"); }
		}

		///<summary>
		/// Copyright
		///</summary>
		[ImplementPropertyType("copyright")]
		public string Copyright
		{
			get { return this.GetPropertyValue<string>("copyright"); }
		}

		///<summary>
		/// Dribbble link
		///</summary>
		[ImplementPropertyType("dribbbleLink")]
		public string DribbbleLink
		{
			get { return this.GetPropertyValue<string>("dribbbleLink"); }
		}

		///<summary>
		/// Facebook link
		///</summary>
		[ImplementPropertyType("facebookLink")]
		public string FacebookLink
		{
			get { return this.GetPropertyValue<string>("facebookLink"); }
		}

		///<summary>
		/// Google+ link
		///</summary>
		[ImplementPropertyType("googleLink")]
		public string GoogleLink
		{
			get { return this.GetPropertyValue<string>("googleLink"); }
		}

		///<summary>
		/// Hide banner?
		///</summary>
		[ImplementPropertyType("hideBanner")]
		public bool HideBanner
		{
			get { return this.GetPropertyValue<bool>("hideBanner"); }
		}

		///<summary>
		/// LinkedIn link
		///</summary>
		[ImplementPropertyType("linkedInLink")]
		public string LinkedInLink
		{
			get { return this.GetPropertyValue<string>("linkedInLink"); }
		}

		///<summary>
		/// Rss link
		///</summary>
		[ImplementPropertyType("rssLink")]
		public string RssLink
		{
			get { return this.GetPropertyValue<string>("rssLink"); }
		}

		///<summary>
		/// Site Name
		///</summary>
		[ImplementPropertyType("siteName")]
		public string SiteName
		{
			get { return this.GetPropertyValue<string>("siteName"); }
		}

		///<summary>
		/// Twitter link
		///</summary>
		[ImplementPropertyType("twitterLink")]
		public string TwitterLink
		{
			get { return this.GetPropertyValue<string>("twitterLink"); }
		}
	}

	/// <summary>News Item</summary>
	[PublishedContentModel("umbNewsItem")]
	public partial class UmbNewsItem : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbNewsItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbNewsItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbNewsItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("bodyText")]
		public IHtmlString BodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("bodyText"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public object Image
		{
			get { return this.GetPropertyValue("image"); }
		}

		///<summary>
		/// Publish date: You can overrule the date shown on the site by changing it here. If you don't set a date explicitly here then the news item's create date will be shown.
		///</summary>
		[ImplementPropertyType("publishDate")]
		public DateTime PublishDate
		{
			get { return this.GetPropertyValue<DateTime>("publishDate"); }
		}

		///<summary>
		/// Subheader
		///</summary>
		[ImplementPropertyType("subheader")]
		public string Subheader
		{
			get { return this.GetPropertyValue<string>("subheader"); }
		}
	}

	/// <summary>News Overview</summary>
	[PublishedContentModel("umbNewsOverview")]
	public partial class UmbNewsOverview : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbNewsOverview";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbNewsOverview(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbNewsOverview, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Text Page</summary>
	[PublishedContentModel("umbTextPage")]
	public partial class UmbTextPage : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbTextPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbTextPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbTextPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("bodyText")]
		public IHtmlString BodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("bodyText"); }
		}

		///<summary>
		/// Featured Page?: Is this a page that should be featured on the home page?
		///</summary>
		[ImplementPropertyType("featuredPage")]
		public bool FeaturedPage
		{
			get { return this.GetPropertyValue<bool>("featuredPage"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public object Image
		{
			get { return this.GetPropertyValue("image"); }
		}
	}

	/// <summary>Holding Page</summary>
	[PublishedContentModel("holdingPage")]
	public partial class HoldingPage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "holdingPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HoldingPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HoldingPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Background Image
		///</summary>
		[ImplementPropertyType("backgroundImage")]
		public string BackgroundImage
		{
			get { return this.GetPropertyValue<string>("backgroundImage"); }
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public IHtmlString Content
		{
			get { return this.GetPropertyValue<IHtmlString>("content"); }
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public string Description
		{
			get { return this.GetPropertyValue<string>("description"); }
		}

		///<summary>
		/// Facebook
		///</summary>
		[ImplementPropertyType("facebook")]
		public string Facebook
		{
			get { return this.GetPropertyValue<string>("facebook"); }
		}

		///<summary>
		/// LinkedIn
		///</summary>
		[ImplementPropertyType("linkedIn")]
		public string LinkedIn
		{
			get { return this.GetPropertyValue<string>("linkedIn"); }
		}

		///<summary>
		/// Logo
		///</summary>
		[ImplementPropertyType("logo")]
		public string Logo
		{
			get { return this.GetPropertyValue<string>("logo"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// Twitter
		///</summary>
		[ImplementPropertyType("twitter")]
		public string Twitter
		{
			get { return this.GetPropertyValue<string>("twitter"); }
		}
	}

	/// <summary>Bela Rose Master</summary>
	[PublishedContentModel("belaRoseMaster")]
	public partial class BelaRoseMaster : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "belaRoseMaster";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BelaRoseMaster(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BelaRoseMaster, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Canonical
		///</summary>
		[ImplementPropertyType("canonical")]
		public string Canonical
		{
			get { return this.GetPropertyValue<string>("canonical"); }
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public string Description
		{
			get { return this.GetPropertyValue<string>("description"); }
		}

		///<summary>
		/// Email
		///</summary>
		[ImplementPropertyType("email")]
		public string Email
		{
			get { return this.GetPropertyValue<string>("email"); }
		}

		///<summary>
		/// Facebook Link
		///</summary>
		[ImplementPropertyType("facebookLink")]
		public string FacebookLink
		{
			get { return this.GetPropertyValue<string>("facebookLink"); }
		}

		///<summary>
		/// Instagram Link
		///</summary>
		[ImplementPropertyType("instagramLink")]
		public string InstagramLink
		{
			get { return this.GetPropertyValue<string>("instagramLink"); }
		}

		///<summary>
		/// Is Blog InActive: Tick if you want to disable the blog link
		///</summary>
		[ImplementPropertyType("isBlogInActive")]
		public bool IsBlogInActive
		{
			get { return this.GetPropertyValue<bool>("isBlogInActive"); }
		}

		///<summary>
		/// Loader Logo: Used as the page loader logo
		///</summary>
		[ImplementPropertyType("loaderLogo")]
		public string LoaderLogo
		{
			get { return this.GetPropertyValue<string>("loaderLogo"); }
		}

		///<summary>
		/// Location
		///</summary>
		[ImplementPropertyType("location")]
		public string Location
		{
			get { return this.GetPropertyValue<string>("location"); }
		}

		///<summary>
		/// Logo: The Main Logo
		///</summary>
		[ImplementPropertyType("logo")]
		public string Logo
		{
			get { return this.GetPropertyValue<string>("logo"); }
		}

		///<summary>
		/// Logo Dark: Dark version of the logo
		///</summary>
		[ImplementPropertyType("logoDark")]
		public string LogoDark
		{
			get { return this.GetPropertyValue<string>("logoDark"); }
		}

		///<summary>
		/// OpeningHours
		///</summary>
		[ImplementPropertyType("openingHours")]
		public IHtmlString OpeningHours
		{
			get { return this.GetPropertyValue<IHtmlString>("openingHours"); }
		}

		///<summary>
		/// Robots: Disallow Robots
		///</summary>
		[ImplementPropertyType("robots")]
		public bool Robots
		{
			get { return this.GetPropertyValue<bool>("robots"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// Tumblr Link
		///</summary>
		[ImplementPropertyType("tumblrLink")]
		public string TumblrLink
		{
			get { return this.GetPropertyValue<string>("tumblrLink"); }
		}

		///<summary>
		/// Twitter Link
		///</summary>
		[ImplementPropertyType("twitterLink")]
		public string TwitterLink
		{
			get { return this.GetPropertyValue<string>("twitterLink"); }
		}
	}

	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : BelaRoseMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// About Carousel 1
		///</summary>
		[ImplementPropertyType("aboutCarousel1")]
		public string AboutCarousel1
		{
			get { return this.GetPropertyValue<string>("aboutCarousel1"); }
		}

		///<summary>
		/// About Content
		///</summary>
		[ImplementPropertyType("aboutContent")]
		public string AboutContent
		{
			get { return this.GetPropertyValue<string>("aboutContent"); }
		}

		///<summary>
		/// About Panels
		///</summary>
		[ImplementPropertyType("aboutPanels")]
		public string AboutPanels
		{
			get { return this.GetPropertyValue<string>("aboutPanels"); }
		}

		///<summary>
		/// About Sub Title
		///</summary>
		[ImplementPropertyType("aboutSubTitle")]
		public string AboutSubTitle
		{
			get { return this.GetPropertyValue<string>("aboutSubTitle"); }
		}

		///<summary>
		/// About Title
		///</summary>
		[ImplementPropertyType("aboutTitle")]
		public string AboutTitle
		{
			get { return this.GetPropertyValue<string>("aboutTitle"); }
		}

		///<summary>
		/// Background Image: Image for top banner backgound
		///</summary>
		[ImplementPropertyType("backgroundImage")]
		public string BackgroundImage
		{
			get { return this.GetPropertyValue<string>("backgroundImage"); }
		}

		///<summary>
		/// CTA Button Text
		///</summary>
		[ImplementPropertyType("cTAButtonText")]
		public string CTabuttonText
		{
			get { return this.GetPropertyValue<string>("cTAButtonText"); }
		}

		///<summary>
		/// CTA Text
		///</summary>
		[ImplementPropertyType("cTAText")]
		public string CTatext
		{
			get { return this.GetPropertyValue<string>("cTAText"); }
		}

		///<summary>
		/// CTA Title
		///</summary>
		[ImplementPropertyType("cTATitle")]
		public string CTatitle
		{
			get { return this.GetPropertyValue<string>("cTATitle"); }
		}

		///<summary>
		/// Gallery Title
		///</summary>
		[ImplementPropertyType("galleryTitle")]
		public string GalleryTitle
		{
			get { return this.GetPropertyValue<string>("galleryTitle"); }
		}

		///<summary>
		/// H1 Tag
		///</summary>
		[ImplementPropertyType("h1Tag")]
		public string H1Tag
		{
			get { return this.GetPropertyValue<string>("h1Tag"); }
		}

		///<summary>
		/// Images
		///</summary>
		[ImplementPropertyType("images")]
		public string Images
		{
			get { return this.GetPropertyValue<string>("images"); }
		}

		///<summary>
		/// Is About Enabled
		///</summary>
		[ImplementPropertyType("isAboutEnabled")]
		public bool IsAboutEnabled
		{
			get { return this.GetPropertyValue<bool>("isAboutEnabled"); }
		}

		///<summary>
		/// Is Contact Enabled
		///</summary>
		[ImplementPropertyType("isContactEnabled")]
		public bool IsContactEnabled
		{
			get { return this.GetPropertyValue<bool>("isContactEnabled"); }
		}

		///<summary>
		/// Is CTA Enabled: Toggle CTA Section
		///</summary>
		[ImplementPropertyType("isCTAEnabled")]
		public bool IsCtaenabled
		{
			get { return this.GetPropertyValue<bool>("isCTAEnabled"); }
		}

		///<summary>
		/// Is Gallery Enabled
		///</summary>
		[ImplementPropertyType("isGalleryEnabled")]
		public bool IsGalleryEnabled
		{
			get { return this.GetPropertyValue<bool>("isGalleryEnabled"); }
		}

		///<summary>
		/// Is Info Enabled
		///</summary>
		[ImplementPropertyType("isInfoEnabled")]
		public bool IsInfoEnabled
		{
			get { return this.GetPropertyValue<bool>("isInfoEnabled"); }
		}

		///<summary>
		/// Is Prices Enabled
		///</summary>
		[ImplementPropertyType("isPricesEnabled")]
		public bool IsPricesEnabled
		{
			get { return this.GetPropertyValue<bool>("isPricesEnabled"); }
		}

		///<summary>
		/// Is Services Enabled
		///</summary>
		[ImplementPropertyType("isServicesEnabled")]
		public bool IsServicesEnabled
		{
			get { return this.GetPropertyValue<bool>("isServicesEnabled"); }
		}

		///<summary>
		/// Is Team Enabled
		///</summary>
		[ImplementPropertyType("isTeamEnabled")]
		public bool IsTeamEnabled
		{
			get { return this.GetPropertyValue<bool>("isTeamEnabled"); }
		}

		///<summary>
		/// Is Video Enabled
		///</summary>
		[ImplementPropertyType("isVideoEnabled")]
		public bool IsVideoEnabled
		{
			get { return this.GetPropertyValue<bool>("isVideoEnabled"); }
		}

		///<summary>
		/// List Title
		///</summary>
		[ImplementPropertyType("listTitle")]
		public string ListTitle
		{
			get { return this.GetPropertyValue<string>("listTitle"); }
		}

		///<summary>
		/// Price List
		///</summary>
		[ImplementPropertyType("priceList")]
		public string PriceList
		{
			get { return this.GetPropertyValue<string>("priceList"); }
		}

		///<summary>
		/// PriceList2
		///</summary>
		[ImplementPropertyType("priceList2")]
		public string PriceList2
		{
			get { return this.GetPropertyValue<string>("priceList2"); }
		}

		///<summary>
		/// Prices Title
		///</summary>
		[ImplementPropertyType("pricesTitle")]
		public string PricesTitle
		{
			get { return this.GetPropertyValue<string>("pricesTitle"); }
		}

		///<summary>
		/// ServicePanels
		///</summary>
		[ImplementPropertyType("servicePanels")]
		public string ServicePanels
		{
			get { return this.GetPropertyValue<string>("servicePanels"); }
		}

		///<summary>
		/// Services Content
		///</summary>
		[ImplementPropertyType("servicesContent")]
		public string ServicesContent
		{
			get { return this.GetPropertyValue<string>("servicesContent"); }
		}

		///<summary>
		/// Services Sub Title
		///</summary>
		[ImplementPropertyType("servicesSubTitle")]
		public string ServicesSubTitle
		{
			get { return this.GetPropertyValue<string>("servicesSubTitle"); }
		}

		///<summary>
		/// Services Title
		///</summary>
		[ImplementPropertyType("servicesTitle")]
		public string ServicesTitle
		{
			get { return this.GetPropertyValue<string>("servicesTitle"); }
		}
	}

	/// <summary>Content Block</summary>
	[PublishedContentModel("contentBlock")]
	public partial class ContentBlock : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contentBlock";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ContentBlock(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContentBlock, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public string Content
		{
			get { return this.GetPropertyValue<string>("content"); }
		}

		///<summary>
		/// Is First: is first in the collection
		///</summary>
		[ImplementPropertyType("isFirst")]
		public bool IsFirst
		{
			get { return this.GetPropertyValue<bool>("isFirst"); }
		}

		///<summary>
		/// Sub Heading
		///</summary>
		[ImplementPropertyType("subHeading")]
		public string SubHeading
		{
			get { return this.GetPropertyValue<string>("subHeading"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
