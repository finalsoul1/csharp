using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "ListView Test";
            Size = new Size(350, 300);

            List<Actress> actresses = new List<Actress>();
            actresses.Add(new Actress("Jessica Alba", 1981));
            actresses.Add(new Actress("Angelina Jolie", 1975));
            actresses.Add(new Actress("Natalie Portman", 1981));
            actresses.Add(new Actress("Rachel Weiss", 1971));
            actresses.Add(new Actress("Scarlett Johansson", 1984));

            foreach (Actress act in actresses)
            {
                ListViewItem item = new ListViewItem();
                item.Text = act.name;
                item.SubItems.Add(act.year.ToString());
                listView1.Items.Add(item);
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            listView1 lv = (listView1)sender;
            string name = lv.SelectedItems[0].SubItems[0].Text;
            string year = lv.SelectedItems[0].SubItems[1].Text;

            toolStripStatusLabel1.Text = name + "," + year;
        }
    }
    public class Actress
    {
        public string name;
        public int year;
        public Actress(string name, int year)
        {
            this.name = name;
            this.year = year;
        }
    }
}
