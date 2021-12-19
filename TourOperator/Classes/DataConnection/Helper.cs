using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourOperator.Data;

namespace TourOperator.Classes.DataConnection
{
    public class Helper
    {
        private static TourOperatorEntities _tourOperatorEntities;

        public static TourOperatorEntities GetContext()
        {
            if (_tourOperatorEntities == null)
                _tourOperatorEntities = new TourOperatorEntities();

            return _tourOperatorEntities;
        }
    }
}
