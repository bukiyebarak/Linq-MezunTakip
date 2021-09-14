<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="MezunTakip.Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <main>
<!-- visual/banner of the page -->
<section class="visual">
    <div class="visual-inner visual-banner-v2 dark-overlay parallax" data-stellar-background-ratio="0.55">
        <div class="centered">
            <div class="container">
                <div class="visual-text visual-center">
                    <h1 class="visual-title visual-sub-title">İLETİŞİM</h1>
                    <div class="breadcrumb-block">
                        <ol class="breadcrumb">
                            <li class="breadcrumb-item"><a href="Anasayfa.aspx">Ana Sayfa </a></li>
                            <li class="breadcrumb-item active">İletişim </li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--/visual/banner of the page -->
<!-- main content wrapper -->
<div class="content-wrapper">
    <section class="content-block pb-0">
        <div class="container">
            <div class="contact-container ico-box bg-gray-light has-radius-medium">
                <h6 class="content-title contact-title">İLETİŞİM BİLGİLERİ</h6>
                <div class="row">
                    <div class="col-lg-6">
                        <!-- contact form -->
                        <div action="#" method="post" id="contact_form" class="waituk_contact-form ">
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <input type="text" placeholder="AD *" id="con_fname" name="con_fname" class="form-control">
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <input type="text" placeholder="SOYAD *" id="con_lname" name="con_lname" class="form-control">
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <input type="tel" placeholder="TELEFON NUMARASI *" id="con_phone" name="con_phone" class="form-control">
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <input type="email" placeholder="E-MAİL ADRESİ *" id="con_email" name="con_email" class="form-control">
                                    </div>
                                </div>
                            </div>
                            <div class="form-group">
                                <textarea class="form-control" placeholder="MESAJ *" id="con_message" name="con_message"></textarea>
                            </div>
                            <div class="btn-container">
                                <button id="btn_sent" class="btn btn-primary btn-arrow">GÖNDER</button>
                                <p id="error_message"></p>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6 col-xl-5 offset-xl-1">
                        <div class="info-slot">
                            <div class="icon"><span class="custom-icon-map-marker"></span></div>
                            <div class="text">
                                <address>
                                    Karabük Üniversitesi Demir Çelik Kampüsü
                                            <br>
                                    Kılavuzlar Köyü Öte Karşı Üniversite Kampüsü 
                                            <br>
                                    Merkez Karabük
                                </address>
                            </div>
                        </div>
                        <div class="info-slot">
                            <div class="icon"><span class="custom-icon-headset"></span></div>
                            <div class="text">
                                <ul class="content-list contact-list">
                                    <li><span class="label-text">YARDIM</span> <a href="tel:02078777777">444 0 478</a></li>
                                    <li><span class="label-text">SORU</span> <a href="tel:02078777777">444 0 478</a></li>
                                    <li><span class="label-text">FAX</span> <a href="tel:02078777777">0 (370) 418 78 80</a></li>
                                </ul>
                            </div>
                        </div>
                        <div class="info-slot">
                            <div class="icon"><span class="custom-icon-message"></span></div>
                            <div class="text">
                                <ul class="content-list contact-list">
                                    <li><a href="mailto:support@roxine-online">iletisim@karabuk.edu.tr</a></li>
                                    <li><a href="mailto:info@roxine-online.com">muhendislik@karabuk.edu.tr</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <div class="map-holder embed-responsive-21by9 grayscaled-map">
        <iframe class="embed-responsive-item" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3001.2550114756!2d32.64944681495948!3d41.21621291455287!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x408354ac4492953f%3A0xab3b48ed0392a743!2sKarab%C3%BCk+%C3%9Cniversitesi!5e0!3m2!1str!2str!4v1471528432043" height="700" style="border: 0"></iframe>
    </div>
    <aside class="content-block">
        <div class="container">
            <div class="logo-container">
                <div class="owl-carousel logo-slide" id="waituk-owl-slide-4">
                    <div class="slide-item">
                        <a href="https://ais.osym.gov.tr/yetki/giris">
                            <img src="img/logo01.png" alt="osym"></a>
                    </div>
                    <div class="slide-item">
                        <a href="https://www.yok.gov.tr/">
                            <img src="img/logo02.png" alt="yök"></a>
                    </div>
                    <div class="slide-item">
                        <a href="https://tr.linkedin.com/">
                            <img src="img/logo03.jpg" alt="linkedin"></a>
                    </div>
                    <div class="slide-item">
                        <a href="https://www.karabuk.edu.tr/">
                            <img src="img/logokbu.png" alt="kbü"></a>
                    </div>
                    <div class="slide-item">
                        <a href="https://www.kariyer.net/is-ilanlari">
                            <img src="img/logo04.jpg" alt="kariyer.net"></a>
                    </div>
                </div>
            </div>
        </div>
    </aside>
</div>
<!--/main content wrapper -->
    </main>
</asp:Content>
