namespace XMLValidator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.xml_select = new System.Windows.Forms.Button();
      this.xml_path = new System.Windows.Forms.TextBox();
      this.btn_validate = new System.Windows.Forms.Button();
      this.xsd_path = new System.Windows.Forms.TextBox();
      this.xsd_select = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.validate_progress = new System.Windows.Forms.ProgressBar();
      this.validate_status = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // folderBrowserDialog1
      // 
      folderBrowserDialog1.SelectedPath = "E:\\";
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.DefaultExt = "xsd";
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.FilterIndex = 2;
      this.openFileDialog1.SupportMultiDottedExtensions = true;
      // 
      // xml_select
      // 
      this.xml_select.Location = new System.Drawing.Point(546, 219);
      this.xml_select.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.xml_select.Name = "xml_select";
      this.xml_select.Size = new System.Drawing.Size(87, 30);
      this.xml_select.TabIndex = 0;
      this.xml_select.Text = "Browse";
      this.xml_select.UseVisualStyleBackColor = true;
      this.xml_select.Click += new System.EventHandler(this.xml_select_Click);
      // 
      // xml_path
      // 
      this.xml_path.Location = new System.Drawing.Point(139, 223);
      this.xml_path.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.xml_path.Name = "xml_path";
      this.xml_path.Size = new System.Drawing.Size(373, 25);
      this.xml_path.TabIndex = 1;
      // 
      // btn_validate
      // 
      this.btn_validate.Location = new System.Drawing.Point(264, 308);
      this.btn_validate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btn_validate.Name = "btn_validate";
      this.btn_validate.Size = new System.Drawing.Size(87, 30);
      this.btn_validate.TabIndex = 2;
      this.btn_validate.Text = "Validate";
      this.btn_validate.UseVisualStyleBackColor = true;
      this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
      // 
      // xsd_path
      // 
      this.xsd_path.Location = new System.Drawing.Point(139, 141);
      this.xsd_path.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.xsd_path.Name = "xsd_path";
      this.xsd_path.Size = new System.Drawing.Size(373, 25);
      this.xsd_path.TabIndex = 3;
      // 
      // xsd_select
      // 
      this.xsd_select.Location = new System.Drawing.Point(546, 137);
      this.xsd_select.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.xsd_select.Name = "xsd_select";
      this.xsd_select.Size = new System.Drawing.Size(87, 30);
      this.xsd_select.TabIndex = 4;
      this.xsd_select.Text = "Browse";
      this.xsd_select.UseVisualStyleBackColor = true;
      this.xsd_select.Click += new System.EventHandler(this.xsd_select_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(15, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(122, 25);
      this.label1.TabIndex = 5;
      this.label1.Text = "XML Validator";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(22, 147);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(90, 19);
      this.label2.TabIndex = 6;
      this.label2.Text = "XSD File Path";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(22, 226);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(111, 19);
      this.label3.TabIndex = 7;
      this.label3.Text = "XML Folder Path";
      // 
      // validate_progress
      // 
      this.validate_progress.Location = new System.Drawing.Point(122, 390);
      this.validate_progress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.validate_progress.Name = "validate_progress";
      this.validate_progress.Size = new System.Drawing.Size(373, 30);
      this.validate_progress.TabIndex = 8;
      // 
      // validate_status
      // 
      this.validate_status.AutoSize = true;
      this.validate_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.validate_status.Location = new System.Drawing.Point(119, 445);
      this.validate_status.Name = "validate_status";
      this.validate_status.Size = new System.Drawing.Size(0, 17);
      this.validate_status.TabIndex = 9;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(-3, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(695, 98);
      this.panel1.TabIndex = 10;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(692, 512);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.validate_status);
      this.Controls.Add(this.validate_progress);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.xsd_select);
      this.Controls.Add(this.xsd_path);
      this.Controls.Add(this.btn_validate);
      this.Controls.Add(this.xml_path);
      this.Controls.Add(this.xml_select);
      this.DoubleBuffered = true;
      this.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Form1";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button xml_select;
        private System.Windows.Forms.TextBox xml_path;
        private System.Windows.Forms.Button btn_validate;
        private System.Windows.Forms.TextBox xsd_path;
        private System.Windows.Forms.Button xsd_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar validate_progress;
        private System.Windows.Forms.Label validate_status;
        private System.Windows.Forms.Panel panel1;
    }
}

