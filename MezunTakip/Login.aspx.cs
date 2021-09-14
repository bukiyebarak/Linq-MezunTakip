using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MezunTakip
{
    public partial class Login : System.Web.UI.Page
    {
        //DataClassesDataContext db;
        protected void Page_Load(object sender, EventArgs e)
        {
            // db = new DataClassesDataContext();
            if (!Page.IsPostBack)
            {
                email.Visible = false;
                kullanicimm.Visible = true;
                mesaj1.Visible = false;
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                List<Kullanıcı_Bilgileri> kullanıcıBilgileri = new List<Kullanıcı_Bilgileri>();

                var kullanici = (from k in db.Kullanıcı_Bilgileri where k.KullanıcıAdı == txtKullaniciAdi.Value && k.Sifre == txtPassword.Value select k).FirstOrDefault();

                if (kullanici != null)
                {
                    Session["kullaniciAdi"] = kullanici.KullanıcıAdı;
                    Session["Sifre"] = kullanici.Sifre;
                    Response.Redirect("Kayit1.aspx");
                }
                else
                    Response.Redirect("Kayit1.aspx");

            }
        }

        protected void btnSifreUnuttum_Click(object sender, EventArgs e)
        {
            email.Visible = true;
            kullanicimm.Visible = false;
           
        }

        protected void btnEmailGonder_Click(object sender, EventArgs e)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                if (!String.IsNullOrEmpty(txtemail.Value))
                {
                    var kullanici = (from k in db.Kullanıcı_Bilgileri where k.KullanıcıAdı == txtemail.Value select k).FirstOrDefault();

                    if (kullanici != null)
                    {                       

                        //mail gonderme
                        string Email = txtemail.Value;
                    
                            #region SifreCoz

                            //byte[] cozByteDizi = System.Convert.FromBase64String(kullanici.Sifre);

                            //string orjinalVeri = System.Text.ASCIIEncoding.ASCII.GetString(cozByteDizi);

                            #endregion
                            #region email gönderme

                            // mail gönderme
                            string errorHtml = File.ReadAllText(Server.MapPath("E-mail.txt"));
                            // xmp i alıp smtpsection clasına tanıtıyoruz
                            SmtpSection settings = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
                            // mail bilgilerini smtpsection dan alıyoruz mailmessage clasına tanıtıyoruz


                            MailMessage email = new MailMessage(settings.From, txtemail.Value);
                            email.From = new MailAddress(settings.From, "KARABÜK ÜNİVERSİTESİ ");
                            email.Subject = "ŞİFRE HATIRLATMA ";
                            email.IsBodyHtml = true;
                            email.Body = string.Format(errorHtml, kullanici.KullanıcıAdı);

                            // mail göndermek için yapıyı oluşturuyoruz
                            SmtpClient smtpClient = new SmtpClient();
                            smtpClient.Host = settings.Network.Host;
                            smtpClient.Port = settings.Network.Port;
                            smtpClient.Credentials = new NetworkCredential(settings.Network.UserName, settings.Network.Password);
                            smtpClient.EnableSsl = settings.Network.EnableSsl;

                            // oluşturduğumuz yapıda maili gönderiyoruz.
                            smtpClient.Send(email);

                            #endregion
                            mesaj1.Visible = true;
                         
                    }
                    else
                    {
                        mesaj1.Visible = true;
                        mesaj1.InnerText = "Bu e-posta'ya kayıtlı bir mezun bulunmamaktadır.Lütfen kayıt olunuz....";
                    }

                }
                else
                {
                    mesaj1.InnerText="Lütfen e-posta alanını giriniz";
                   
                }

            }
        }
       
    }
}