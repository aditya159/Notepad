using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
namespace menu
{
    public partial class notepad : Form
    {
        public notepad()
        {
            InitializeComponent();

        }

        public void open_file()
        {
            // openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream fs = openFileDialog1.OpenFile();
                StreamReader reader = new StreamReader(fs);
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
                fs.Close();
            }
        }



        public void save_file()
        {



            saveFileDialog1.Title = "Save";

            saveFileDialog1.Filter = "Text Document|*.txt";//applied filter       

            saveFileDialog1.DefaultExt = "txt";//applied default extension    

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)

            {

                if (richTextBox1.Text == "")

                {
                    MessageBox.Show("empty");
                    richTextBox1.SaveFile(this.Text, RichTextBoxStreamType.PlainText);


                }

                else if (this.Text != "")

                {

                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);

                    this.Text = saveFileDialog1.FileName;

                }

            }



        }

        public void saveas_file()
        {
            if (!richTextBox1.Text.Equals(""))
            {
                //if(saveFileDialog1!=sav)
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    saveFileDialog1.ShowDialog();
                    FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                    StreamWriter writer = new StreamWriter(fs);
                    writer.Write(Form1.Text);
                    writer.Close();
                    fs.Close();
                }
            }
            else
            {
                MessageBox.Show("Empty File try again!");
            }
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();
            toolStripStatusLabel1.Text = "New File is Created!";
            toolStripStatusLabel2.Text = "";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            open_file();


        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            toolStripStatusLabel1.Text = "New File is Created!";
            toolStripStatusLabel2.Text = "";

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_file();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {

            find o = new find();
            o.Show();


        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            save_file();
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_file();
        }

        private void printNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked)
            {
                richTextBox1.WordWrap = false;
                wordWrapToolStripMenuItem.Checked = false;
            }
            else
            {

                richTextBox1.WordWrap = true;
                wordWrapToolStripMenuItem.Checked = true;
            }
            //Boolean = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = false;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel2.Text = "";
            toolStripStatusLabel3.Text = toolStripStatusLabel4.Text = "";
            toolStripStatusLabel5.Text = "";

            richTextBox1.Focus();




        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;

        }

        private void fontColorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveas_file();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveas_file();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            saveas_file();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pageSetupDialog1.ShowDialog();
            pageSetupDialog1.PageSettings = new System.Drawing.Printing.PageSettings();
            pageSetupDialog1.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            //pageSetupDialog1.ShowNetwork = false;
            // DialogResult result = pageSetupDialog1.ShowDialog();

            //if ( result == DialogResult.OK)
            //{
            //    object[] results = new object[]
            //    {

            //    }
            //}

        }

        private void toolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolbarToolStripMenuItem.Checked)
            {
                toolStrip1.Visible = false;
                toolbarToolStripMenuItem.Checked = false;
            }
            else
            {
                toolStrip1.Visible = true;
                toolbarToolStripMenuItem.Checked = true;
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about o = new about();
            o.Show();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void alignRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void alignCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void alignLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {


            int index = 0;
            /*String t = richTextBox1.Text;
            richTextBox1.Text = "";
            richTextBox1.Text = t;*/

            while (index < richTextBox1.Text.LastIndexOf(toolStripTextBox1.Text))
            {

                richTextBox1.Find(toolStripTextBox1.Text, index, richTextBox1.TextLength, RichTextBoxFinds.None);
                richTextBox1.SelectionBackColor = Color.Yellow;
                index = richTextBox1.Text.IndexOf(toolStripTextBox1.Text, index) + 1;

            }




        }

        private void notepad_KeyUp(object sender, KeyEventArgs e)
        {

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                toolStripStatusLabel3.Text = "Caps On";
            }
            else
            {
                toolStripStatusLabel3.Text = "Caps Of";
            }
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void notepad_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                toolStripStatusLabel3.Text = "Caps On";
            }
            else
            {
                toolStripStatusLabel3.Text = "Caps Off";
            }

            toolStripStatusLabel4.Text = "Length: " + richTextBox1.TextLength.ToString();
            toolStripStatusLabel4.Text += "  Line:" + richTextBox1.Lines.Count();

            if (Control.IsKeyLocked(Keys.Insert))
            {
                toolStripStatusLabel5.Text = "Insert Key On";
            }
            else
            {
                toolStripStatusLabel5.Text = "Insert Key Off";
            }
        }

        private void toUppercaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();
        }

        private void toLowerCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();
        }


        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {

            // Single yPos = 0;
            // Single leftMargin = e.MarginBounds.Left;
            // Single topMargin = e.MarginBounds.Top;
            //// Image img = Image.FromFile("logo.bmp");
            // //Rectangle logo = new Rectangle(40, 40, 50, 50);
            // using (Font printFont = new Font("Arial", 20.0f))
            // {

            //     //e.Graphics.DrawImage(img, logo);
            //     e.Graphics.DrawString(richTextBox1.Text, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            // }
            // using (SolidBrush blueBrush = new SolidBrush(Color.Black))
            // {
            //     Rectangle rect = new Rectangle(100, 100, 500, 120);
            //     e.Graphics.FillRectangle(blueBrush, rect);
            // }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.ShowDialog();

        }
    }
}
