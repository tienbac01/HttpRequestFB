using System.Diagnostics;
using System.Net;
using xNet;
namespace HttpRq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtIP.Text = GetIPPublic();     
        }



        private string GetIPPublic()
        {
            string externalIpString = new WebClient().DownloadString("http://icanhazip.com").Replace("\\r\\n", "").Replace("\\n", "").Trim();
            var externalIp = IPAddress.Parse(externalIpString);
            return externalIp.ToString();
        }

        void TestData(string html)
        {
            File.WriteAllText("res.html", html);
            var p = new Process();
            p.StartInfo = new ProcessStartInfo("res.html")
            {
                UseShellExecute = true
            };
            p.Start();
        }

        string GetData()
        {
            HttpRequest http = new HttpRequest();
            http.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36";
            string html = http.Get(txtLink.Text).ToString();
            return html;
        }

        string GetData(string link)
        {
            HttpRequest http = new HttpRequest();
            http.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36";
            string html = http.Get(link).ToString();
            return html;
        }

        private void btnCrawl_Click(object sender, EventArgs e)
        {
            var html = GetData();
            TestData(html);
        }

        private void btnSampleLink_Click(object sender, EventArgs e)
        {
            string link = "https://mbasic.facebook.com/";
            txtLink.Text = link;
        }

        private void btnChangeIP_Click(object sender, EventArgs e)
        {
            HttpRequest http = new HttpRequest();
            http.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36";
            string ip = "45.235.128.6:60949";

            //http.Password = "";
            //http.Username = "";

            //Socks4ProxyClient.Parse(ip);
            //Socks5ProxyClient.Parse(ip);
            http.Proxy = HttpProxyClient.Parse(ip);

            var html = GetData("https://whoer.net/");
            TestData(html);
        }

        private void btnUpFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //UploadFile(dialog.FileName); waiting update database model
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HttpRequest http = new HttpRequest();

            http.Cookies = new CookieDictionary();

            string linkLogin = "https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=deprecated&lwv=100&refid=8";

            http.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36";

            string data = "lsd=AVoOA_iZWC0&jazoest=2898&m_ts=1659190407&li=hzzlYuieAlkkHooJYNhvq0Gs&try_number=0&unrecognized_tries=0&email="+txtUser+"&pass="+txtPasswd+"&login=%C4%90%C4%83ng+nh%E1%BA%ADp&bi_xrwh=0";
                
            string html = http.Post(linkLogin, data, "application/x-www-form-urlencoded").ToString(); ;

        }
    }
}