<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="MezunTakip.Giris" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main>
                <!-- main content wrapper -->
                <div class="content-wrapper">
                    <div class="row  no-gutters">
                        <div class="col-lg-6 hidden-md-down">
                            <div class="bg-stretch img-wrap">
                                <img src="img/img-kbu.jpg" alt="images">
                            </div>
                        </div>
                        <div class="col-lg-6 signup-block">
                            <div class="signup-wrap text-center">
                                <div class="inner-wrap">
                                    <div class="circular-icon bottom-space"><i class="icon-sign-in"></i></div>
                                    <id action="#" method="post" id="contact_form" class="waituk_contact-form signup-form">
                                        <h2 class="bottom-space">Kullanıcı Girişi</h2>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <input type="text" placeholder="Kullanıcı İsmi YA DA E-mail" id="con_uname" name="con_fname" class="form-control">
                                                </div>
                                            </div>
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <input type="password" placeholder="Şifre" id="con_password" name="con_lname" class="form-control">
                                                </div>
                                            </div>
                                            <div class="col-md-6">
                                                <div class="waituk_select-box">
                                                    <div class="waituk_select-box-default square-box">
                                                        <input type="checkbox" name="checkbox" id="checkbox11">
                                                        <label for="checkbox11" class="m-0">HATIRLA</label>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-6">
                                                <p><a href="SifremiUnuttum.aspx">Şifremi Unuttum ?</a></p>
                                            </div>
                                        </div>
                                        <div class="btn-container mb-3  mb-xl-3 mt-xl-5 mt-lg-2">
                                            <button id="btn_sent" class="btn btn-primary has-radius-small">Giriş</button>
                                        </div>
                                        <p>Mevcut Hesabın Yok Mu?
                                            <a href="Kayit.aspx"> Yeni Hesap </a></p>
                                    </id>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!--/main content wrapper -->
            </main>
</asp:Content>
