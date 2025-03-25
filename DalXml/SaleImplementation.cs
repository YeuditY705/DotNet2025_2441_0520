using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using DalApi;
using DO;

namespace Dal;

internal class SaleImplemention : ISale
{
    static string filePath = @"..\xml\sales.xml";
    static XElement saleXml = XElement.Load(filePath);
    //static List<Sale> sales = ;

    private const string SALE = "sale";
    private const string SALE_ID = "saleId";
    private const string PRODUCT_ID = "productId";
    private const string QUANTITY_FOR_SALE = "quantityForSale";
    private const string PRICE_IN_SALE = "priceInSale";
    private const string IS_FOR_EVERYONE = "isForEveryOne";
    private const string START_DATE_FOR_SALE = "startDateForSale";
    private const string END_DATE_FOR_SALE = "endDateForSale";


    public int Create(Sale item)
    {
        try
        {

            if (File.Exists(filePath))
            {
                item = item with { saleId = Config.nextSaleId };
                saleXml.Add(new XElement(SALE,
                new XElement(SALE_ID, item.productId),
                new XElement(PRODUCT_ID, item.productId),
                new XElement(QUANTITY_FOR_SALE, item.quantityForSale),
                new XElement(PRICE_IN_SALE, item.priceInSale),
                new XElement(IS_FOR_EVERYONE, item.isForEveryOne),
                new XElement(START_DATE_FOR_SALE, item.startDateForSale),
                new XElement(END_DATE_FOR_SALE, item.endDateForSale)));
            }
            return item.saleId;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void Delete(int id)
    {
        try
        {
            if (File.Exists(filePath))
            {
                if (Read(id) != null)
                    saleXml.Elements().Single(s => s.Element(SALE_ID).Value.Equals(id)).Remove();
            }
        }

        catch (Exception ex)
        {
            throw ex;
        }
    }

    public Sale? Read(int id)
    {
        try
        {
            if (File.Exists(filePath))
            {

                XElement saleFound = saleXml.Descendants(SALE).Single(s => s.Element(SALE_ID).Value == id.ToString());
                if (saleFound != null)
                    return new Sale((int)saleFound.Element(SALE_ID),
                        (int)saleFound.Element(PRODUCT_ID),
                        (int)saleFound.Element(QUANTITY_FOR_SALE),
                        (int)saleFound.Element(PRICE_IN_SALE),
                        (bool)saleFound.Element(IS_FOR_EVERYONE),
                        (DateTime)saleFound.Element(name: START_DATE_FOR_SALE),
                        (DateTime)saleFound.Element(END_DATE_FOR_SALE));
                else throw new DO.DalIdNotExists("id not exist");
            }

            return null;
        }

        catch (Exception ex)
        {
            throw ex;
        }
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        try
        {
            if (File.Exists(filePath))
            {
                List<Sale> listFoundSales = saleXml.Elements(SALE).Select(saleFound =>
                new Sale((int)saleFound.Element(SALE_ID),
                        (int)saleFound.Element(PRODUCT_ID),
                        (int)saleFound.Element(QUANTITY_FOR_SALE),
                        (int)saleFound.Element(PRICE_IN_SALE),
                        (bool)saleFound.Element(IS_FOR_EVERYONE),
                        (DateTime)saleFound.Element(START_DATE_FOR_SALE),
                        (DateTime)saleFound.Element(END_DATE_FOR_SALE))).ToList();

                return listFoundSales.FirstOrDefault(filter);

            }
            return null;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        try
        {
            if (File.Exists(filePath))
            {
                
                List<Sale> listFoundSales = saleXml.Elements(SALE).Select(saleFound =>
                new Sale((int)saleFound.Element(SALE_ID),
                        (int)saleFound.Element(PRODUCT_ID),
                        (int)saleFound.Element(QUANTITY_FOR_SALE),
                        (int)saleFound.Element(PRICE_IN_SALE),
                        (bool)saleFound.Element(IS_FOR_EVERYONE),
                        (DateTime)saleFound.Element(START_DATE_FOR_SALE),
                        (DateTime)saleFound.Element(END_DATE_FOR_SALE))).ToList();
                if(filter != null) 
                return (from s in listFoundSales
                        where filter(s)
                        select s).ToList();
                else
                    return listFoundSales;
            }
            return null;

        }
        catch (Exception ex)
        {
            throw ex;
        }

    }

    public void Update(Sale item)
    {

        try
        {
            if (File.Exists(filePath))
            {
                XElement sale = saleXml.Elements().SingleOrDefault(s => s.Element(SALE_ID).Value == item.saleId.ToString());
                if (sale != null)
                {
                    sale.Element(PRODUCT_ID).SetValue(item.productId);
                    sale.Element(QUANTITY_FOR_SALE).SetValue(item.quantityForSale);
                    sale.Element(PRICE_IN_SALE).SetValue(item.priceInSale);
                    sale.Element(IS_FOR_EVERYONE).SetValue(item.isForEveryOne);
                    sale.Element(START_DATE_FOR_SALE).SetValue(item.startDateForSale);
                    sale.Element(END_DATE_FOR_SALE).SetValue(item.endDateForSale);
                }
                else throw new DO.DalIdNotExists("id not exist");
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }


    }
}
