using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerVehicles.DataAccessLayer
{
    /// <summary>
    /// In memory Data representation
    /// </summary>
    public static class XmlData
    {
        public static string VehicleData = @"<Vehicles><Vehicle><Id>1</Id><VehicleId>VLUR4X20009048066</VehicleId><RegNo>GHI789</RegNo><Status></Status><CustomerId>1</CustomerId><CustomerName>Kalles Grustransporter AB</CustomerName><CustomerAddress>Cementvägen 8, 111 11 Södertälje</CustomerAddress></Vehicle><Vehicle><Id>2</Id><VehicleId>YS2R4X20005399401</VehicleId><RegNo>ABC123</RegNo><Status></Status><CustomerId>1</CustomerId><CustomerName>Kalles Grustransporter AB</CustomerName><CustomerAddress>Cementvägen 8, 111 11 Södertälje</CustomerAddress></Vehicle><Vehicle><Id>3</Id><VehicleId>VLUR4X20009093588</VehicleId> <RegNo>DEF456</RegNo><Status></Status><CustomerId>1</CustomerId><CustomerName>Kalles Grustransporter AB</CustomerName><CustomerAddress>Cementvägen 8, 111 11 Södertälje</CustomerAddress></Vehicle><Vehicle><Id>4</Id><VehicleId>YS2R4X20005388011</VehicleId><RegNo>JKL012</RegNo><Status></Status><CustomerId>2</CustomerId><CustomerName>Johans Bulk AB</CustomerName><CustomerAddress>Balkvägen 12, 222 22 Stockholm</CustomerAddress></Vehicle><Vehicle><Id>5</Id><VehicleId>YS2R4X20005387949</VehicleId><RegNo>MNO345</RegNo><Status></Status><CustomerId>2</CustomerId><CustomerName>Johans Bulk AB</CustomerName><CustomerAddress>Balkvägen 12, 222 22 Stockholm</CustomerAddress></Vehicle><Vehicle><Id>6</Id><VehicleId>VLUR4X20009048066</VehicleId><RegNo>PQR678</RegNo><Status></Status><CustomerId>3</CustomerId><CustomerName>Haralds Värdetransporter AB</CustomerName><CustomerAddress>Budgetvägen 1, 333 33 Uppsala</CustomerAddress></Vehicle><Vehicle><Id>7</Id><VehicleId>YS2R4X20005387055</VehicleId><RegNo>STU901</RegNo><Status></Status><CustomerId>3</CustomerId><CustomerName>Haralds Värdetransporter AB</CustomerName><CustomerAddress>Budgetvägen 1, 333 33 Uppsala</CustomerAddress></Vehicle></Vehicles>";

    }
}
