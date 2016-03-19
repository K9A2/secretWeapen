using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secretWeapen
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        // @"(?<=readonly>).*?(?=</textarea>)"; 

        private const string BTS_MAIN = "http://www.btaia.com/search/";
        private const string BTS_HASH = "http://www.btaia.com/magnet/detail/hash/";
        private const string BTS_GET_HASH = @"(?<=http://www.btaia.com/magnet/detail/hash/).*?(?="" title)";
        private const string BTS_GET_FILE_NAME= @"(?<=</div>		<h3>).*?(?=</h3>)";
        private const string BTS_GET_FILE_SIZE= @"(?<=<div class=""col-md-2 col-sm-3 field"">Content Size:</div><div class=""col-md-10 col-sm-9 value"">).*?(?=</div>)";
        private const string BTS_GET_MAGNET_LINK= @"(?<=readonly>).*?(?=</textarea>)";


        private const string TOR_MAIN = "";

        private const string BTD_MAIN = "http://51buyebook.com:9999/search?info_hash=&q=";
        private const string BTD_GET_TR = @"(?<=(this.href)"" href="").*?(?="")";
        private const string BTD_GET_FILE_NAME = "";
        private const string BTD_GET_FILE_SIZE = "";
        private const string BTD_GET_MAGNET = "";

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

                if (rdo_bts.Checked == true)
                {
                    string searchLink = BTS_MAIN + keyword;
                    string[] hashLinks = getHashLink(searchLink, BTS_GET_HASH);
                    string[] results = getResults(hashLinks, BTS_GET_FILE_NAME, BTS_GET_FILE_SIZE, BTS_GET_MAGNET_LINK);
                    displayResults(results);
                }else if (rdo_tor.Checked == true)
                {
                    
                }else if (rdo_btd.Checked == true)
                {
                    string url = BTD_MAIN + keyword;
                    string strHtml = getHtmlCode(url);
                    MatchCollection mc = Regex.Matches(strHtml, BTD_GET_TR);
                    for(int i = 0; i < mc.Count; i++)
                    {
                        txt_result.AppendText("magnet:?xt=urn:btih:" + mc[i].ToString() + Environment.NewLine + Environment.NewLine);
                    }
                }
            }
        }

        //在txt_result显示结果
        private void displayResults(string[] results)
        {
            for(int i = 0; i < results.Length; i++)
            {
                txt_result.AppendText(results[i] + Environment.NewLine);
            }
        }

        //获取Btspread和TorrentKitty的hash组
        private string[] getHashLink(string url, string pattern)
        {
            MatchCollection hashes = Regex.Matches(getHtmlCode(url), pattern);
            string[] results = new string[hashes.Count];
            for(int i = 0; i < hashes.Count; i++)
            {
                results[i] = BTS_HASH + hashes[i].Value.ToString();
            }
            return results;
        }

        //获取Btspread和TorrentKitty的搜索结果
        private string [] getResults(string[] hashLinks,string REG_FILE_NAME,string REG_FILE_SIZE,string REG_MAGNET)
        {
            int i = 0;
            string[] results = new string[hashLinks.Length];
            Parallel.For(0, hashLinks.Length,(item) =>
            {
                string htmlCode = getHtmlCode(hashLinks[i]);
                Match filename = Regex.Match(htmlCode, REG_FILE_NAME);
                Match filesize = Regex.Match(htmlCode, REG_FILE_SIZE);
                Match magnet = Regex.Match(htmlCode, REG_MAGNET);
                results[i] = "FileName:" + filename.ToString() + Environment.NewLine + "FileSize:" + filesize.ToString() + Environment.NewLine + "MagnetLink:" + Environment.NewLine + magnet.ToString() + Environment.NewLine;
                i++;
            });
            return results;
            
        }


        //获取URL的页面源代码，方便进行正则表达式匹配
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




        //系统自动生成的函数，不用管它
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }
    }
}
