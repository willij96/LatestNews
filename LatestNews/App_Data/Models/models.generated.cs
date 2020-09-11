//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.6.4
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "832cc407fde32841")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.12")]

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Home Page</summary>
	[PublishedModel("homePage")]
	public partial class HomePage : PublishedContentModel, ITitleBox
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "homePage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomePage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public HomePage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Body Text: This will be the main text on the homepage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("bodyText")]
		public global::System.Web.IHtmlString BodyText => this.Value<global::System.Web.IHtmlString>("bodyText");

		///<summary>
		/// CTA Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("cTAHeading")]
		public string CTaheading => this.Value<string>("cTAHeading");

		///<summary>
		/// CTA Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("cTALink")]
		public global::Umbraco.Web.Models.Link CTalink => this.Value<global::Umbraco.Web.Models.Link>("cTALink");

		///<summary>
		/// CTA Link Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("cTALinkText")]
		public string CTalinkText => this.Value<string>("cTALinkText");

		///<summary>
		/// CTA Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("cTAText")]
		public string CTatext => this.Value<string>("cTAText");

		///<summary>
		/// GB Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("gBContent")]
		public global::System.Web.IHtmlString GBcontent => this.Value<global::System.Web.IHtmlString>("gBContent");

		///<summary>
		/// GB Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("gBHeading")]
		public string GBheading => this.Value<string>("gBHeading");

		///<summary>
		/// GB Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("gBImage")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent GBimage => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("gBImage");

		///<summary>
		/// Page Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("pageSubtitle")]
		public string PageSubtitle => global::Umbraco.Web.PublishedModels.TitleBox.GetPageSubtitle(this);

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => global::Umbraco.Web.PublishedModels.TitleBox.GetPageTitle(this);
	}

	/// <summary>Content Page</summary>
	[PublishedModel("contentPage")]
	public partial class ContentPage : PublishedContentModel, ITitleBox
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "contentPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContentPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContentPage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// BodyText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("bodyText")]
		public global::System.Web.IHtmlString BodyText => this.Value<global::System.Web.IHtmlString>("bodyText");

		///<summary>
		/// Page Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("pageSubtitle")]
		public string PageSubtitle => global::Umbraco.Web.PublishedModels.TitleBox.GetPageSubtitle(this);

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => global::Umbraco.Web.PublishedModels.TitleBox.GetPageTitle(this);
	}

	/// <summary>Contact Page</summary>
	[PublishedModel("contactPage")]
	public partial class ContactPage : PublishedContentModel, ITitleBox
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "contactPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContactPage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// BodyText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("bodyText")]
		public global::System.Web.IHtmlString BodyText => this.Value<global::System.Web.IHtmlString>("bodyText");

		///<summary>
		/// Page Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("pageSubtitle")]
		public string PageSubtitle => global::Umbraco.Web.PublishedModels.TitleBox.GetPageSubtitle(this);

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => global::Umbraco.Web.PublishedModels.TitleBox.GetPageTitle(this);
	}

	// Mixin Content Type with alias "titleBox"
	/// <summary>Title Box</summary>
	public partial interface ITitleBox : IPublishedContent
	{
		/// <summary>Page Subtitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		string PageSubtitle { get; }

		/// <summary>Page Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		string PageTitle { get; }
	}

	/// <summary>Title Box</summary>
	[PublishedModel("titleBox")]
	public partial class TitleBox : PublishedContentModel, ITitleBox
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "titleBox";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TitleBox, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public TitleBox(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Page Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("pageSubtitle")]
		public string PageSubtitle => GetPageSubtitle(this);

		/// <summary>Static getter for Page Subtitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static string GetPageSubtitle(ITitleBox that) => that.Value<string>("pageSubtitle");

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => GetPageTitle(this);

		/// <summary>Static getter for Page Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static string GetPageTitle(ITitleBox that) => that.Value<string>("pageTitle");
	}

	/// <summary>Blog Item</summary>
	[PublishedModel("blogItem")]
	public partial class BlogItem : PublishedContentModel, ITitleBox
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "blogItem";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogItem, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public BlogItem(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Author Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("authorImage")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent AuthorImage => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("authorImage");

		///<summary>
		/// Author Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("authorName")]
		public string AuthorName => this.Value<string>("authorName");

		///<summary>
		/// Author Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("authorTitle")]
		public string AuthorTitle => this.Value<string>("authorTitle");

		///<summary>
		/// Body Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("bodyText")]
		public global::System.Web.IHtmlString BodyText => this.Value<global::System.Web.IHtmlString>("bodyText");

		///<summary>
		/// Categories
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("categories")]
		public string Categories => this.Value<string>("categories");

		///<summary>
		/// Excerpt
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("excerpt")]
		public string Excerpt => this.Value<string>("excerpt");

		///<summary>
		/// Intro Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("introText")]
		public global::System.Web.IHtmlString IntroText => this.Value<global::System.Web.IHtmlString>("introText");

		///<summary>
		/// Related Story
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("relatedStory")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent RelatedStory => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("relatedStory");

		///<summary>
		/// Thumbnail Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("thumbnailImage")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent ThumbnailImage => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("thumbnailImage");

		///<summary>
		/// Page Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("pageSubtitle")]
		public string PageSubtitle => global::Umbraco.Web.PublishedModels.TitleBox.GetPageSubtitle(this);

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => global::Umbraco.Web.PublishedModels.TitleBox.GetPageTitle(this);
	}

	/// <summary>Blog</summary>
	[PublishedModel("blog")]
	public partial class Blog : PublishedContentModel, ITitleBox
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "blog";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Blog, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Blog(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Featured Story
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("featuredStory")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent FeaturedStory => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("featuredStory");

		///<summary>
		/// Page Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("pageSubtitle")]
		public string PageSubtitle => global::Umbraco.Web.PublishedModels.TitleBox.GetPageSubtitle(this);

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => global::Umbraco.Web.PublishedModels.TitleBox.GetPageTitle(this);
	}

	/// <summary>Folder</summary>
	[PublishedModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "Folder";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Folder(IPublishedContent content)
			: base(content)
		{ }

		// properties
	}

	/// <summary>Image</summary>
	[PublishedModel("Image")]
	public partial class Image : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "Image";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Image(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Size: in bytes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoBytes")]
		public long UmbracoBytes => this.Value<long>("umbracoBytes");

		///<summary>
		/// Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension => this.Value<string>("umbracoExtension");

		///<summary>
		/// Upload image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoFile")]
		public global::Umbraco.Core.PropertyEditors.ValueConverters.ImageCropperValue UmbracoFile => this.Value<global::Umbraco.Core.PropertyEditors.ValueConverters.ImageCropperValue>("umbracoFile");

		///<summary>
		/// Height: in pixels
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoHeight")]
		public int UmbracoHeight => this.Value<int>("umbracoHeight");

		///<summary>
		/// Width: in pixels
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoWidth")]
		public int UmbracoWidth => this.Value<int>("umbracoWidth");
	}

	/// <summary>File</summary>
	[PublishedModel("File")]
	public partial class File : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "File";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public File(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Size: in bytes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoBytes")]
		public long UmbracoBytes => this.Value<long>("umbracoBytes");

		///<summary>
		/// Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension => this.Value<string>("umbracoExtension");

		///<summary>
		/// Upload file
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile => this.Value<string>("umbracoFile");
	}

	/// <summary>Member</summary>
	[PublishedModel("Member")]
	public partial class Member : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "Member";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Member(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Is Approved
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved => this.Value<bool>("umbracoMemberApproved");

		///<summary>
		/// Comments
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments => this.Value<string>("umbracoMemberComments");

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public int UmbracoMemberFailedPasswordAttempts => this.Value<int>("umbracoMemberFailedPasswordAttempts");

		///<summary>
		/// Last Lockout Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public global::System.DateTime UmbracoMemberLastLockoutDate => this.Value<global::System.DateTime>("umbracoMemberLastLockoutDate");

		///<summary>
		/// Last Login Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public global::System.DateTime UmbracoMemberLastLogin => this.Value<global::System.DateTime>("umbracoMemberLastLogin");

		///<summary>
		/// Last Password Change Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public global::System.DateTime UmbracoMemberLastPasswordChangeDate => this.Value<global::System.DateTime>("umbracoMemberLastPasswordChangeDate");

		///<summary>
		/// Is Locked Out
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut => this.Value<bool>("umbracoMemberLockedOut");

		///<summary>
		/// Password Answer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public global::System.DateTime UmbracoMemberPasswordRetrievalAnswer => this.Value<global::System.DateTime>("umbracoMemberPasswordRetrievalAnswer");

		///<summary>
		/// Password Question
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public global::System.DateTime UmbracoMemberPasswordRetrievalQuestion => this.Value<global::System.DateTime>("umbracoMemberPasswordRetrievalQuestion");
	}

}
