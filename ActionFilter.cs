using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomFilter
{
    public class ActionFilter : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            StreamWriter obj = new StreamWriter(filterContext.HttpContext.Server.MapPath("~/log.txt"), true);
            obj.WriteLine(DateTime.Now);
            obj.WriteLine("OnActionExecuted");
            obj.WriteLine(filterContext.HttpContext.Request.Url);
            obj.Close();
            base.OnActionExecuted(filterContext);
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            StreamWriter obj = new StreamWriter(filterContext.HttpContext.Server.MapPath("~/log.txt"), true);
            obj.WriteLine("OnActionExecuting");
            obj.WriteLine(DateTime.Now);
            obj.WriteLine(filterContext.HttpContext.Request.Url);
            obj.Close();
        }




        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            StreamWriter obj = new StreamWriter(filterContext.HttpContext.Server.MapPath("~/log.txt"), true);
            obj.WriteLine("OnResultExecuted");
            obj.WriteLine(DateTime.Now);
            obj.WriteLine(filterContext.HttpContext.Request.Url);
            obj.Close();
        }





        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            StreamWriter obj = new StreamWriter(filterContext.HttpContext.Server.MapPath("~/log.txt"), true);
            obj.WriteLine("OnResultExecuted");
            obj.WriteLine(DateTime.Now);
            obj.WriteLine(filterContext.HttpContext.Request.Url);
            obj.Close();
        }



    }
}
