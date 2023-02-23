using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zmem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enregisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Text = text.Text;
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Filter = "Zmm files (*.zmm)|*.zmm|All files (*.*)|*.*";
            saveFileDialog1.FileName = "MyFile.zmm";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, Text);
            }
            else
            {
                // User clicked Cancel button
            }
            
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Zmm files (*.zmm)|*.zmm|All files (*.*)|*.*";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                text.Text = Text;
            }
            else
            {
                // User clicked Cancel button
            }

        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show("Voulez-vous vraiment sauvegarder ?", "Quitter", buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                enregisterToolStripMenuItem_Click(sender, e);
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
            
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Copy();
        }

        private void collerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            text.Paste();
        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Cut();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void copierToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Font old1,new1;
            old1 = text.SelectionFont;
            if (old1.Bold)
            {
                new1 = new Font(old1, old1.Style & ~FontStyle.Bold);
            }
            else
            {
                new1 = new Font(old1, old1.Style | FontStyle.Bold);
            }
            text.SelectionFont = new1;
            text.Focus();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            Font old1, new1;
            old1 = text.SelectionFont;
            if (old1.Italic)
            {
                new1 = new Font(old1, old1.Style & ~FontStyle.Italic);
            }
            else
            {
                new1 = new Font(old1, old1.Style | FontStyle.Italic);
            }
            text.SelectionFont = new1;
            text.Focus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Font old1, new1;
            old1 = text.SelectionFont;
            if (old1.Underline)
            {
                new1 = new Font(old1, old1.Style & ~FontStyle.Underline);
            }
            else
            {
                new1 = new Font(old1, old1.Style | FontStyle.Underline);
            }
            text.SelectionFont = new1;
            text.Focus();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            text.SelectionColor = colorDialog1.Color;
            text.Focus();
        }

        private void length_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font old1, new1;
            old1 = text.SelectionFont;
            new1 = new Font(old1.FontFamily, int.Parse(length.Text), old1.Style);
            text.SelectionFont = new1;
            text.Focus();
        }
    }
}
