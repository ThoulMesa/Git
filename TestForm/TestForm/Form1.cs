using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace TestForm
{
    public partial class Form1 : Form
    {

        private const string baseUrl = "http://api.mymemory.translated.net";
        private HttpClient httpclient;

        public Form1()
        {
            InitializeComponent();
            httpclient = new HttpClient();
        }

        private async Task<string> TranslateAsync(string text, string sourcelang, string targetlang)
        {
            string url = $"{baseUrl}/get?q={Uri.EscapeDataString(text)}&langpair={sourcelang}|{targetlang}";
            HttpResponseMessage response = await httpclient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            var translationResult = JsonConvert.DeserializeObject<TranslationResponse>(responseJson);
            if(translationResult.ResponseStutus == 200)
            {
                return translationResult.TranslatedText;
            }

            return string.Empty;
        }

        private async void btnTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                string translatedText = await TranslateAsync(txtFrom.Text, cboSourceLangue.SelectedItem.ToString(),cboTargetLangue.SelectedItem.ToString());
                txtTo.Text = translatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Translation fail. Please try again. Error \r\n" + ex);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            cboSourceLangue.BorderRadius = 20;
            cboTargetLangue.BorderRadius = 20;
            cboSourceLangue.Items.AddRange(new String[] { "en", "fr", "de", "es" });
            cboTargetLangue.Items.AddRange(new String[] { "km","en", "fr", "de", "es" });
            cboSourceLangue.SelectedIndex = 0;
            cboTargetLangue.SelectedIndex = 1;
        }
    }

    public class TranslationResponse
    {
        [JsonProperty("responseStatus")]

        public int ResponseStutus {  get; set; }
        [JsonProperty("responseData")]
        public TranslationData ResponseData { get; set; }
        public string TranslatedText => ResponseData.TranslatedText;
    }

    public class TranslationData
    {
        [JsonProperty("TranslatedText")]

        public string TranslatedText { get; set; }
    }
}
