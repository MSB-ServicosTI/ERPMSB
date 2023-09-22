using ERPCommon;
using ERPMSB.View;
using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ERPMSB.View
{
    public partial class RegistroUsers : Form
    {
        public RegistroUsers()
        {
            InitializeComponent();
        }

        private async void Cadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            var registerModel = new RegisterModel()
            {
                NomeColaborador = inputNomeColaborador.Text,
                EmailAddress = inputEmail.Text,
                Username = inputUser.Text,
                Password = inputSenha.Text,
                DataNascimento = dtpDataNascimento.Value,
                TipoContrato = (TipoContrato)cbxTipoContrato.SelectedIndex
            };

            HttpClient requestRegister = new()
            {
                BaseAddress = new Uri(AppSettingsProvider.AppSettings["Ip"]),
            };

            requestRegister.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            StringContent content = new StringContent(JsonConvert.SerializeObject(registerModel), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await requestRegister.PostAsync("api/User/register", content);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                EmailService.EnviarEmail(registerModel);
                MessageBox.Show($"Usuário {registerModel.Username} criado com sucesso");
                inputNomeColaborador.Clear();
                inputEmail.Clear();
                inputUser.Clear();
                inputSenha.Clear();
                inputConfSenha.Clear();
                cbxTipoContrato.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show($"Falha no cadastro do Usuário, tente novamente. \r\n{await response.Content.ReadAsStringAsync()}");
                inputSenha.Clear();
                inputConfSenha.Clear();
            }
        }

        private bool ValidarCampos()
        {
            if (inputUser.Text.Length < 3)
            {
                MessageBox.Show("O Usuário precisa conter mais de 3 caracteres.");
                return false;
            }

            bool verificarEmail = Regex.IsMatch(inputEmail.Text, @"^[A-Za-z0-9.-_]+@[A-Za-z0-9.]+\.[A-Za-z]{2,}$");
            if (!verificarEmail)
            {
                MessageBox.Show("E-mail Inválido.");
                return false;
            }

            if (inputUser.Text.Length > 0 &&
                inputEmail.Text.Length > 0 &&
                inputSenha.Text.Length > 0 &&
                inputConfSenha.Text.Length > 0)
            {
                if (!VerificarSenha(inputSenha.Text))
                {
                    MessageBox.Show("A senha não atende aos requisitos.");
                    return false;
                }

                if (inputSenha.Text != inputConfSenha.Text)
                {
                    MessageBox.Show("As senhas não coincidem.");
                    return false;
                }
            }
            return true;
        }

        private bool VerificarSenha(string senha)
        {
            if (senha.Length < 8 &&
                !senha.Any(char.IsUpper) &&
                !senha.Any(char.IsDigit) &&
                (!senha.Any(c => char.IsSymbol(c)
                || char.IsPunctuation(c))))
                return false;
            return true;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}





