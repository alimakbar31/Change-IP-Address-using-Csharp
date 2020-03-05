using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;




namespace change_ip
{
  

    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source = 192.168.9.250; Initial Catalog = db_model; User ID = XMI_SUPPORT; Password=Passw0rd");
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            model.Items.Clear();            
            string selectstring = string.Format(@"SELECT DISTINCT model from tbl_model order by model");
            Fungsi.Set_ComboBox(selectstring, "model", model);
            
            cn.Open();
            string query = ("SELECT * from tbl_model where IP_address='" + getip() + "'");
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                Copyright.Text = reader["ip_address"].ToString() + " / " + reader["model"].ToString() + " / " + reader["Station"].ToString() + " / " + reader["line"].ToString();
            reader.Close();
            cn.Close();
        }

        private Task ProcessData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() =>
            {
                for (int i = 0; i < totalProcess; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressReport);
                    Thread.Sleep(10);
                }
            });
        }

        public static string getip()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception(" EROR ");
        }

        private void station_SelectedIndexChanged(object sender, EventArgs e)
        {
            line.Enabled = true;
            line.Items.Clear();
            line.Text = "";
            string selectstring = string.Format(@"SELECT DISTINCT line from tbl_model where station='" + station.Text + "' and model='" + model.Text +"'");
            Fungsi.Set_ComboBox(selectstring, "line", line);
        }

        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {
            station.Enabled = true;
            station.Items.Clear();
           
            station.Text = "";
            string selectstring = string.Format(@"SELECT DISTINCT station,sequence from tbl_model where model='" + model.Text + "' ORDER BY sequence asc");
            Fungsi.Set_ComboBox(selectstring, "station", station);
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            string ip = "";
            string compname = "";

            DialogResult dr = MessageBox.Show("SERIUS MAU CHANGE MODEL KE " + model.Text + " " + station.Text + " " + line.Text + " ?", "INFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    cn.Open();
                    string selectstring = ("SELECT ip_address from tbl_model where model='" + model.Text + "' and station='" + station.Text + "' and line='" + line.Text + "'");
                    string checkquery = ("SELECT Comp_name from tbl_model where model='" + model.Text + "' and station='" + station.Text + "' and line='" + line.Text + "'");
                    SqlCommand cmd = new SqlCommand(selectstring, cn);
                    SqlCommand check = new SqlCommand(checkquery, cn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        ip = reader["ip_address"].ToString();
                    reader.Close();
                    SqlDataReader reader1 = check.ExecuteReader();
                    while (reader1.Read())
                        compname = reader1["Comp_name"].ToString();
                    reader1.Close();
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "EROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               

                Ping ping = new Ping();
                PingReply reply = ping.Send(ip);

                if (compname != Environment.MachineName)
                {
                    MessageBox.Show("KOMPUTER INI BUKAN UNTUK STATION " + station.Text + " LINE " + line.Text + "", "EROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (reply.Status.ToString() == "DestinationHostUnreachable")
                {
                    try
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WorkingDirectory = @"C:\Windows\System32";
                        startInfo.FileName = @"C:\Windows\System32\cmd.exe";
                        startInfo.Verb = "runas";
                        startInfo.Arguments = "/c netsh interface ipv4 set address name = \"Local Area Connection\" static " + ip + " 255.255.240.0 192.168.10.254";
                        process.StartInfo = startInfo;
                        process.Start();
                        Form2 frm = new Form2();
                        this.Hide();
                        frm.Show();

                        List<string> list = new List<string>();
                        for (int i = 0; i < 800; i++)
                            list.Add(i.ToString());
                        frm.label5.Text = "Working . . .";
                        var progress = new Progress<ProgressReport>();
                        progress.ProgressChanged += (o, report) =>
                          {
                              frm.label5.Text = string.Format("Processing...{0}%", report.PercentComplete);
                              frm.progressbar1.Value = report.PercentComplete;
                              frm.progressbar1.Update();
                          };
                        await ProcessData(list, progress);
                        frm.label5.Text = "Success !";

                        startInfo.WorkingDirectory = @"D:\MES_SF";
                        startInfo.FileName = @"D:\MES_SF\Loader.exe";
                        process.StartInfo = startInfo;
                        process.Start();
                        Application.Exit();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "EROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    string checkip = "";
                    try
                    {
                        SqlConnection cn1 = new SqlConnection("Data Source = 192.168.9.250; Initial Catalog = ipxiaomi; User ID = XMI_SUPPORT; Password=Passw0rd");
                        cn1.Open();
                        string query = ("SELECT Computer_Name from Show_IP where ip_address= '" + ip + "'");
                        SqlCommand querycmd = new SqlCommand(query, cn1);
                        SqlDataReader cmdreader = querycmd.ExecuteReader();
                        while (cmdreader.Read())
                            checkip = cmdreader["Computer_Name"].ToString();
                        cmdreader.Close();
                        cn1.Close();
                        MessageBox.Show("IP CONFLICT DENGAN LINE " + checkip + " ", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "EROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void line_SelectedIndexChanged(object sender, EventArgs e)
        {
             button1.Enabled = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
