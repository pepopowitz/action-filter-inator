using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFilterInator.ActionFilters
{
    public class QsToggleAttribute : ActionFilterAttribute
    {
        //pgpgpg - this is an action filter that will look at the querystring to determine if your param is present. if it is there, and equal to "auth", it will add a value to your ViewData collection.
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string value = string.Empty; 
            if (filterContext.HttpContext.Request.QueryString["qsToggle"] != null)
            {
                value = filterContext.HttpContext.Request.QueryString["qsToggle"];
                //this is a safety, in case you misspell auth, so that it doesn't try to serve up _layoutath.cshtml and blow up. it'll fall back to _layout.cshtml, instead.
                if (value.ToLower() != "auth")
                {
                    value = string.Empty;
                }
            }

            filterContext.Controller.ViewData["vdToggle"] = value;
        }
    }
}