using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using quentinrider.ViewModules;
using quentinrider.Lib.UI;

namespace quentinrider.ViewModules
{
    public class BaseModule : IViewModule
    {
        protected JavaScriptRenderer JS = new JavaScriptRenderer();
        protected CssStylesRenderer CSS = new CssStylesRenderer();
        public BaseModule() {
            JS.Add(
                JavaScriptFiles.JQuery,
                JavaScriptFiles.JQueryUI,
                JavaScriptFiles.JQueryValidate
            );
            CSS.Add(
                CssStyleFiles.Layout
            );
        }

        public string Render()
        {
            return "";
        }

        public string GetScripts() {
            return JS.ToString();
        }

        public string GetStyles(){
            return CSS.ToString();
        }


    }
}