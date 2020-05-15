using Foundation;
using System;
using System.Threading.Tasks;
using UIKit;

namespace WebViewApp
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            LoadPageWithCookies();
        }

        private void LoadPageWithCookies()
        {
            var cookie = new NSHttpCookie(
               name: "test-xamarin-cookie",
               value: "test-xamarin-cookie-value",
               path: "/",
               domain: "127.0.0.1");
            webView.Configuration.WebsiteDataStore.HttpCookieStore.SetCookie(cookie, null);
            webView.LoadRequest(new NSUrlRequest(new NSUrl("http://127.0.0.1:5500/ProtectedWebSite/index.html")));
        }
    }
}