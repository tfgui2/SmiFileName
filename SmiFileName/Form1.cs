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

namespace SmiFileName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxSmi_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            List<string> l = files.ToList<string>();
            l.Sort();
            foreach (string file in l)
            {
                Console.WriteLine(file);
                InsertSmiList(file);
            }
        }

        private List<string> smis = new List<string>();
        private List<string> avis = new List<string>();
        private void InsertSmiList(string filepath)
        {
            smis.Add(filepath);
            string fname = Path.GetFileName(filepath);
            listBoxSmi.Items.Add(fname);
        }

        private void InsertAviList(string filepath)
        {
            avis.Add(filepath);
            string fname = Path.GetFileName(filepath);
            listBoxAvi.Items.Add(fname);
        }

        private void listBoxSmi_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) == false)
                return;

            e.Effect = DragDropEffects.Copy;
        }

        private void listBoxAvi_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) == false)
                return;

            e.Effect = DragDropEffects.Copy;
        }

        private void listBoxAvi_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            List<string> l = files.ToList<string>();
            l.Sort();
            foreach (string file in l)
            {
                Console.WriteLine(file);
                InsertAviList(file);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            smis.Clear();
            avis.Clear();
            listBoxAvi.Items.Clear();
            listBoxSmi.Items.Clear();
        }

        private void buttonTrans_Click(object sender, EventArgs e)
        {
            int count = smis.Count;
            if (count != avis.Count)
            {
                MessageBox.Show("count error");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                string newsmi = avis[i].Substring(0, avis[i].Length - 3);
                newsmi = newsmi + "smi";
                File.Copy(smis[i], newsmi);
            }

            MessageBox.Show("Done");
        }
    }
}
