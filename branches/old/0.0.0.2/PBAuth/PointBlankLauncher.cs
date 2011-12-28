using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;

namespace PBAuth
{
    public partial class PBAuth : Form
    {
        public PBAuth()
        {
            InitializeComponent();

            System.Timers.Timer tmr = new System.Timers.Timer();
            tmr.Elapsed += new ElapsedEventHandler(OnTimedEvent3);
            tmr.Interval = 3000; //Устанавливаем интервал в 5 сек.
            tmr.Enabled = true; //Вкючаем таймер.
        }


        /// <summary>
        /// timer3
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public static void OnTimedEvent3(object source, ElapsedEventArgs e)
        {


        }

        private void enter_Click(object sender, EventArgs e)
        {

            if (logintb.Text.Length >= 5 && passwordtb.Text.Length >= 5)
            {
                string commands = logintb.Text + "+++++++" + " " + passwordtb.Text + "+++++++";

                Process pointblank = Process.Start("pointblank.exe", commands);
            }
            else
            {
                MessageBox.Show("Пожалуйста, проверьте введен ли логин и пароль...");
            }
        }
    }
}
