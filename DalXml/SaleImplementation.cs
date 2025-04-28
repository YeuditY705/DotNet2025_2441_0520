using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using DalApi;
using DO;
using Tools;
using System.Reflection;

namespace Dal;

internal class SaleImplementation : ISale
{
    static string filePath = @"..\xml\sales.xml";
    static XElement saleXml = XElement.Load(filePath);

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
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Entering the function to create a sale");

            if (File.Exists(filePath))
            {
                item = item with { saleId = Config.nextSaleId };
                saleXml.Add(new XElement(SALE,
                new XElement(SALE_ID, item.saleId),
                new XElement(PRODUCT_ID, item.productId),
                new XElement(QUANTITY_FOR_SALE, item.quantityForSale),
                new XElement(PRICE_IN_SALE, item.priceInSale),
                new XElement(IS_FOR_EVERYONE, item.isForEveryOne),
                new XElement(START_DATE_FOR_SALE, item.startDateForSale),
                new XElement(END_DATE_FOR_SALE, item.endDateForSale)));
                saleXml.Save(filePath);
            }

            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to create a sale");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
            return item.saleId;
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to create sale: {ex.Message}");
            throw;
        }
    }

    public void Delete(int id)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Entering the function to delete a sale");

            if (File.Exists(filePath))
            {
                if (Read(id) != null)
                {
                    saleXml.Elements().FirstOrDefault(s => s.Element(SALE_ID).Value == (id.ToString())).Remove();
                    saleXml.Save(filePath);
                }
            }

            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to delete a sale");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to delete sale: {ex.Message}");
            throw;
        }
    }

    public Sale? Read(int id)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Entering the function to read a sale");

            if (File.Exists(filePath))
            {
                XElement saleFound = saleXml.Descendants(SALE).FirstOrDefault(s => s.Element(SALE_ID).Value == id.ToString());
                if (saleFound != null)
                {
                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read a sale");
                    return new Sale((int)saleFound.Element(SALE_ID),
                        (int)saleFound.Element(PRODUCT_ID),
                        (int)saleFound.Element(QUANTITY_FOR_SALE),
                        (int)saleFound.Element(PRICE_IN_SALE),
                        (bool)saleFound.Element(IS_FOR_EVERYONE),
                        (DateTime)saleFound.Element(START_DATE_FOR_SALE),
                        (DateTime)saleFound.Element(END_DATE_FOR_SALE));
                }
                else
                {
                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed to read sale: id does not exist");
                    throw new DO.DalIdNotExists("id not exist");
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to read sale: {ex.Message}");
            throw;
        }
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Entering the function to read a sale with filter");

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

                Sale? foundSale = listFoundSales.FirstOrDefault(filter);
                LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read a sale with filter");
                return foundSale;
            }
            return null;
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to read sale with filter: {ex.Message}");
            throw;
        }
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Entering the function to read all sales");

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

                if (filter != null)
                {
                    var filteredList = listFoundSales.Where(filter).ToList();
                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read all sales with filter");
                    return filteredList;
                }
                LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read all sales");
                return listFoundSales;
            }
            return null;
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to read all sales: {ex.Message}");
            throw;
        }
    }

    public void Update(Sale item)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Entering the function to update a sale");

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
                    saleXml.Save(filePath);
                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to update a sale");
                }
                else
                {
                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed to update sale: id does not exist");
                    throw new DO.DalIdNotExists("id not exist");
                }
            }
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to update sale: {ex.Message}");
            throw;
        }
    }
}
