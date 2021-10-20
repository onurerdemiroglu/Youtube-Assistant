using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;
using HtmlAgilityPack;
using System.Web;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] p;
            p = Process.GetProcessesByName("youtube-dl");
            if (p.Length > 0)
            {
                foreach (Process process in p)
                {
                    process.Kill();
                }
                Process[] p2;
                p2 = Process.GetProcessesByName("reset"); if (p2.Length > 0)
                {
                    foreach (Process process in p2)
                    {
                        process.Kill();
                    }
                }
            }
            Control.CheckForIllegalCrossThreadCalls = false;
            Kanallar.Properties.Items.Clear();
            Kanallar2.Properties.Items.Clear();
            string[] dosyalar = Directory.GetFiles(Application.StartupPath + "\\Ana Dosyalar\\Kanal Api\\");
            foreach (string dosya in dosyalar)
            {
                Kanallar.Properties.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dosya));
                Kanallar2.Properties.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dosya));

            }
            Kanallar.SelectedIndex = 0;
            Kanallar2.SelectedIndex = 0;


            // Kanal mail şifre için
            ApiKanal.Properties.Items.Clear();
            string[] dosyalar2 = Directory.GetFiles(Application.StartupPath + "\\Ana Dosyalar\\Kanallar\\");
            foreach (string dosya in dosyalar2)
            {
                ApiKanal.Properties.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dosya));
            }
            ApiKanal.SelectedIndex = 0;
            //////////////

        }
        private void work1()
        {
            ProcessStartInfo s = new ProcessStartInfo
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                LoadUserProfile = true,
                CreateNoWindow = true,
                FileName = Application.StartupPath + "\\Ana Dosyalar\\Dosyalar\\youtube-dl.exe",
                Arguments = indirmelinki.Text

            };
            Process p = new Process { StartInfo = s, EnableRaisingEvents = true };
            if (p.Start())
            {
                StreamReader ProcessReader = p.StandardOutput;
                while (!p.StandardOutput.EndOfStream)
                {
                    var reading = ProcessReader.ReadLine();
                    listBox4.Items.Add(reading);

                    string test =("[download] Finished downloading playlist");
                    foreach (string item in listBox4.Items)
                    {
                        if (item.ToLower().Contains(test.ToLower()))
                        {
                            Log.Items.Add("Durum: indirme işlemi tamamlandı.");
                        }
                    }

                }
            }
            else
            {
            }
        }
      
        private async Task Run()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            UserCredential credential;
            using (var stream = new FileStream(Application.StartupPath + "\\Ana Dosyalar\\Kanal Api\\" + Kanallar.Text+".json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { YouTubeService.Scope.YoutubeUpload },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(this.GetType().ToString())
                );

            }

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
            });

            var video = new Video();
            video.Snippet = new VideoSnippet();
            video.Snippet.Title = baslik.Text;
            video.Snippet.Description = aciklama.Text;
            string[] tagSeo = Regex.Split(tag.Text, ",");
            video.Snippet.Tags = tagSeo;
            video.Snippet.CategoryId = "22"; // See https://developers.google.com/youtube/v3/docs/videoCategories/list
            video.Status = new VideoStatus();
            video.Status.PrivacyStatus = "public"; // or "private" or "public"
            var filePath = videoyeri.Text; // Replace with path to actual movie file.

            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
                videosInsertRequest.ProgressChanged += videosInsertRequest_ProgressChanged;
                videosInsertRequest.ResponseReceived += videosInsertRequest_ResponseReceived;

                await videosInsertRequest.UploadAsync();
            }
        }
        void videosInsertRequest_ProgressChanged(IUploadProgress progress)
        {
            //switch (progress.Status)
            //{
            //    case UploadStatus.Uploading:
            //        baslikk.Text = string.Format("{0} bytes sent.", progress.BytesSent);
            //        break;

            //    case UploadStatus.Failed:
            //        baslikk.Text = string.Format("An error prevented the upload from completing.\n{0}", progress.Exception);
            //        break;
            //}
        }

        void videosInsertRequest_ResponseReceived(Video video)
        {
            Log.Items.Add(string.Format(Kanallar.Text+" adlı kanala'{0}' id'li video yüklenmiştir.", video.Id));
            i++;
            if (i==Convert.ToInt32(toplamvideo.Text))
            {
                Log.Items.Add(string.Format("İşlem tamamlanmıştır"));
            }
            else
            {
                toplamvideo.Text = listBox1.Items.Count.ToString();
                videoyeri.Text = listBox1.Items[i].ToString();
                baslik.Text = System.IO.Path.GetFileNameWithoutExtension(listBox1.Items[i].ToString());
                Thread thead = new Thread(() =>
                {
                    Run().Wait();
                });
                thead.IsBackground = true;
                thead.Start();
            }
        }
        public void Gönder_Click(object sender, EventArgs e)
        {
            try
            {
                i = 0;
                toplamvideo.Text = listBox1.Items.Count.ToString();
                videoyeri.Text = listBox1.Items[i].ToString();
                baslik.Text = System.IO.Path.GetFileNameWithoutExtension(listBox1.Items[i].ToString());
            }
            catch
            {
            }
            Thread thead = new Thread(() =>
            {
                Run().Wait();
            });
            thead.IsBackground = true;
            thead.Start();
        }
        private void Kanallar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox3.Items.Clear();
                string[] dosyalar = Directory.GetFiles(Application.StartupPath + "\\Ana Dosyalar\\Atılacak Videolar\\" + Kanallar.Text);
                foreach (string dosya in dosyalar)
                {
                    listBox1.Items.Add(dosya);
                    listBox3.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dosya));
                }
            }
            catch (Exception)
            {
            }
        }

        int i = 0;
        private void yenile_Click(object sender, EventArgs e)
        {
            Kanallar.Properties.Items.Clear();
            Kanallar2.Properties.Items.Clear();
            string[] dosyalar = Directory.GetFiles(Application.StartupPath + "\\Ana Dosyalar\\Kanal Api\\");
            foreach (string dosya in dosyalar)
            {
                Kanallar.Properties.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dosya));
                Kanallar2.Properties.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dosya));

            }
            Kanallar.SelectedIndex = 0;
            Kanallar2.SelectedIndex = 0;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (kanallink.Text=="")
            {
                MessageBox.Show("Kanal linki girin!");
            }
            else
            {
                indirmelinki.Text = kod1.Text + Application.StartupPath + "\\Atılacak Videolar\\" + Kanallar2.Text + "\\" + kod2.Text + kanallink.Text;

                DialogResult Secim = new DialogResult();
                Secim = MessageBox.Show("'"+Kanallar2.Text + "' adlı kanal için videoları indirmek istediğinize emin misiniz?", "OnEr Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Secim == DialogResult.Yes)
                {
                    Log.Items.Add("Durum: İndirme başlatıldı.");
                    Process[] p;
                    p = Process.GetProcessesByName("youtube-dl");
                    if (p.Length > 0)
                    {
                        foreach (Process process in p)
                        {
                            process.Kill();
                        }
                        Process[] p2;
                        p2 = Process.GetProcessesByName("reset"); if (p2.Length > 0)
                        {
                            foreach (Process process in p2)
                            {
                                process.Kill();
                            }
                        }
                    }
                    Thread thread = new Thread(new ThreadStart(work1));
                    thread.Start();
                }
            }
   
        }

        private void yenile2_Click(object sender, EventArgs e)
        {
            Kanallar2.Properties.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(Application.StartupPath + "\\Kanal Api\\");
            FileInfo[] dosyalar = di.GetFiles();
            foreach (FileInfo var in dosyalar)

            {
                Kanallar2.Properties.Items.Add(var);
            }
        }

        private void ApiKanal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string deger;
            StreamReader oku = File.OpenText(Application.StartupPath + "\\Ana Dosyalar\\Kanallar\\"+ApiKanal.Text+".txt");
            deger = oku.ReadToEnd();
            oku.Close();

            int uzun, poz;
            string mail, sifre;

            uzun = deger.Length;
            poz = deger.IndexOf(",", 0, uzun);

            mail = deger.Substring(0, poz);
            sifre = deger.Substring(poz + 1, uzun - (poz + 1));

            this.mail.Text = mail;
            this.sifre.Text = sifre;
        }

        private void Yenilekanal_Click(object sender, EventArgs e)
        {
            ApiKanal.Properties.Items.Clear();
            string[] dosyalar = Directory.GetFiles(Application.StartupPath + "\\Ana Dosyalar\\Kanallar\\");
            foreach (string dosya in dosyalar)
            {
                ApiKanal.Properties.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dosya));
            }
            ApiKanal.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");

            IWebDriver driver = new ChromeDriver("C://", options);


            System.Threading.Thread.Sleep(3000);
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://console.developers.google.com");
            System.Threading.Thread.Sleep(3000);

            IWebElement Giris = driver.FindElement(By.Id("identifierId"));
            Giris.SendKeys("reanems22");
            Giris.FindElement(By.XPath("//div[@id='identifierNext']/content/span")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("password")).SendKeys("password");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div[@id='passwordNext']/content/span")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.Navigate().GoToUrl("https://console.developers.google.com/apis/dashboard");
            System.Threading.Thread.Sleep(3000);
            try
            {
                driver.FindElement(By.XPath("//md-dialog-content[@id='dialogContent_0']/div/form/tos-checkboxes/div/span/fieldset/div/div/label[2]/span")).Click();
                System.Threading.Thread.Sleep(3000);
                driver.FindElement(By.XPath("//md-dialog-content[@id='dialogContent_0']/div/form/tos-checkboxes/fieldset/div/div/label/span")).Click();
                System.Threading.Thread.Sleep(3000);
                driver.FindElement(By.XPath("//pan-modal-action[2]/a/span/span")).Click();
                System.Threading.Thread.Sleep(3000);
            }
            catch (Exception)
            {
            }
            driver.Navigate().GoToUrl("https://console.developers.google.com/projectcreate?previousPage=%2Fprojectselector%2Fapis%2Flibrary%2Fyoutube.googleapis.com");
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.XPath("//div[@id='p6ntest-project-create-page']/cfc-panel-body/div/div/proj-creation-form/form/button/span")).Click();
            System.Threading.Thread.Sleep(20000);
            driver.FindElement(By.XPath("//button[@id='p6n-mp-enable-api-button']/span")).Click();
            System.Threading.Thread.Sleep(10000);

            ///myproject yazılacak ürün adına
            driver.Navigate().GoToUrl("https://console.developers.google.com/apis/credentials/consent?createClient&");
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.Id("p6n-consent-product-name")).SendKeys("myproject");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//jfk-button[@id='api-consent-save']/span")).Click();
            System.Threading.Thread.Sleep(5000);

            ///uygulamatürü diger
            driver.FindElement(By.XPath("//label[6]/span")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form/div/div/button/span")).Click();
            //oluştura tıklandı

            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.LinkText("Tamam")).Click();


        }
        private async Task Run2()
        {
            //Control.CheckForIllegalCrossThreadCalls = false;
            UserCredential credential;
            using (var stream = new FileStream(Application.StartupPath + "\\Ana Dosyalar\\Kanal Api\\" + Kanallar.Text + ".json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    // This OAuth 2.0 access scope allows an application to upload files to the
                    // authenticated user's YouTube channel, but doesn't allow other types of access.
                    new[] { YouTubeService.Scope.YoutubeUpload },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(this.GetType().ToString())
                );
            }
        }
        string json;
        private void VideoMetaData()
        {
            try
            {
                baslik2.Text = "";
                aciklama2.Text = "";
                etiket2.Text = "";
                videoid.Text = indirlink.Text;
                videoid.Text = videoid.Text.Replace("https://", "");
                videoid.Text = videoid.Text.Replace("http://", "");
                videoid.Text = videoid.Text.Replace("www.youtube.com/watch?v=", "");
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = System.Text.Encoding.UTF8;
                    json = wc.DownloadString(string.Format("https://www.googleapis.com/youtube/v3/videos?part=snippet&id={0}&key={1}", videoid.Text, apikey.Text));
                }
                    dynamic vericek = SimpleJson.DeserializeObject(json);
                    baslik2.Text = vericek["items"][0]["snippet"]["title"];
                    aciklama2.Text = vericek["items"][0]["snippet"]["description"];


                    for (int i = 0; i < 15; i++)
                    {
                        tags.Items.Add(vericek["items"][0]["snippet"]["tags"][i]);
                    }

                    for (int i = 0; i < tags.Items.Count; i++)
                    {
                        if ((i + 1) < tags.Items.Count)
                            etiket2.Text += tags.Items[i] + ",";
                        else
                            etiket2.Text += tags.Items[i];
                    }
            }
            catch
            {
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            VideoMetaData();
        }
       public void indir()
        {
            videoid.Text = indirlink.Text;
            videoid.Text = videoid.Text.Replace("https://", "");
            videoid.Text = videoid.Text.Replace("http://", "");
            videoid.Text = videoid.Text.Replace("www.youtube.com/watch?v=", "");

            Process[] p2;
            p2 = Process.GetProcessesByName("youtube-dl");
            if (p2.Length > 0)
            {
                foreach (Process process in p2)
                {
                    process.Kill();
                }
                Process[] p3;
                p3 = Process.GetProcessesByName("reset"); if (p3.Length > 0)
                {
                    foreach (Process process in p3)
                    {
                        process.Kill();
                    }
                }
            }
            indirmelinki.Text = kod1.Text + Application.StartupPath + "\\Ana Dosyalar\\Atılacak Videolar\\" + Kanallar2.Text + "\\" + kod2.Text + indirlink.Text;
            ProcessStartInfo s = new ProcessStartInfo
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                LoadUserProfile = true,
                CreateNoWindow = true,
                FileName = Application.StartupPath + "\\Ana Dosyalar\\Dosyalar\\youtube-dl.exe",
                Arguments = indirmelinki.Text
            };

            Process p = new Process { StartInfo = s, EnableRaisingEvents = true };
            if (p.Start())
            {
                StreamReader ProcessReader = p.StandardOutput;
                Log.Items.Add(string.Format("{0} 'idli video indirilmeye başlandı.", videoid.Text));
                while (!p.StandardOutput.EndOfStream)
                {
                    var reading = ProcessReader.ReadLine().Replace(" ", "");
                    try
                    {
                        int perc = reading.IndexOf('%');
                        int cl = reading.IndexOf(']') + 1;
                        String percentage = reading.Substring(cl, (perc - cl));


                        int percent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
                        progressBar1.Refresh();
                        progressBar1.CreateGraphics().DrawString(percentage.ToString() + "%",
                            new Font("Arial", (float)12, FontStyle.Regular),
                            Brushes.Black,
                            new PointF(progressBar1.Width / 2 - 10, progressBar1.Height / 2 - 7));

                        if (percentage == "100")
                        {
                            progressBar1.ForeColor = Color.Yellow;
                            progressBar1.Value = 100;

                            Log.Items.Add("İndirme yapıldı dosya yazılıyor biraz bekleyin");
                            Dosyayaz.Start();
                            break;
                        }
                    }
                    catch
                    {
                    }
                }
            }
            else
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread test = new Thread(indir);
            test.Start();
        }

        private void Dosyayaz_Tick(object sender, EventArgs e)
        {
            Log.Items.Add(string.Format("{0} 'idli video başarıyla indirildi..", videoid.Text));
            progressBar1.Value = 100;
            progressBar1.ForeColor = Color.Green;

            Dosyayaz.Stop();
        }
         
    }
}
