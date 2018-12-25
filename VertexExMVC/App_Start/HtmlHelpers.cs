using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpressMVC
{
    public static class HtmlHelpers
    {
        private class ScriptBlock : IDisposable
        {
            private const string scriptsKey = "scripts";

            public static List<string> pageScripts
            {
                get
                {
                    if (HttpContext.Current.Items[scriptsKey] == null)
                        HttpContext.Current.Items[scriptsKey] = new List<string>();
                    return (List<string>)HttpContext.Current.Items[scriptsKey];
                }
            }

            private WebViewPage webPageBase;

            public ScriptBlock(WebViewPage webPageBase)
            {
                this.webPageBase = webPageBase;
                this.webPageBase.OutputStack.Push(new StringWriter());
            }

            public void Dispose()
            {
                pageScripts.Add(((StringWriter)this.webPageBase.OutputStack.Pop()).ToString());
            }
        }

        private class CssBlock : IDisposable
        {
            private const string scriptsKey = "css";

            public static List<string> pageCss
            {
                get
                {
                    if (HttpContext.Current.Items[scriptsKey] == null)
                        HttpContext.Current.Items[scriptsKey] = new List<string>();
                    return (List<string>)HttpContext.Current.Items[scriptsKey];
                }
            }

            private WebViewPage webPageBase;

            public CssBlock(WebViewPage webPageBase)
            {
                this.webPageBase = webPageBase;
                this.webPageBase.OutputStack.Push(new StringWriter());
            }

            public void Dispose()
            {
                pageCss.Add(((StringWriter)this.webPageBase.OutputStack.Pop()).ToString());
            }
        }

        private class ContentBlock : IDisposable
        {
            private static string scriptsKey = "content";

            public static List<string> pageContent(string key)
            {
                scriptsKey = key;
                if (HttpContext.Current.Items[key] == null)
                    HttpContext.Current.Items[key] = new List<string>();
                return (List<string>)HttpContext.Current.Items[key];
            }

            private WebViewPage webPageBase;

            public ContentBlock(WebViewPage webPageBase, string key)
            {
                scriptsKey = key;
                this.webPageBase = webPageBase;
                this.webPageBase.OutputStack.Push(new StringWriter());
            }

            public void Dispose()
            {
                pageContent(scriptsKey).Add(((StringWriter)this.webPageBase.OutputStack.Pop()).ToString());
            }
        }

        public static IDisposable BeginCss(this HtmlHelper helper)
        {
            return new CssBlock((WebViewPage)helper.ViewDataContainer);
        }

        public static IDisposable BeginScripts(this HtmlHelper helper)
        {
            return new ScriptBlock((WebViewPage)helper.ViewDataContainer);
        }

        public static MvcHtmlString PageCss(this HtmlHelper helper)
        {
            return MvcHtmlString.Create(string.Join(Environment.NewLine, CssBlock.pageCss.Select(s => s.ToString())));
        }

        public static MvcHtmlString PageScripts(this HtmlHelper helper)
        {
            return MvcHtmlString.Create(string.Join(Environment.NewLine, ScriptBlock.pageScripts.Select(s => s.ToString())));
        }

        public static IDisposable BeginContent(this HtmlHelper helper, string key)
        {
            return new ContentBlock((WebViewPage)helper.ViewDataContainer, key);
        }

        public static MvcHtmlString PageContent(this HtmlHelper helper, string key)
        {
            return MvcHtmlString.Create(string.Join(Environment.NewLine, ContentBlock.pageContent(key).Select(s => s.ToString())));
        }
    }
}