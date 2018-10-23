﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
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

class MForm : Form
{
    private StatusBar sb;
    public MForm()
    {
        Text = "ListView";
        Size = new Size(350, 300);

        List<Actress> actresses = new List<Actress>();
        actresses.Add(new Actress("Jessica Alba", 1981));
        actresses.Add(new Actress("Angelina Jolie", 1975));
        actresses.Add(new Actress("Natalie Portman", 1981));
        actresses.Add(new Actress("Rachel Weiss", 1971));
        actresses.Add(new Actress("Scarlett Johansson", 1984));

        ColumnHeader name = new ColumnHeader();
        name.Text = "Name";
        name.Width = -1;

        ColumnHeader year = new ColumnHeader();
        year.Text = "Year";
        SuspendLayout();

        ListView lv = new ListView();
        lv.Parent = this;
        lv.FullRowSelect = true;

        // 격자 표시
        lv.GridLines = true;

        // 컬럼을 드래그해서 순서 바꿀수있음
        lv.AllowColumnReorder = true;

        //lv.Sorting = SortOrder.Descending;

        //lv.Columns.Add(name);
        //lv.Columns.Add(year);
        lv.Columns.AddRange(new ColumnHeader[] { name, year });

        //lv.ColumnClick += new ColumnClickEventHandler(ColumnClick);
        lv.ColumnClick += ColumnClick;

        foreach (Actress act in actresses)
        {
            ListViewItem item = new ListViewItem();
            item.Text = act.name;
            item.SubItems.Add(act.year.ToString());
            lv.Items.Add(item);
        }

        // 윈도우를 가득채워라
        lv.Dock = DockStyle.Fill;
        lv.Click += new EventHandler(OnChanged);

        // 상태바 생성
        sb = new StatusBar();
        sb.Parent = this;

        // 격자모양표시
        lv.View = View.Details;
        ResumeLayout();
        CenterToScreen();
    }
    void OnChanged(object sender, EventArgs e)
    {
        ListView lv = (ListView)sender;
        string name = lv.SelectedItems[0].SubItems[0].Text;
        string born = lv.SelectedItems[0].SubItems[1].Text;
        sb.Text = name + ", " + born;
    }
    void ColumnClick(object sender, ColumnClickEventArgs e)
    {
        // ListView lv = (ListView)sender;
        ListView lv = sender as ListView;
        // as는 에러상황에 대신 null값을 줌

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
class MApplication
{
    public static void Main()
    {
        Application.Run(new MForm());
    }
}