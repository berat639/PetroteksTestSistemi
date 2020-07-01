using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petroteks.Bll.Abstract;
using Petroteks.Bll.Helpers;
using Petroteks.Entities.ComplexTypes;
using Petroteks.Entities.Concreate;
using Petroteks.MvcUi.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using static Petroteks.Bll.Helpers.FriendlyUrlHelper;

namespace Petroteks.MvcUi.Controllers
{
    public class SeoController : GlobalController
    {
        private readonly ICategoryService categoryService;
        private readonly IProductService productService;
        private readonly IDynamicPageService dynamicPageService;
        private readonly IMainPageService mainPageService;
        private readonly IAboutUsObjectService aboutUsObjectService;
        private readonly IPrivacyPolicyObjectService privacyPolicyObjectService;
        private readonly IUI_ContactService uI_ContactService;
        private readonly IBlogService blogService;
        private readonly IWebHostEnvironment webHostEnvironment;


        public SeoController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            categoryService = serviceProvider.GetService<ICategoryService>();
            productService = serviceProvider.GetService<IProductService>();
            dynamicPageService = serviceProvider.GetService<IDynamicPageService>();
            mainPageService = serviceProvider.GetService<IMainPageService>();
            aboutUsObjectService = serviceProvider.GetService<IAboutUsObjectService>();
            uI_ContactService = serviceProvider.GetService<IUI_ContactService>();
            blogService = serviceProvider.GetService<IBlogService>();
            privacyPolicyObjectService = serviceProvider.GetService<IPrivacyPolicyObjectService>();
            webHostEnvironment = serviceProvider.GetService<IWebHostEnvironment>();
        }



        [Route("sitemap.xml")]
        public IActionResult SitemapXml()
        {
            Response.Clear();
            Response.ContentType = "text/xml";
            StringBuilder sb = new StringBuilder();
            if (CurrentWebsite != null && CurrentLanguage != null)
            {
                sb.AppendLine($"Lang: {CurrentLanguage.id}");
                sb.AppendLine($"Web: {CurrentWebsite.id}");
                try
                {
                    XmlTextWriter xtr = new XmlTextWriter(Response.Body, Encoding.UTF8);
                    xtr.WriteStartDocument();
                    xtr.WriteStartElement("urlset");
                    xtr.WriteAttributeString("xmlns", "http://www.sitemaps.org/schemas/sitemap/0.9");
                    xtr.WriteAttributeString("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
                    xtr.WriteAttributeString("xsi:schemaLocation", "http://www.sitemaps.org/schemas/sitemap/0.9 http://www.sitemaps.org/schemas/sitemap/0.9/sitemap.xsd");
                    sb.AppendLine($"Attributeler olusturuldu");

                    string siteUrl = CurrentWebsite.BaseUrl.Replace("www.", "", System.StringComparison.CurrentCultureIgnoreCase);

                    MainPage mainPage = mainPageService.Get(x => x.WebSiteid == CurrentWebsite.id && x.IsActive, CurrentLanguage.id);
                    sb.AppendLine($"Anasayfa bilgisi veritabaninda sorgulandi");
                    if (mainPage != null)
                    {
                        sb.AppendLine($"Anasayfa bilgisi bulundu");
                        xtr.WriteStartElement("url");
                        xtr.WriteElementString("loc", $"{siteUrl}");
                        xtr.WriteElementString("lastmod", $"{(mainPage.UpdateDate ?? mainPage.CreateDate).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}+03:00");
                        xtr.WriteEndElement();
                        sb.AppendLine($"Anasayfa bilgisi yazildi");

                    }


                    AboutUsObject aboutUs = aboutUsObjectService.Get(x => x.WebSiteid == CurrentWebsite.id && x.IsActive, CurrentLanguage.id);
                    sb.AppendLine($"Hakkimizda bilgisi veritabaninda sorgulandi");
                    if (aboutUs != null)
                    {
                        sb.AppendLine($"Hakkimizda bilgisi bulundu");
                        xtr.WriteStartElement("url");
                        xtr.WriteElementString("loc", $"{siteUrl}{Url.Action("AboutUs", "Home")}");
                        xtr.WriteElementString("lastmod", $"{(aboutUs.UpdateDate ?? aboutUs.CreateDate).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}+03:00");
                        xtr.WriteEndElement();
                        sb.AppendLine($"Hakkimizda bilgisi yazildi");
                    }

                    PrivacyPolicyObject privacyPolicyObject = privacyPolicyObjectService.Get(x => x.WebSiteid == CurrentWebsite.id && x.IsActive, CurrentLanguage.id);
                    sb.AppendLine($"Gizlilik bilgisi veritabaninda sorgulandi");
                    if (privacyPolicyObject != null)
                    {
                        sb.AppendLine($"Gizlilik bilgisi bulundu");
                        xtr.WriteStartElement("url");
                        xtr.WriteElementString("loc", $"{siteUrl}{Url.Action("PrivacyPolicy", "Home")}");
                        xtr.WriteElementString("lastmod", $"{(privacyPolicyObject.UpdateDate ?? privacyPolicyObject.CreateDate).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}+03:00");
                        xtr.WriteEndElement();
                        sb.AppendLine($"Gizlilik bilgisi yazildi");
                    }


                    UI_Contact contact = uI_ContactService.Get(x => x.WebSiteid == CurrentWebsite.id && x.IsActive, CurrentLanguage.id);
                    sb.AppendLine($"İletişim bilgisi veritabaninda sorgulandi");
                    if (contact != null)
                    {
                        sb.AppendLine($"İletişim bilgisi bulundu");
                        xtr.WriteStartElement("url");
                        xtr.WriteElementString("loc", $"{siteUrl}{Url.Action("Contact", "Home")}");
                        xtr.WriteElementString("lastmod", $"{(contact.UpdateDate ?? contact.CreateDate).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}+03:00");
                        xtr.WriteEndElement();
                        sb.AppendLine($"İletişim bilgisi yazildi");
                    }

             

                    if (siteUrl.Equals("https://petroteks.com"))
                    {
                        xtr.WriteStartElement("url");
                        xtr.WriteElementString("loc", $"{siteUrl}{Url.Action("SondajKopugu", "Home")}");
                        xtr.WriteEndElement();
                        sb.AppendLine($"SondajKopugu bilgisi yazildi");


                        xtr.WriteStartElement("url");
                        xtr.WriteElementString("loc", $"{siteUrl}{Url.Action("PetroBlog", "Home")}");
                        xtr.WriteEndElement();
                        sb.AppendLine($"PetroBlog bilgisi yazildi");

                    }


                    ICollection<Category> Categories = new List<Category>();
                    sb.AppendLine($"Kategori listesi olusturuldu");
                    try
                    {
                        Categories = categoryService.GetMany(x => x.WebSiteid == CurrentWebsite.id && x.IsActive == true, CurrentLanguage.id);
                        sb.AppendLine($"Kategori listesi veritabanindan dolduruldu");

                        foreach (Category item in Categories)
                        {
                            sb.AppendLine($"{item.Name} kategorisi bilgisi alindi");
                            xtr.WriteStartElement("url");
                            xtr.WriteElementString("loc", $"{siteUrl}{Url.Action("CategoryDetail", "Detail", new { categoryName = GetFriendlyTitle(item.Name), page = 1, category = item.id })}");
                            xtr.WriteElementString("lastmod", $"{(item.UpdateDate ?? item.CreateDate).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}+03:00");
                            xtr.WriteEndElement();
                            sb.AppendLine($"{item.Name} kategorisi bilgisi yazildi");
                        }
                    }
                    catch { }

                    try
                    {

                        ICollection<Product> Products = productService.GetMany(x => x.IsActive == true);
                        sb.AppendLine($"Urun listesi olusturuldu");

                        var WebsiteProducts =
                                            from category in Categories
                                            join prod in Products on category.id equals prod.Categoryid
                                            select new { ProductName = prod.SupTitle, id = prod.id, UpdateDate = prod.UpdateDate, CreateDate = prod.CreateDate };
                        sb.AppendLine($"Urun listesi veritabanindan dolduruldu");


                        foreach (var item in WebsiteProducts)
                        {
                            sb.AppendLine($"{item.ProductName} urun bilgisi alindi");

                            xtr.WriteStartElement("url");
                            xtr.WriteElementString("loc", $"{siteUrl}{Url.Action("ProductDetail", "Detail", new { produtname = GetFriendlyTitle(item.ProductName), id = item.id })}");
                            xtr.WriteElementString("lastmod", $"{(item.UpdateDate ?? item.CreateDate).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}+03:00");
                            xtr.WriteEndElement();
                            sb.AppendLine($"{item.ProductName} urun bilgisi yazildi");
                        }
                    }
                    catch { }

                    try
                    {
                        ICollection<DynamicPage> dynamicPages = dynamicPageService.GetMany(x => x.WebSiteid == CurrentWebsite.id && x.IsActive == true, CurrentLanguage.id);
                        sb.AppendLine($"dinamik sayfalar listesi olusturuldu");

                        foreach (DynamicPage item in dynamicPages)
                        {
                            sb.AppendLine($"{item.Name} sayfasi icin bilgi alindi");
                            xtr.WriteStartElement("url");
                            xtr.WriteElementString("loc", $"{siteUrl}{Url.Action("DynamicPageView", "Home", new { pageName = GetFriendlyTitle(item.Name), id = item.id })}");
                            xtr.WriteElementString("lastmod", $"{(item.UpdateDate ?? item.CreateDate).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}+03:00");
                            xtr.WriteEndElement();
                            sb.AppendLine($"{item.Name} sayfasi icin bilgi yazildi");
                        }
                    }
                    catch { }

                    try
                    {
                        ICollection<Blog> blogs = blogService.GetMany(x => x.WebSiteid == CurrentWebsite.id && x.IsActive == true, CurrentLanguage.id);
                        sb.AppendLine($"Blog listesi veritabanindan alindi");

                        foreach (Blog item in blogs)
                        {
                            sb.AppendLine($"{item.Name} blogunun bilgisi alindi");
                            xtr.WriteStartElement("url");
                            xtr.WriteElementString("loc", $"{siteUrl}{Url.Action("BlogDetail", "Home", new { title = GetFriendlyTitle(item.Title), id = item.id })}");
                            xtr.WriteElementString("lastmod", $"{(item.UpdateDate ?? item.CreateDate).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}+03:00");
                            xtr.WriteEndElement();
                            sb.AppendLine($"{item.Name} blogunun bilgisi yazildi");

                        }
                    }
                    catch { }
                    try
                    {
                        sb.AppendLine("Kapanma islemi basladi");
                        xtr.WriteEndElement();
                        sb.AppendLine("urlset kapatildi");
                        xtr.WriteEndDocument();
                        sb.AppendLine("document kapatildi");
                        xtr.Flush();
                        sb.AppendLine("Flush");
                        xtr.Close();
                        sb.AppendLine("Close");
                    }
                    catch (Exception ex)
                    {
                        sb.AppendLine(ex.Message);
                    }
                }
                catch
                {
                    sb.AppendLine("HATA HATA");
                }
            }
            try
            {
                var dir = Path.Combine(webHostEnvironment.WebRootPath, "HataKontrolLogs");
                Directory.CreateDirectory(dir);
                string logfile = Path.Combine(dir, "Log.txt");
                System.IO.File.WriteAllText(logfile, sb.ToString(), Encoding.UTF8);
            }
            catch
            {
            }

            return View();
        }
    }
}