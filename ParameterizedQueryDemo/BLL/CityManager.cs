using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ParameterizedQueryDemo.DAL;
using ParameterizedQueryDemo.Models;

namespace ParameterizedQueryDemo.BLL
{
    public class CityManager
    {
        CityGateway cityGateway=new CityGateway();

        public string Save(City city)
        {
            string message = "";
            int row = cityGateway.Insert(city);
            if (row>0)
            {
                message = "Saved Successful";
            }
            else
            {
                message = "Saved failed";
            }
           return message;
        }
    }
}