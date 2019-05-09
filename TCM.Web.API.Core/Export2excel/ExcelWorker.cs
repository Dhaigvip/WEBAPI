using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TCM.Web.API.Core.Helpers;

namespace TCM.Web.API.Core.Export2excel
{
    public class ExcelWorker : IExport
    {
        public IConfiguration Configuration { get; }
        public ExcelWorker()
        {
           
        }

        #region Constants
        private const string rootFolder = @"Downloads";
        private const string tempPrefix = "tmp_";
        private const string DataKeySeprator = "§"; //alt + 167
        private const string fileExtension = ".xlsx";
        private const string SystemType = "System.";
        #endregion Constants

        #region IExport Members

        public bool Export<T>(List<T> list, ExtendedGridProperties extendedGridProperties)
        {
            return CreateExcelDocument(list, extendedGridProperties);
        }

        public MemoryStream CreateStream(IList list, ExtendedGridProperties extendedGridProperties)
        {
            return GenerateExcelStream(list, extendedGridProperties);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Creates Excel documents from given list
        /// </summary>
        /// <typeparam name="T">Type of list which is exported in excel</typeparam>
        /// <param name="list">list which is exported in excel</param>
        /// <param name="grid">ExtendedGridProperties object for column mapping</param>
        /// <returns></returns>
        private bool CreateExcelDocument<T>(List<T> list, ExtendedGridProperties extendedGridProperties)
        {
            //Get the Container
            //TELogger = UnityHelper.Container.Resolve<TCM.Web.Application.Interfaces.ILogger>();
            return WriteToExcel(list, extendedGridProperties);
        }

        private MemoryStream GenerateExcelStream(IList lstDataSource, ExtendedGridProperties extendedGridProperties)
        {

            MemoryStream excelDoc = new MemoryStream();
            // Dictionary<string, ExportColumn> columnDetails = extendedGridProperties.dictExportColumn;

            using (SpreadsheetDocument spreadsheet = SpreadsheetDocument.Create(excelDoc, SpreadsheetDocumentType.Workbook))
            {
                //create workbook part
                WorkbookPart wbp = spreadsheet.AddWorkbookPart();
                wbp.Workbook = new Workbook();
                Sheets sheets = wbp.Workbook.AppendChild<Sheets>(new Sheets());

                //create worksheet part, and add it to the sheets collection in workbook
                WorksheetPart wsp = wbp.AddNewPart<WorksheetPart>();
                Sheet sheet = new Sheet() { Id = spreadsheet.WorkbookPart.GetIdOfPart(wsp), SheetId = 1, Name = "TCMData(1)" };
                sheets.Append(sheet);

                OpenXmlWriter writer = OpenXmlWriter.Create(wsp);
                writer.WriteStartElement(new Worksheet());//Start of Worksheet
                writer.WriteStartElement(new SheetData());//Start of SheetData


                List<string> lstHeaderTexts = GetHeaderRow(extendedGridProperties.ExportColumns); // header row texts
                WriteTableHeader(writer, lstHeaderTexts);
                #region Write Rows
                for (int listIndex = 0; listIndex < lstDataSource.Count; listIndex++)
                {
                    writer.WriteStartElement(new Row());
                    foreach (var dicItem in extendedGridProperties.ExportColumns)
                    {
                        CellValues dataType = CellValues.String;
                        object cellValue = null;
                        try
                        {
                            cellValue = GetCellValue(lstDataSource[listIndex], dicItem.PropertyName, out dataType);
                        }
                        catch (Exception ex)
                        {

                        }
                        if (dataType == CellValues.Date)
                        {
                            writer.WriteElement(new Cell { CellValue = new CellValue((cellValue == null ? string.Empty : Convert.ToString(cellValue, System.Globalization.CultureInfo.CurrentCulture))), DataType = CellValues.String });
                        }
                        else
                        {
                            writer.WriteElement(new Cell { CellValue = new CellValue((cellValue == null ? string.Empty : Convert.ToString(cellValue, System.Globalization.CultureInfo.InvariantCulture))), DataType = dataType });
                        }
                    }
                    writer.WriteEndElement(); //end of Row
                }
                #endregion Write Rows
                writer.WriteEndElement(); //end of SheetData
                writer.WriteEndElement(); //end of worksheet
                writer.Close();
            }
            return excelDoc;
        }

        /// <summary>
        /// Writes data to excel
        /// </summary>
        /// <typeparam name="T">The type of datasource</typeparam>
        /// <param name="lstDataSource">The data source</param>
        /// <param name="extendedGridProperties">The extended grid properties</param>
        private bool WriteToExcel<T>(List<T> lstDataSource, ExtendedGridProperties extendedGridProperties)
        {
            bool isSucess = false;
            string filePath = extendedGridProperties.ServerMapPath;
            string fileName = GenerateFileName(extendedGridProperties.ExtUserName, extendedGridProperties.ExportFileNameInAsync);
            string tmpFileName = string.Format("{0}\\{1}{2}{3}", filePath, tempPrefix, DateTime.Now.Ticks.ToString(), fileExtension);

            //Dictionary<string, ExportColumn> columnDetails = extendedGridProperties.dictExportColumn;
            using (SpreadsheetDocument spreadsheet = SpreadsheetDocument.Create(tmpFileName, SpreadsheetDocumentType.Workbook))
            {
                //create workbook part
                WorkbookPart wbp = spreadsheet.AddWorkbookPart();
                wbp.Workbook = new Workbook();
                Sheets sheets = wbp.Workbook.AppendChild<Sheets>(new Sheets());

                //create worksheet part, and add it to the sheets collection in workbook
                WorksheetPart wsp = wbp.AddNewPart<WorksheetPart>();
                Sheet sheet = new Sheet() { Id = spreadsheet.WorkbookPart.GetIdOfPart(wsp), SheetId = 1, Name = "TCMData(1)" };
                sheets.Append(sheet);

                OpenXmlWriter writer = OpenXmlWriter.Create(wsp);
                writer.WriteStartElement(new Worksheet());//Start of Worksheet
                writer.WriteStartElement(new SheetData());//Start of SheetData


                List<string> lstHeaderTexts = GetHeaderRow(extendedGridProperties.ExportColumns); // header row texts
                WriteTableHeader(writer, lstHeaderTexts);
                #region Write Rows
                for (int listIndex = 0; listIndex < lstDataSource.Count; listIndex++)
                {
                    writer.WriteStartElement(new Row());
                    foreach (var dicItem in extendedGridProperties.ExportColumns)
                    {
                        CellValues dataType = CellValues.String;
                        object cellValue = GetCellValue(lstDataSource[listIndex], dicItem.PropertyName, out dataType);
                        if (dataType == CellValues.Date)
                        {
                            writer.WriteElement(new Cell { CellValue = new CellValue((cellValue == null ? string.Empty : Convert.ToString(cellValue, System.Globalization.CultureInfo.CurrentCulture))), DataType = CellValues.String });
                        }
                        else
                        {
                            writer.WriteElement(new Cell { CellValue = new CellValue((cellValue == null ? string.Empty : Convert.ToString(cellValue, System.Globalization.CultureInfo.InvariantCulture))), DataType = dataType });
                        }
                    }
                    writer.WriteEndElement(); //end of Row
                }
                #endregion Write Rows
                writer.WriteEndElement(); //end of SheetData
                writer.WriteEndElement(); //end of worksheet
                writer.Close();
            }

            FileInfo file = new FileInfo(tmpFileName);
            file.MoveTo(filePath + "\\" + fileName);
            isSucess = true;
            return isSucess;
        }

        /// <summary>
        /// Generates the file name with the use of current username and DTO name
        /// </summary>
        /// <param name="userName">current user name</param>
        /// <param name="fileName">DTO name or file name. AsyncFileName property of grid</param>
        /// <returns></returns>
        private string GenerateFileName(string userName, string fileName)
        {
            string formattedFileName = string.Empty;
            userName = Regex.Replace(userName, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
            formattedFileName = string.Format("{0}_{1}_{2}" + fileExtension, userName, fileName, DateTime.Now.ToString("MM.dd.yyyy_hh.mm.ss"));

            return formattedFileName;
        }

        /// <summary>
        /// Gets Header text for Header row
        /// </summary>
        /// <param name="columnDetails">Column details</param>
        /// <returns>Header text</returns>
        private List<string> GetHeaderRow(List<ExportColumn> columnDetails)
        {
            List<string> lstHeaderRowColumnNames = new List<string>();
            foreach (var dicItem in columnDetails)
            {
                lstHeaderRowColumnNames.Add(dicItem.HeaderText);
            }
            return lstHeaderRowColumnNames;
        }

        /// <summary>
        /// Writes the header row to Excel
        /// </summary>
        /// <param name="writer">Writer to write</param>
        /// <param name="lstHeaderRowTexts">List of header text</param>
        private void WriteTableHeader(OpenXmlWriter writer, List<string> lstHeaderRowTexts)
        {
            writer.WriteStartElement(new Row());
            for (int listIndex = 0; listIndex < lstHeaderRowTexts.Count; listIndex++)
            {
                writer.WriteElement(new Cell { CellValue = new CellValue(lstHeaderRowTexts[listIndex]), DataType = CellValues.String });
            }
            writer.WriteEndElement(); //end of Row
        }






       /// <summary>
       /// 
       /// </summary>
       /// <param name="listItem"></param>
       /// <param name="dataField"></param>
       /// <param name="cellType"></param>
       /// <returns></returns>
        private object GetCellValue(object listItem, string dataField, out CellValues cellType)
        {
            string propertyName = GetDataKey(dataField);
            PropertyInfo PropInfo = listItem.GetType().GetProperty(propertyName);
            cellType = CellValues.String;
            if (propertyName.Contains("."))
            {
                if (propertyName.Contains("[0]"))
                    propertyName = propertyName.Replace("[0]", "");

                string[] propertyNameHierarchy = propertyName.Split('.');

                if (listItem.GetType().GetProperties().Any(a => a.Name == propertyNameHierarchy[0]))
                {
                    PropertyInfo piSubDto = listItem.GetType().GetProperties().FirstOrDefault(a => a.Name == propertyNameHierarchy[0]);
                    if (piSubDto != null)
                    {
                        object objSubDto = piSubDto.GetValue(listItem, null);

                        if (objSubDto.GetType().IsGenericType) //if property is a generic collection like List
                        {
                            var nestedPropValueList = objSubDto as IList;
                            if (nestedPropValueList != null && nestedPropValueList.Count > 0)
                            {
                                foreach (var item in nestedPropValueList)
                                {
                                    for (int propertyNameHierarchyIndex = 1; propertyNameHierarchyIndex <= propertyNameHierarchy.Length - 1; propertyNameHierarchyIndex++)
                                    {
                                        PropertyInfo piSubSubDto = item.GetType().GetProperty(propertyNameHierarchy[propertyNameHierarchyIndex]);
                                        if (propertyNameHierarchyIndex == propertyNameHierarchy.Length - 1)
                                        {
                                            return piSubSubDto.GetValue(item, null);
                                        }
                                    }
                                }
                            }
                        }
                        else // for non generic properties like string,int, complex object etc.
                        {
                            for (int propertyNameHierarchyIndex = 1; propertyNameHierarchyIndex <= propertyNameHierarchy.Length - 1; propertyNameHierarchyIndex++)
                            {
                                var piSubSubDto = objSubDto.GetType().GetProperty(propertyNameHierarchy[propertyNameHierarchyIndex]);
                                if (propertyNameHierarchyIndex == propertyNameHierarchy.Length - 1)
                                {
                                    return piSubSubDto.GetValue(objSubDto, null);
                                }
                            }
                        }
                    }
                }
            }
            else if (PropInfo != null && !PropInfo.PropertyType.FullName.StartsWith(SystemType))
            {
                PropertyInfo piSubDto = listItem.GetType().GetProperty(propertyName);
                object objSubDto = piSubDto.GetValue(listItem, null);
                List<PropertyInfo> propList = piSubDto.PropertyType.GetProperties().Where(p => p.PropertyType != typeof(ExtensionDataObject)).ToList();
                if (propList != null && propList.Any(pr => Nullable.GetUnderlyingType(pr.PropertyType) != null))
                {
                    foreach (PropertyInfo piIdentity in propList)
                    {
                        if (Nullable.GetUnderlyingType(piIdentity.PropertyType) != null)
                        {
                            return piIdentity.GetValue(objSubDto, null);
                        }
                    }
                }
                else
                {
                    return propList[0].GetValue(objSubDto, null);
                }
            }
            else
            {

                PropertyInfo pi = listItem.GetType().GetProperty(propertyName);
                if (pi != null)
                {
                    if (pi.PropertyType.FullName.Contains("Int16")
                        || pi.PropertyType.FullName.Contains("Int32")
                        || pi.PropertyType.FullName.Contains("Int64")
                        || pi.PropertyType.FullName.Contains("Byte")
                        || pi.PropertyType.FullName.Contains("Decimal"))
                    {
                        cellType = CellValues.Number;
                    }
                    if (pi.PropertyType.FullName.Contains("Date"))
                    {
                        cellType = CellValues.Date;
                    }
                    return pi.GetValue(listItem, null);
                }

            }
            return null;
        }

        /// <summary>
        /// Get the property name from key. if it is seprated by § then it returns before value of the §.
        /// </summary>
        /// <param name="dataKey">key of the dictionary</param>
        /// <returns>property name</returns>
        private string GetDataKey(string dataKey)
        {
            if (!string.IsNullOrEmpty(dataKey))
            {
                if (dataKey.Contains(DataKeySeprator))
                {
                    string[] arrKeys = dataKey.Split(new string[] { DataKeySeprator }, StringSplitOptions.None);

                    return arrKeys[0];
                }
                else
                {
                    return dataKey;
                }
            }

            return dataKey;
        }
        #endregion Private Methods
    }
}
