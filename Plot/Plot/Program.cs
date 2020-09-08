using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Controls;
using ZedGraph;

using Excel = Microsoft.Office.Interop.Excel;

namespace Plot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Random r = new Random();

            var path = @"D:/Machel/Documents/leit.xlsx";

            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;

            excelApp.DisplayAlerts = false; //Don't want Excel to display error messageboxes  
            Excel.Workbook workbook = excelApp.Workbooks.Open(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //This opens the file
            Excel.Worksheet sheet = workbook.Worksheets[1];//Get the first sheet in the file
            Excel.Range bColumn = sheet.get_Range("C2", "C10");
            Excel.Range aColumn = sheet.get_Range("A2", "A10");

            List<double> dataX = new List<double>();
            List<double> dataY = new List<double>();

            foreach (object o in bColumn)
            {
                Excel.Range row = o as Excel.Range;
                double s = row.get_Value(null);
                dataX.Add(s);
            }
            foreach (object o in aColumn)
            {
                Excel.Range row = o as Excel.Range;
                double s = row.get_Value(null);
                dataY.Add(s);
            }

            int max = dataX.Count;
            double[] x = new double[max];
            double[] y1 = new double[max];
            double[] y2 = new double[max];

            for (int i = 0; i < max; i++)
            {
                x[i] = dataX[i];
                y1[i] = dataY[i];
               // y2[i] = r.Next(0, 5);
            }

            ScatterplotView spv = new ScatterplotView();
            spv.Dock = DockStyle.Fill;
            //spv.LinesVisible = false;

            spv.Graph.GraphPane.AddCurve("Curve 1", x, y1, Color.Red, SymbolType.Circle);
            // spv.Graph.GraphPane.AddCurve("Curve 2", x, y2, Color.Blue, SymbolType.Diamond);
            spv.Graph.GraphPane.Title.Text = "Ploting with C#";
            spv.Graph.GraphPane.XAxis.Title.Text = "Abstand";
            spv.Graph.GraphPane.YAxis.Title.Text = "Leit";

            spv.Graph.GraphPane.AxisChange();
            

            Form f1 = new Form();
            f1.Text = "Graph";           
            f1.Width = 600;
            f1.Height = 400;
            f1.Controls.Add(spv);
            f1.ShowDialog();

        }
    }
}
