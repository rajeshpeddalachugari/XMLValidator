using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using System.Xml.Linq;
using System.IO;
using System.Xml;

namespace XMLValidator
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      validate_progress.Hide();
    }
    private static bool isValid = true;
    public static StreamWriter swrite;
    public static int count = 0;
    public static List<string> failCount = new List<string>();
    public static string path;
    public static XmlReader reader;

    

    private void xsd_select_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Filter = "XSD Files|*.xsd|All Files|*.*";
      if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        xsd_path.Text = ofd.FileName;
    }

    private void xml_select_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        xml_path.Text = fbd.SelectedPath;
    }

    private void btn_validate_Click(object sender, EventArgs e)
    {
      try
      {
        XmlSchemaSet schema = new XmlSchemaSet();
        schema.Add("", xsd_path.Text);
        string[] filePaths = Directory.GetFiles(xml_path.Text, "*.xml");
        swrite = new StreamWriter(xml_path.Text + @"\log.txt");
        validate_progress.Show();
        validate_progress.Value = 0;
        validate_status.Refresh();
        validate_status.Text = "";
        validate_progress.Minimum = 0;
        validate_progress.Maximum = filePaths.Length;
        validate_progress.Step = 1;
        //List<string> failCount = new List<string>();
        List<string> list = new List<string>();
        int invalidXmlCount = 0;
        for (int i = 0; i < filePaths.Length; ++i)
        {
          path = filePaths[i];
          try
          {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas = schema;
            settings.ValidationEventHandler += new ValidationEventHandler(MyValidationEventHandler);
            
              // Create the XmlReader object.
              Encoding enc = Encoding.GetEncoding("ISO-8859-1");
              StreamReader sr = new StreamReader(path, enc);
              reader = XmlReader.Create(sr, settings);

              // Parse the file. 
              while (reader.Read()) ;
           
              reader.Close();

            if (failCount.Contains(System.IO.Path.GetFileName(path)))
            {
              swrite.WriteLine("number of errors:" + count.ToString());
              swrite.WriteLine("******************** end of " + System.IO.Path.GetFileName(path) + "**********************" + Environment.NewLine);
              count = 0;
            }

            validate_progress.Refresh();
            int percent = (int)(((double)(validate_progress.Value - validate_progress.Minimum) / (double)(validate_progress.Maximum - validate_progress.Minimum)) * 100);
            using (Graphics gr = validate_progress.CreateGraphics())
            {
              gr.DrawString(percent.ToString() + "%",
                  SystemFonts.DefaultFont,
                  Brushes.Black,
                  new PointF(validate_progress.Width / 10 - (gr.MeasureString(percent.ToString() + "%",
                      SystemFonts.DefaultFont).Width / 2.0F),
                  validate_progress.Height / 2 - (gr.MeasureString(percent.ToString() + "%",
                      SystemFonts.DefaultFont).Height / 2.0F)));
            }
            validate_progress.PerformStep();
            validate_status.Text = "Validated " + validate_progress.Value.ToString() + " out of " + filePaths.Length.ToString() + " files  " + failCount.Count + " files failed";
            validate_status.Refresh();
          }
          catch (Exception ea)
          {
            
            MessageBox.Show("failed to load file :" + System.IO.Path.GetFileName(path) + Environment.NewLine + ea.Message);
            if (count == 0)
            {
              swrite.WriteLine("******************** Filename: " + System.IO.Path.GetFileName(path) + "**********************" + Environment.NewLine);
            }
            swrite.WriteLine("invalid file:" + System.IO.Path.GetFileName(path) + Environment.NewLine);
            if (count != 0)
            {
              swrite.WriteLine("number of errors:" + count.ToString());
            }
            swrite.WriteLine("******************** end of " + System.IO.Path.GetFileName(path) + "**********************" + Environment.NewLine);
            invalidXmlCount++;
            
            continue;
          }
        }
        if (failCount.Count == 0 && invalidXmlCount == 0)
        {
          swrite.WriteLine("Validation successful and no errors found");
        }
        swrite.Close();
        validate_progress.Value = validate_progress.Maximum;
        DialogResult dialogresult;
        dialogresult = MessageBox.Show("Validation done..Show Result..?", "XML Validator", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        if (dialogresult == DialogResult.Yes)
        {
          System.Diagnostics.Process.Start(xml_path.Text + @"\log.txt");
          this.Close();
        }
        else if (dialogresult == DialogResult.No)
        {
          this.Close();
        }
      }
      catch (Exception er)
      {
        MessageBox.Show(er.Message);
      }
    }

    public static void MyValidationEventHandler(object sender,
                                    ValidationEventArgs args)
    {
      isValid = false;
      if (!failCount.Contains(System.IO.Path.GetFileName(path)))
      {
        failCount.Add(System.IO.Path.GetFileName(path));
        swrite.WriteLine("******************** Filename: " + System.IO.Path.GetFileName(path) + "**********************" + Environment.NewLine);
      }
      swrite.WriteLine("Line number:" + args.Exception.LineNumber + Environment.NewLine + "Error:" + args.Message);
      count++;
    }
  
  }
}
