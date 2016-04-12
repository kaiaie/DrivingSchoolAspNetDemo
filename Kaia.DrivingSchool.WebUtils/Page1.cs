using System.Web.UI;

namespace Kaia.DrivingSchool.WebUtils
{
    /// <summary>
    /// Webforms page with single data source
    /// </summary>
    /// <typeparam name="T1">Type of data source</typeparam>
    public abstract class Page1<T1>: Page
    {
        public T1 Repository1 { get; set; }
    }
}
