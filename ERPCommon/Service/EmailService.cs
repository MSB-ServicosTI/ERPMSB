using ERPMSB.Model;
using ERPWINFORMS.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Reflection;

namespace ERPCommon
{
    public static class EmailService
    {
        static NameValueCollection appSettings = ConfigurationManager.AppSettings;
        public static SmtpClient smtpClient = new SmtpClient("smtp.office365.com")
        {
            Port = 587,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(appSettings["EmailUser"], appSettings["EmailPassword"]),
            EnableSsl = true,
        };


        public async static void EnviarEmail(RegisterModel model)
        {
            MailMessage mail = new MailMessage(appSettings["Emailuser"], model.EmailAddress, "Bem vindo ao ERP - MSB!",
            @$"<html>
                <body>
                    <p>Olá {model.NomeColaborador}, sua conta acabou de ser criada no ERP - MSB!</p>
                        Esperamos que goste e aproveite de nosso sistema!</br>
                    <p>Seu usuário para login é: {model.Username}</p>
                </body>
            </html>");
            mail.IsBodyHtml = true;
            await smtpClient.SendMailAsync(mail);
            }

        public async static void EnviarEmailCodigoSenha(ColaboradorDTO model, Guid codigoSenha)
            {
            MailMessage mail = new MailMessage(AppSettingsProvider.AppSettings["Emailuser"], model.Email, "Código para recuperação de senha. ERP - MSB!",
            @$"<html>
                <body>
                    <p>Olá {model.Nome}, aqui está seu código para recuperação de senha!</p>
                        {codigoSenha}</br>
                </body>
            </html>");
            mail.IsBodyHtml = true;
            await smtpClient.SendMailAsync(mail);
        }
    }
}
