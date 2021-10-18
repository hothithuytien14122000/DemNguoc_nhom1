using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denngaytet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        Timer t;
        DateTime endTime = new DateTime(2022, 02, 01, 00, 00, 00); //Tết Âm Lịch là ngày 08/02/2016 Dương Lịch

        void Form1_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 500;
            t.Tick += t_Tick;

            TimeSpan ts = endTime.Subtract(DateTime.Now); //Lấy ngày Tết trừ thời gian hiện tại
            label1.Text = ts.ToString("dd' Ngày 'hh' Giờ 'mm' Phút 'ss' Giây'"); //Format thời gian

            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = endTime.Subtract(DateTime.Now); //Lấy ngày Tết trừ thời gian hiện tại
            label1.Text = ts.ToString("dd' Ngày 'hh' Giờ 'mm' Phút 'ss' Giây'"); //Format thời gian
            if (ts.TotalSeconds <= 0)
                t.Stop(); //Đến Têt thì dừng lại
        }
    }
}
