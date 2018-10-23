using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListVieww
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "ListView";
            //Size = new Size(350, 300);

            List<Actress> actress = new List<Actress>();
            actress.Add(new Actress("AAA", 1981));
            actress.Add(new Actress("BBB", 1975));
            actress.Add(new Actress("CCC", 1981));
            actress.Add(new Actress("DDD", 1971));
            actress.Add(new Actress("EEE", 1984));

            foreach (Actress act in actress)
            {
                ListViewItem item = new ListViewItem();
                item.Text = act.name;
                item.SubItems.Add(act.year.ToString());
                listView1.Items.Add(item);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;
            string name = lv.SelectedItems[0].SubItems[0].Text;
            string year = lv.SelectedItems[0].SubItems[1].Text;

            toolStripStatusLabel1.Text = name + "," + year;
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.Sorting == SortOrder.Ascending)
            {
                lv.Sorting = SortOrder.Descending;
            }
            else
            {
                lv.Sorting = SortOrder.Ascending;
            }
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
