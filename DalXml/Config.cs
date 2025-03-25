using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal;

internal static class Config
{
    private static string file_name = "../xml/data-config.xml";
    public static int nextProductId
    {
        get
        {
            XElement xml = XElement.Load(file_name);
            int nextId = (int)xml.Element("NextProductId");
            xml.Element("NextProductId").SetValue((nextId + 1).ToString()) ;
            xml.Save(file_name);
            return nextId;
        }
    }
    public static int nextSaleId
    {
        get
        {
            XElement xml = XElement.Load(file_name);
            int nextId = (int)xml.Element("NextSaleId");
            xml.Element("NextSaleId").SetValue((nextId + 1).ToString())  ;
            xml.Save(file_name);
            return nextId;
        }
    }

}
