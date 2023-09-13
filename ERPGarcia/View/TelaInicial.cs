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
            if (!ValidarCamposLoginSenha())
                return;

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

        private bool ValidarCamposLoginSenha()
        {
            if (TxtBLogin.Text.Length < 3)
            {
                MessageBox.Show("O Usu�rio deve ter mais de 3 d�gitos.", "Aten��o!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBLogin.Text = string.Empty;
                return false;
            }

            if (TxtBSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve conter mais de 6 d�gitos.", "Aten��o!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBSenha.Text = string.Empty;
                return false;
            }

            if (!(TxtBSenha.Text.Any(a => char.IsDigit(a))))
            {
                MessageBox.Show("A senha deve conter pelo menos 1 d�gito numeral", "Aten��o!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBSenha.Text = string.Empty;
                return false;
            }

            if (!(TxtBSenha.Text.Any(a => char.IsUpper(a))))
            {
                MessageBox.Show("A senha deve conter pelo menos 1 letra mai�scula", "Aten��o!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBSenha.Text = string.Empty;
                return false;
            }

            if (!(TxtBSenha.Text.Any(a => char.IsSymbol(a))) && !(TxtBSenha.Text.Any(a => char.IsPunctuation(a))))
            {
                MessageBox.Show("A senha deve conter pelo menos 1 caracter especial", "Aten��o!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBSenha.Text = string.Empty;
                return false;
            }

            return true;
        }
    }
}