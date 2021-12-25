using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder
{
    public class ReportData<T>
    {
        public ReportData( )
        {

        }
        public ReportData( Dictionary<string, string> parms, List<T> data )
        {
            Parms = parms;
            Data = data;
        }
        public Dictionary<string,string> Parms { get; set; }
        public List<T> Data { get; set; }
        public string GetParmsValue( string key )
        {
            if(Parms != null && Parms.ContainsKey( key ))
                return Parms[key];
            else
                return "";
        }
        public string GetDataValue(object dataItem,string key )
        {
            var value = dataItem.GetType( ).GetProperty( key ).GetValue( dataItem, null );
            
            if(value == null)
                return "";

            return value.ToString( );

        }

    }

}
