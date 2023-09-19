using ERPAPI.Model;
using ERPMSB.Model;
using ERPMSB.View;
using Newtonsoft.Json;
using System.Collections.Specialized;
using System.Configuration;
using System.Net.Http.Headers;
using System.Text;

namespace ERPMSB
{
    public partial class TelaInicial : CustomForm
    {
        NameValueCollection appSettings = ConfigurationManager.AppSettings;
        public TelaInicial()
        {
            InitializeComponent();
        }

        private async void RealizarLogin() ///funcao para realizar login
        {
            /// TAB corrigido via propriedades
            if (!ValidarCamposLoginSenha())
                return;

            var loginModel = new LoginModel()
            {
                Username = TxtBLogin.Text,
                Password = TxtBSenha.Text,
            };

            HttpClient requestLogin = new()
            {
                BaseAddress = new Uri(appSettings["Ip"]),
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

                return;
            }

            var responseContent = JsonConvert.DeserializeObject<AuthenticationResponse>(await response.Content.ReadAsStringAsync());

            MessageBox.Show(responseContent.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            RealizarLogin(); 
        }

        private bool ValidarCamposLoginSenha()
        {
            if (TxtBLogin.Text.Length < 3)
            {
                MessageBox.Show("O Usuário deve ter mais de 3 dígitos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBLogin.Text = string.Empty;
                return false;
            }

            if (TxtBSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve conter mais de 6 dígitos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBSenha.Text = string.Empty;
                return false;
            }

            if (!(TxtBSenha.Text.Any(a => char.IsDigit(a))))
            {
                MessageBox.Show("A senha deve conter pelo menos 1 dígito numeral", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBSenha.Text = string.Empty;
                return false;
            }

            if (!(TxtBSenha.Text.Any(a => char.IsUpper(a))))
            {
                MessageBox.Show("A senha deve conter pelo menos 1 letra maiúscula", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBSenha.Text = string.Empty;
                return false;
            }

            if (!(TxtBSenha.Text.Any(a => char.IsSymbol(a))) && !(TxtBSenha.Text.Any(a => char.IsPunctuation(a))))
            {
                MessageBox.Show("A senha deve conter pelo menos 1 caracter especial", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBSenha.Text = string.Empty;
                return false;
            }

            return true;
        }

        private void CheckBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPass.Checked)
                TxtBSenha.UseSystemPasswordChar = false;
            else
                TxtBSenha.UseSystemPasswordChar = true;
        }
    }
}