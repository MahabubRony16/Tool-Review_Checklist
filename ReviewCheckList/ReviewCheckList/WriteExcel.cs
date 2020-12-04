using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel= Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace ReviewCheckList
{
    class WriteExcel
    {
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        Range srcRng;
        Workbook desWb;
        Worksheet desWs;
        Range desRng;
        public WriteExcel()
        {
            string TemplateCheckListPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Template\TemplateCheckList.xlsx");
            string TemplateMain = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Template\TemplateMain.xlsx");

            wb = excel.Workbooks.Open(TemplateCheckListPath);
            ws = wb.Worksheets[1];
            desWb = excel.Workbooks.Open(TemplateMain);
            desWs = desWb.Worksheets[1];

        }
        public void WriteCell(List<ItemProperties> propList, int listIndLimit)
        {
            int i = 0, j = 2;
            int refrnc= 10;
            //int listIndex = 0;
            srcRng = ws.UsedRange;
            srcRng.Copy();
            for (int listIndex = 0; listIndex <= listIndLimit; listIndex++)
            {
                desRng = desWs.Cells[refrnc, 1];
                i = refrnc + 2;
                desRng.Select();
                desWs.Paste(Type.Missing, Type.Missing);
                desWs.Cells[refrnc, 1] =$"Documetn ID: {propList[listIndex].DocumentId}";
                desWs.Cells[i, j] = propList[listIndex].CbCollaborativeSpace;
                desWs.Cells[i + 1, j] = propList[listIndex].CbTransferType;
                desWs.Cells[i + 2, j] = propList[listIndex].CbLatest;
                desWs.Cells[i + 3, j] = propList[listIndex].CbVersion;
                desWs.Cells[i + 4, j] = propList[listIndex].CbDrawingOpening;
                desWs.Cells[i + 5, j] = propList[listIndex].CbEngineeringConnectionst;
                desWs.Cells[i + 6, j] = propList[listIndex].CbCheckRepresentation;
                desWs.Cells[i + 7, j] = propList[listIndex].CbOther;
                j++;
                desWs.Cells[i, j] = propList[listIndex].CollaborativeSpace;
                desWs.Cells[i + 1, j] = propList[listIndex].TransferType;
                desWs.Cells[i + 2, j] = propList[listIndex].Latest;
                desWs.Cells[i + 3, j] = propList[listIndex].Version;
                desWs.Cells[i + 4, j] = propList[listIndex].DrawingOpening;
                desWs.Cells[i + 5, j] = propList[listIndex].EngineeringConnections;
                desWs.Cells[i + 6, j] = propList[listIndex].CheckRepresentation;
                desWs.Cells[i + 7, j] = propList[listIndex].Other;
                j--;
                refrnc = refrnc + 11;
            } 
        }
        public void Headerproperties(List<string> headerprop)
        {
            int i = 2, j = 2;
            desWs.Cells[i, j] = headerprop[0];
            desWs.Cells[i + 1, j] = headerprop[1];
            desWs.Cells[i + 2, j] = headerprop[2];
            desWs.Hyperlinks.Add(desWs.Cells[i + 3, j], headerprop[3], Type.Missing, "Link","Go to Servicenow");
            desWs.Cells[i + 4, j] = headerprop[4];
            j+=2;
            desWs.Cells[i, j] = headerprop[5];
            desWs.Cells[i + 1, j] = "N/A";
            desWs.Cells[i + 2, j] = headerprop[7];
            desWs.Cells[i + 3, j] = headerprop[8];
            desWs.Cells[i + 4, j] = headerprop[9];
        }
        public void SaveAs(string folderPath, string fileName)
        {
            string path = $"{folderPath}\\{fileName}";
            try
            {
                desWb.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, path);
            }
            catch
            {
                MessageBox.Show("Can not save!");
            }
            
        }
        public void Close()
        {
            desWb.Close(false);
            wb.Close(false);
        }
    }
}
