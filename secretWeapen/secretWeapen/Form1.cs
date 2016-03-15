using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace secretWeapen
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private const string BTS_MAIN = "http://www.btaia.com/search/";

        private const string TOR_MAIN = "";

        private const string BTD_MAIN = "";

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_input.Text == "")
            {
                MessageBox.Show("请输入搜索关键字");
            }
            else if (rdo_bts.Checked == false && rdo_btd.Checked == false && rdo_tor.Checked == false)
            {
                MessageBox.Show("请选择搜索网站");
            }
            else
            {
                txt_result.Clear();
                string keyword = txt_input.Text.ToString();
                
            }
        }

        private string getHtmlCode(string url)
        {
            Uri uri = new Uri(url);
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(uri);
            myReq.UserAgent = "Mozilla / 5.0(Windows NT 6.1; WOW64; rv: 45.0) Gecko / 20100101 Firefox / 45.0";
            myReq.Accept = "*/*";
            myReq.KeepAlive = true;
            myReq.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8,en-US;q=0.5,en;q=0.3");
            HttpWebResponse result = (HttpWebResponse)myReq.GetResponse();
            Stream receviceStream = result.GetResponseStream();
            StreamReader readerOfStream = new StreamReader(receviceStream, System.Text.Encoding.GetEncoding("utf-8"));
            string strHTML = readerOfStream.ReadToEnd();
            readerOfStream.Close();
            receviceStream.Close();
            result.Close();
            return strHTML;
        }





        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }
    }
}
