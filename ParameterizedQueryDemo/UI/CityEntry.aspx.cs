using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ParameterizedQueryDemo.BLL;
using ParameterizedQueryDemo.Models;

namespace ParameterizedQueryDemo.UI
{
    public partial class CityEntry : System.Web.UI.Page
    {
        CityManager cityManager=new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton1_Click(object sender, EventArgs e)
        {
            City city=new City();
            city.Name = cNameTextBox.Text;
            city.About = aboutTextBox.Text;
            city.Country = countryTextBox.Text;
            string message = cityManager.Save(city);
            msgLabel.Text = message;
        }
    }
}