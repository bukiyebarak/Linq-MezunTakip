<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MezunTakip.Login" %>

<!DOCTYPE html>

<html lang="tr">
<head>
    <title>Giris</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link href="https://fonts.googleapis.com/css?family=Lato:300,400,700&display=swap" rel="stylesheet">

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">

    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <section class="ftco-section">
        <div class="container">
            <form runat="server" id="form1">
                <div class="row justify-content-center">
                    <div class="col-md-6 text-center mb-5">
                        <h2 class="heading-section">ÜYE GİRİŞİ</h2>
                    </div>
                </div>
                <div class="row justify-content-center" id="kullanici" runat="server">
                    <div class="col-md-6 col-lg-4">
                        <div class="login-wrap py-5">
                            <div class="img d-flex align-items-center justify-content-center" style="background-image: url(img/bg.jpg);"></div>
                            <h3 class="text-center mb-0">HOŞGELDİNİZ</h3>
                            <p class="text-center">Aşağıdaki bilgileri girerek oturum açınız.</p>

                            <div action="#" class="login-form" id="kullanicimm" runat="server">
                                <div class="form-group">
                                    <div class="icon d-flex align-items-center justify-content-center"><span class="fa fa-user"></span></div>
                                    <input type="text" id="txtKullaniciAdi" runat="server" class="form-control" placeholder="Kullanıcı Adı(E-mail)">
                                </div>
                                <div class="form-group">
                                    <div class="icon d-flex align-items-center justify-content-center"><span class="fa fa-lock"></span></div>
                                    <input type="password" id="txtPassword" runat="server" class="form-control" placeholder="Şifre">
                                </div>
                                <div class="form-group">
                                </div>
                                <div class="form-group">
                                    <asp:Button ID="btnLogin" class="btn form-control btn-primary rounded submit px-3" runat="server" Text="Giriş" OnClick="btnLogin_Click" />
                                </div>
                                <div class="form-group">
                                    <asp:Button ID="btnSifreUnuttum" class="btn form-control btn-primary rounded submit px-3" runat="server" Text="Şifremi Unuttum" OnClick="btnSifreUnuttum_Click" />
                                </div>
                            </div>

                            <div id="email" runat="server" class="login-form">
                                <div class="form-group">
                                    <div class="icon d-flex align-items-center justify-content-center"><span class="fa fa-user"></span></div>
                                    <input type="text" id="txtemail" runat="server" class="form-control" placeholder="Kullanıcı Adı(E-posta)">
                                </div>
                                <div class="form-group">
                                    <asp:Button ID="btnEmailGonder" class="btn form-control btn-primary rounded submit px-3" runat="server" Text="Mail Gönder" OnClick="btnEmailGonder_Click" />
                                </div>
                            </div>
                            <div class="form-group">
                                <label id="mesaj1" runat="server"></label>
                            </div>
                            <div class="w-100 text-center mt-4 text">
                                <p class="mb-0">Hesabınız yok mu?</p>
                                <a href="Kayit1.aspx">Kayıt Ol</a>
                            </div>
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </section>
    <script src="js/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/main.js"></script>
    <script src="js/popper.js"></script>

</body>
</html>
