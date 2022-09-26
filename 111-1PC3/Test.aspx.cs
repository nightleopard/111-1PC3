using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC3
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i_Clothes = 300;
            int i_Hat = 350;
            int i_Pants = 400;
            int sum = i_Clothes + i_Hat + i_Pants;
            Response.Write("sum");
        }
    }
}