using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Yte
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
            saveFileDialog1.Filter = "Yte files (*.yte)|*.yte|All files (*.*)|*.*";
            saveFileDialog1.FileName = "MyFile.yte";

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
            openFileDialog1.Filter = "Yte files (*.yte)|*.yte|All files (*.*)|*.*";
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
            length.Text = "12";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void copierToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void length_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font old1, new1;
            old1 = text.SelectionFont;
            new1 = new Font(old1.FontFamily, int.Parse(length.Text), old1.Style);
            text.SelectionFont = new1;
            text.Focus();
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Font font = text.Font;
            Color foreColor = text.ForeColor;
            Color backColor = text.BackColor;
            string text1 = text.Text;

            e.Graphics.DrawString(text1, font, new SolidBrush(foreColor), new RectangleF(e.MarginBounds.X, e.MarginBounds.Y, e.MarginBounds.Width, e.MarginBounds.Height));
        }

        private void italic_Click_1(object sender, EventArgs e)
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

        private void Bold_Click_1(object sender, EventArgs e)
        {
            Font old1, new1;
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

        private void Underline_Click(object sender, EventArgs e)
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

        private void imprimerToolStripButton_Click(object sender, EventArgs e)
        {
            // Afficher le dialogue d'impression
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Configurer le document d'impression
                printDocument1.DocumentName = "Texte à imprimer";
                printDocument1.PrinterSettings = printDialog.PrinterSettings;
                printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);

                // Lancer l'impression
                printDocument1.Print();
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            text.SelectionColor = colorDialog1.Color;
            text.Focus();
        }

        private void ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void manuelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Page créér par youssef maatoug CopyRight 2023");
        }
    }
}
