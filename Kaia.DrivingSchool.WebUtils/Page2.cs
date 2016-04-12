using NLog;

namespace Kaia.DrivingSchool.WebUtils
{
    /// <summary>
    /// Webforms page with two data sources
    /// </summary>
    /// <typeparam name="T1">Type of first data source</typeparam>
    /// <typeparam name="T2">Type of second data source</typeparam>
    public abstract class Page2<T1, T2> : PageBase
    {
        public T1 Repository1 { get; set; }

        public T2 Repository2 { get; set; }
    }
}
