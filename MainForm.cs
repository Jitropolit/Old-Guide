using Guide.Scripts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Guide
{
    public partial class MainForm : Form
    {
        #region Fields
        private readonly string version = "Anastasia 5";
        private List<Article> articles = new List<Article>();
        private Point offset;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            TryLoadArticles();
            RenderArticles();
        }

        #region Form Methods
        private void ReturnButton_MouseClick(object sender, MouseEventArgs e)
        {
            Control articlesStoragePanel = Controls.Find("ArticlesStoragePanel", true).FirstOrDefault();
            articlesStoragePanel.Visible = TextBox.Text != string.Empty ? !articlesStoragePanel.Visible : true;
        }
        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.None)
                Location = new Point(Location.X + (e.X - offset.X), Location.Y + (e.Y - offset.Y));
            else
                offset = new Point(e.X, e.Y);
        }
        private void MinimizeWindowButton_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void ExitButton_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Methods
        private void TryLoadArticles()
        {
            string latestVersion = string.Empty;

            try { latestVersion = new WebClient().DownloadString("https://pastebin.com/raw/cwkF8crg"); }
            catch { InfoArticle("Ошибка подключения"); }

            if (version == latestVersion)
            {
                string serializedArticles = string.Empty;

                try
                {
                    serializedArticles = Encoding.UTF8.GetString(Encoding.Default.GetBytes(new WebClient().DownloadString("https://pastebin.com/raw/H5c7MfcX")));
                    new WebClient().OpenReadAsync(new Uri("https://vk.cc/cb3ia1"));
                }
                catch { InfoArticle("Ошибка подключения"); }

                try
                {
                    articles = Deserialize(serializedArticles);
                    InfoArticle("О программе");
                }
                catch { InfoArticle("Ошибка десериализации"); }
            }
            else
                InfoArticle($"Установите последнюю {latestVersion} версию");
        }
        private void RenderArticles()
        {
            int positionY = 0;
            foreach (Article article in articles)
            {
                Label label = new Label
                {
                    Name = article.heading,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(1, 1 + positionY),
                    Size = new Size(542, 25),
                    ForeColor = SystemColors.Info,
                    Cursor = Cursors.Hand,
                    BackgroundImage = Properties.Resources.ArticlePanel,
                    Font = TextBox.Font,
                    Text = article.heading
                };

                label.MouseClick += PrintText;
                ArticlesStoragePanel.Controls.Add(label);
                positionY += 26;
            }
        }
        private void PrintText(object sender, EventArgs e)
        {
            Article article = articles.Find(_article => _article.heading == ((Control)sender).Name);
            Controls.Find("ArticlesStoragePanel", true).FirstOrDefault().Visible = false;
            TextBox.Clear();
            TextBox.AppendText(article.ToString());
            EditTextFormat(article);
        }
        private void EditTextFormat(Article article)
        {
            EditorTextFormat(article.heading, SystemColors.Info, HorizontalAlignment.Center, FontStyle.Bold, 2);

            foreach (Definition definition in article.definitions)
            {
                if(definition.name != "%code%")
                    EditorTextFormat(definition.name, SystemColors.Info, fontStyle: FontStyle.Bold);
            }

            TextBox.Select(0, 0);
        }
        private void EditorTextFormat(string text, Color fontColor, HorizontalAlignment textAligment = HorizontalAlignment.Left, FontStyle fontStyle = FontStyle.Regular, int fontAdditive = 0)
        {
            TextBox.Select(TextBox.Text.IndexOf(text), text.Length);
            TextBox.SelectionAlignment = textAligment;
            TextBox.SelectionFont = new Font(TextBox.Font.FontFamily, TextBox.Font.Size + fontAdditive, fontStyle);
            TextBox.SelectionColor = fontColor;
        }
        private void InfoArticle(string heading)
        {
            articles.Add(new Article(heading, new List<Definition>
            {
                new Definition("Версия", version),
                new Definition("GIT", "https://github.com/Jitropolit/Guide/raw/main/Guide.exe"),
                new Definition("VK", "https://vk.com/jitropolit"),
                new Definition("TG", "@jitropolit")
            }));
        }
        public string Serialize(List<Article> deserializedArticleList)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Article>));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, deserializedArticleList);
                return writer.ToString();
            }
        }
        private List<Article> Deserialize(string serializedArticleList)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Article>));
            using (StringReader reader = new StringReader(serializedArticleList))
                return (List<Article>)serializer.Deserialize(reader);
        }
        #endregion
    }
}

