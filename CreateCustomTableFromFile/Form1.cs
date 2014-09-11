using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CreateCustomTableFromFile.MyClasses;

namespace CreateCustomTableFromFile
{
    public partial class Form1 : Form
    {

        MyCustomFile myFile = new MyCustomFile();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialization();
        }

        private void Initialization()
        {
            objMessage.Text = "No file selected";

            objCreate.Enabled = false;

            objList.Refresh();
            objList.Enabled = false;

            objQuery.Clear();
            objQuery.Enabled = false;

            objSeparator.Clear();
            objSeparator.Enabled = false;

            objTableName.Enabled = false;
        }

        private void objFileButton_Click(object sender, EventArgs e)
        {

            // collect the file
            myFile = CollectFile();

            if (myFile.Name != null)
            {
                objMessage.Text = "File checked. " + myFile.TextLines.Length + " lines.";
                objCreate.Enabled = true;
                objTableName.Clear();
                objTableName.Enabled = true;

            }

        }


        private MyCustomFile CollectFile()
        {

            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.AddExtension = true;
            fd.Multiselect = false;
            fd.Filter = "PDF files (*.txt)|*.txt";

            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                myFile.Name = Path.GetFileName(fd.FileName);
                myFile.Path = Path.GetDirectoryName(fd.FileName);

                if (objSeparatorCheck.Checked == true)
                {
                    myFile.Separator = Char.Parse(objSeparator.Text.Trim());
                }
                else
                {
                    myFile.Separator = ' ';
                }

                myFile.CopyInMemory();

                // show into the list
                objList.DataSource = myFile.TextLines;
                objList.Enabled = true;
            }

            return myFile;
        }

        private void objCreate_Click(object sender, EventArgs e)
        {

            objQuery.Clear();
            objQuery.Enabled = true;

            // table creation
            objQuery.Text = objQuery.Text + "CREATE TABLE ";
            objQuery.Text = objQuery.Text + objTableName.Text.Trim() + " ";
            objQuery.Text = objQuery.Text + "(";
            objQuery.Text = objQuery.Text + "ID int NOT NULL PRIMARY KEY, ";
            objQuery.Text = objQuery.Text + "Name varchar(100) NOT NULL";
            objQuery.Text = objQuery.Text + ");";

            objQuery.Text = objQuery.Text + " ";

            int i = 0;
            foreach (string s in myFile.TextLines)
            {

                objQuery.Text = objQuery.Text + "INSERT INTO ";
                objQuery.Text = objQuery.Text + objTableName.Text.Trim() + " ";
                objQuery.Text = objQuery.Text + "(";
                objQuery.Text = objQuery.Text + "ID, Name";
                objQuery.Text = objQuery.Text + ") ";
                objQuery.Text = objQuery.Text + "VALUES ";
                objQuery.Text = objQuery.Text + "(";
                objQuery.Text = objQuery.Text + "'";
                objQuery.Text = objQuery.Text + i.ToString();
                objQuery.Text = objQuery.Text + "'";
                objQuery.Text = objQuery.Text + ", ";
                objQuery.Text = objQuery.Text + "'";
                objQuery.Text = objQuery.Text + s;
                objQuery.Text = objQuery.Text + "'";
                objQuery.Text = objQuery.Text + "); ";

                i = i + 1;
            }


        }

        private void objSeparatorCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (objSeparatorCheck.Checked == true)
            {
                objSeparator.Enabled = true;
            }
            else
            {
                objSeparator.Enabled = false;
            }
        }
    
    }
}
