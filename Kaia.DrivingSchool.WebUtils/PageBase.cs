using System.Web.UI;
using NLog;

namespace Kaia.DrivingSchool.WebUtils
{
    /// <summary>
    /// Base class for Webforms pages
    /// </summary>
    public abstract class PageBase : Page
    {
        private readonly ILogger _logger;

        public PageBase()
        {
            _logger = LogManager.GetLogger(GetType().BaseType?.FullName ?? GetType().Name);
        }
    }
}
