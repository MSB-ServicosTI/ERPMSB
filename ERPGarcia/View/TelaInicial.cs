using ERPGarcia.Model;
using ERPGarcia.View;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace ERPGarcia
{
    public partial class TelaInicial : CustomForm
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            var loginModel = new LoginModel()
            {
                Username = TxtBLogin.Text,
                Password = TxtBSenha.Text,
            };

            HttpClient requestLogin = new()
            {
                BaseAddress = new Uri("https://localhost:7239/"),

            };

            requestLogin.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await requestLogin.PostAsync("api/User/login", content);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                this.Hide();
                var first = new Home();
                first.Show();
            }
        }
    }
}