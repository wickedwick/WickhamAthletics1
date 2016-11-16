using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WickhamAthletics.Models;
using WickhamAthletics.DataAccess;

namespace WickhamAthletics.BusinessLogic
{
    public class SpecialPageManager
    {
        public static CharityView GetCharityViewData()
        {
            CharityView view = null;

            view = CharityViewData.GetCharityView();

            return view;
        }
    }
}