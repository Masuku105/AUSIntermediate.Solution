using AUSIntermediate.Solution.Web.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.IO;

namespace AUSIntermediate.Solution.Web.MVC.Controllers
{
    public class BaseController : Controller
    {
        public void Notify(string message, string title = "Alert",
            NotificationType type = NotificationType.Success)
        {
            var notification = new
            {
                message = message,
                title = title,
                type = type.ToString(),
                icon = type.ToString(),
                provider = GetProvider()
            };
            TempData["Message"] = JsonConvert.SerializeObject(notification);
        }

        private object GetProvider()
        {
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                              .AddEnvironmentVariables();

            IConfiguration configuration = builder.Build();
            var value = configuration["NotificationProvider"];
            return value;
        }
    }
}
