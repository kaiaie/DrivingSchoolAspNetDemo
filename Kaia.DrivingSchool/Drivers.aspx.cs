using Kaia.DrivingSchool.Data.Repositories;
using Kaia.DrivingSchool.WebUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kaia.DrivingSchool
{
    public partial class Drivers : Page1<IDriverRepository>
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DriverDataSource_ObjectCreating(object sender, ObjectDataSourceEventArgs e)
        {
            e.ObjectInstance = Repository1;
        }
    }
}