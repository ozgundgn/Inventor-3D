using Inventor;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InventorAppDevx
{
    class MyInventorHelper
    {
        //public string path = System.Environment.CurrentDirectory + "\\Models\\";

        public Inventor.Application getInventorApp()
        {
         
            Inventor.Application m_inventorApp = null;

        
            Process[] aInventor = Process.GetProcessesByName("Inventor");
            //  Try to get an active instance of Inventor

            try
            {
                m_inventorApp = System.Runtime.InteropServices.Marshal.GetActiveObject("Inventor.Application") as Inventor.Application;
            }
            catch (Exception)
            {

                Type inventorAppType = System.Type.GetTypeFromProgID("Inventor.Application");
                m_inventorApp = System.Activator.CreateInstance(inventorAppType) as
                Inventor.Application;
            }

            m_inventorApp.SilentOperation = true;
            // Make the application invisible.
            m_inventorApp.Visible = true;
            return m_inventorApp;
          
        }
        public PartDocument openDocument(Inventor.Application m_inventorApp, string fileName = "Skech")
        {
            string path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), fileName+".ipt");
       
          
            if (fileName == "Skech")
            {
                System.IO.File.WriteAllBytes(path, Properties.Resources.Skech);
            }
            else if (fileName == "Bending_Mold")
            {
                System.IO.File.WriteAllBytes(path, Properties.Resources.Bending_Mold);
            }
      
            PartDocument partDocument;
            partDocument = (PartDocument)m_inventorApp.Documents.Open(path, true);
               
            return partDocument;
        }
        public void openDrawingDocument(string fileName = "Skech")
        {
            // Try to get an active instance of Inventor

            Inventor.Application m_inventorApp = getInventorApp();
            // If not active, create a new Inventor session

            DrawingDocument oDrawDoc = (DrawingDocument)m_inventorApp.Documents.Add(DocumentTypeEnum.kDrawingDocumentObject, m_inventorApp.FileManager.GetTemplateFile(DocumentTypeEnum.kDrawingDocumentObject, SystemOfMeasureEnum.kMetricSystemOfMeasure, DraftingStandardEnum.kISO_DraftingStandard), true);


            Sheet oSheet = oDrawDoc.ActiveSheet;

            PartDocument oPartDoc = openDocument(m_inventorApp, fileName);

            if (oPartDoc.SubType != "{9C464203-9BAE-11D3-8BAD-0060B0CE6BB4}")
            {
                return;
            }
            else
            {
                //default view
                NameValueMap oBaseViewOptions = m_inventorApp.TransientObjects.CreateNameValueMap();
                oBaseViewOptions.Add("SheetMetalFoldedModel", true);
                DrawingView oView1 = oSheet.DrawingViews.AddBaseView((_Document)oPartDoc, m_inventorApp.TransientGeometry.CreatePoint2d(35, 25), (double)(0.1), ViewOrientationTypeEnum.kDefaultViewOrientation, DrawingViewStyleEnum.kHiddenLineDrawingViewStyle, "", null, oBaseViewOptions);


                //bottom View
                NameValueMap oBaseViewOptions2 = m_inventorApp.TransientObjects.CreateNameValueMap();
                oBaseViewOptions2.Add("SheetMetalFoldedModel", true);
                DrawingView oView2 = oSheet.DrawingViews.AddBaseView((_Document)oPartDoc, m_inventorApp.TransientGeometry.CreatePoint2d(10, 10), (double)(0.1), ViewOrientationTypeEnum.kBottomViewOrientation, DrawingViewStyleEnum.kHiddenLineDrawingViewStyle, "", null, oBaseViewOptions2);

                // leftView orientation
                NameValueMap oBaseViewOptionsView6 = m_inventorApp.TransientObjects.CreateNameValueMap();
                oBaseViewOptionsView6.Add("SheetMetalFoldedModel", true);
                DrawingView oView6 = oSheet.DrawingViews.AddBaseView((_Document)oPartDoc, m_inventorApp.TransientGeometry.CreatePoint2d(7, 25), (double)(0.1), ViewOrientationTypeEnum.kLeftViewOrientation, DrawingViewStyleEnum.kHiddenLineDrawingViewStyle, "", null, oBaseViewOptionsView6);

                // rightvew orientation
                NameValueMap oBaseViewOptionsView4 = m_inventorApp.TransientObjects.CreateNameValueMap();
                oBaseViewOptionsView4.Add("SheetMetalFoldedModel", true);
                DrawingView oView4 = oSheet.DrawingViews.AddBaseView((_Document)oPartDoc, m_inventorApp.TransientGeometry.CreatePoint2d(22, 25), (double)(0.1), ViewOrientationTypeEnum.kRightViewOrientation, DrawingViewStyleEnum.kHiddenLineDrawingViewStyle, "", null, oBaseViewOptionsView4);

                //flatpattern->açınımlı

                NameValueMap oBaseViewOptions3 = m_inventorApp.TransientObjects.CreateNameValueMap();
                oBaseViewOptions3.Add("SheetMetalFoldedModel", false);
                DrawingView oView3 = oSheet.DrawingViews.AddBaseView((_Document)oPartDoc, m_inventorApp.TransientGeometry.CreatePoint2d(25, 10), 0.1, ViewOrientationTypeEnum.kDefaultViewOrientation, DrawingViewStyleEnum.kHiddenLineDrawingViewStyle, "", null, oBaseViewOptions3);



                oDrawDoc.SaveAs("C:\\Users\\ossgu\\Desktop\\inventorFolder\\" + fileName + ".idw", true);


                //DrawingView oView = oSheet.DrawingViews[1];

                //Inventor.DrawingDocument odrawDoc = oView.ReferencedDocumentDescriptor.ReferencedDocument;


                //DrawingCurve oCurve1 = oDrawDoc.SelectSet[1].Parent;
                //DrawingCurve oCurve2 = oDrawDoc.SelectSet[2].Parent;

                //Point2d oPt = m_inventorApp.TransientGeometry.CreatePoint2d(15, 15);

                //GeometryIntent oIntent1 = oSheet.CreateGeometryIntent(oCurve1);
                //GeometryIntent oIntent2 = oSheet.CreateGeometryIntent(oCurve2);

                //LinearGeneralDimension oLinDim = oSheet.DrawingDimensions.GeneralDimensions.AddLinear(oPt, oIntent1, oIntent2);

            }
            oPartDoc.Close(true);
        }
    }
}
