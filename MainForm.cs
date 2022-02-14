using Guide.Scripts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Guide
{
    public partial class MainForm : Form
    {
        #region Fields
        private readonly string version;
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
        private List<Article> Deserialize(string serializedArticleList)
        {
            var serializer = new XmlSerializer(typeof(List<Article>));
            using (var stringReader = new StringReader(serializedArticleList))
                return (List<Article>)serializer.Deserialize(stringReader);
        }
        #endregion
    }
}

