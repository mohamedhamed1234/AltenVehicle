using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerVehicles.DataAccessLayer
{
    public class VehicleRepository
    {
        public static DataRow[] loadData(string customerId)
        {

            string xmlData = XmlData.VehicleData;

            var xml = new MemoryStream(Encoding.Unicode.GetBytes(xmlData));

            DataSet dataSet = new DataSet();

            dataSet.ReadXml(xml);

            DataTable tblMEN = dataSet.Tables["Vehicle"];
            DataRow[] results = tblMEN.Select("CustomerId = '" + customerId + "'");

            return results;
        }
    }
}
