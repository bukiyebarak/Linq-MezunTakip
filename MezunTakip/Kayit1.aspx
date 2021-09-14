<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Kayit1.aspx.cs" Inherits="MezunTakip.Kayit1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <div>
            <div class="demo-wrapper content-block pb-0">
                <h3 class="text-center element-heading">KARABÜK ÜNİVERSİTESİ MEZUN TAKİP SİSTEMİ ÜYE KAYIT FORMU </h3>
                <div class="text-center">
                    <div class="bottom-space">
                        <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModalLong">
                            BİLGİ
                        </button>
                    </div>
                    <div class="tab-container tab-black tab-center-container">
                        <!-- Nav tabs -->
                        <ul class="nav nav-tabs tab-text-nav" role="tablist">
                            <li class="nav-item">
                                <a class="nav-link active" data-toggle="tab" href="#tab5" role="tab">PROFİL BİLGİLERİ</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" data-toggle="tab" href="#tab6" role="tab">EĞİTİM BİLGİLERİ</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" data-toggle="tab" href="#tab7" role="tab">İŞ BİLGİLERİ</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" data-toggle="tab" href="#tab8" role="tab">CV</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" data-toggle="tab" href="#tab9" role="tab">TAVSİYELER</a>
                            </li>

                        </ul>
                        <!-- Tab panes -->
                        <div class="top-m-space tab-content">
                            <!-- Profil -->
                            <div class="tab-pane fade show active " id="tab5" role="tabpanel">
                                <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                                    <ContentTemplate>
                                        <div class="container">
                                            <div class="contact-container ico-box bg-gray-light has-radius-medium">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <!-- contact form -->
                                                        <div action="#" method="post" id="contact_form" class="waituk_contact-form">
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label class="label-text font-weight-bold ">RESİM:</label>
                                                                    </div>
                                                                    <br />
                                                                    <br />
                                                                    <br />
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <img src="img/img-person.jpg" height="150" width="120" align="center" alt="personel">
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <asp:DropDownList ID="ddlResimErisim" runat="server" class="form-control is-edit-txt">
                                                                        </asp:DropDownList>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label class="label-text font-weight-bold ">İSİM:</label>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <input id="txtProfilIsim" type="text" runat="server" class="form-control input-group-addon" placeholder="İSİM*" required />
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <asp:DropDownList ID="ddlIsimErisim" runat="server" class="form-control is-edit-txt">
                                                                        </asp:DropDownList>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label class="label-text font-weight-bold ">SOYİSİM:</label>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <input id="txtProfilSoyisim" runat="server" type="text" class="form-control input-group-addon" placeholder="SOYİSİM*" required />
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <asp:DropDownList ID="ddlSoyIsimErisim" runat="server" class="form-control is-edit-txt">
                                                                        </asp:DropDownList>

                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label class="label-text font-weight-bold ">ŞİFRE:</label>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <input id="txtProfilSifre" runat="server" type="text" class="form-control input-group-addon" placeholder="ŞİFRE*" required />
                                                                    </div>
                                                                </div>

                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label class="label-text font-weight-bold ">ÖĞRENCİ NO:</label>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <input id="txtProfilOgrenciNo" runat="server" type="text" placeholder="ÖĞRENCİ NO*" class="form-control input-group-addon" required />
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <asp:DropDownList ID="ddlOgrenciNoErisim" runat="server" class="form-control is-edit-txt">
                                                                        </asp:DropDownList>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label class="label-text font-weight-bold">E-MAİL:</label>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <input id="txtProfilEMail" runat="server" type="text" placeholder="E-MAİL *" name="con_email" class="form-control input-group-addon" required />
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <asp:DropDownList ID="ddlEmailErisim" runat="server" class="form-control is-edit-txt">
                                                                        </asp:DropDownList>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label class="label-text font-weight-bold ">DOĞUM YERİ:</label>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <asp:DropDownList ID="ddlIller" runat="server" class="form-control is-edit-txt">
                                                                        </asp:DropDownList>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <asp:DropDownList ID="ddlDogumYeriErisim" runat="server" class="form-control is-edit-txt">
                                                                        </asp:DropDownList>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label class="label-text font-weight-bold ">ADRES:</label>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <asp:TextBox ID="txtProfilAdres" class="form-control " runat="server" Rows="2" Height="200" placeholder="Adres Bilgilerinizi bu alana giriniz*"></asp:TextBox>

                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <asp:DropDownList ID="ddlAdresErisim" runat="server" class="form-control is-edit-txt">
                                                                        </asp:DropDownList>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label class="label-text font-weight-bold ">CEP TEL:</label>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <input id="txtProfilCepTel" runat="server" type="text" placeholder="CEP TELEFONU*" class="form-control input-group-addon" required />
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <asp:DropDownList ID="ddlCepTelErisim" runat="server" class="form-control is-edit-txt">
                                                                        </asp:DropDownList>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label class="label-text font-weight-bold ">EV TELEFONU:</label>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <input id="txtProfilEvTel" runat="server" type="text" placeholder="Ev Telefonu" class="form-control input-group-addon" />
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <asp:DropDownList ID="ddlEvTelErisim" runat="server" class="form-control is-edit-txt">
                                                                        </asp:DropDownList>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label class="label-text font-weight-bold ">WEB:</label>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <input id="txtProfilWeb" runat="server" type="text" placeholder="Web Sitesi" class="form-control input-group-addon" />
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <asp:DropDownList ID="ddlWebErisim" runat="server" class="form-control is-edit-txt">
                                                                        </asp:DropDownList>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label class="label-text font-weight-bold ">FACEBOOK:</label>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <input id="txtProfilFacebook" runat="server" type="text" placeholder="Facebook Bağlantınız " class="form-control input-group-addon" />
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <asp:DropDownList ID="ddlFacebookErisim" runat="server" class="form-control is-edit-txt">
                                                                        </asp:DropDownList>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label class="label-text font-weight-bold ">TWİTTER:</label>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <input id="txtProfilTwitter" runat="server" type="text" placeholder="Twitter Bağlantınız" class="form-control input-group-addon" />
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <asp:DropDownList ID="ddlTwitterErisim" runat="server" class="form-control is-edit-txt">
                                                                        </asp:DropDownList>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label class="label-text font-weight-bold ">LİNKEDIN</label>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <input id="txtProfilLinkedin" runat="server" type="text" placeholder="LinekdIn Bağlantınız" class="form-control input-group-addon" />
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <asp:DropDownList ID="ddlLinkedinErisim" runat="server" class="form-control is-edit-txt">
                                                                        </asp:DropDownList>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label class="label-text font-weight-bold ">PROFİL RESMİ YÜKLE:</label>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <input type="file" class="form-control" aria-label="file example" />
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <asp:Button ID="btnProfilKaydet" runat="server" class="btn btn-primary btn-sm" Text="PROFİL BİLGİLERİMİ KAYDET" OnClick="btnProfilKaydet_Click" />
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:PostBackTrigger ControlID="btnProfilKaydet" />

                                    </Triggers>
                                </asp:UpdatePanel>
                            </div>
                            <!-- Eğitim -->
                            <div class="tab-pane fade" id="tab6" role="tabpanel">
                                <div class="container">
                                    <div class="contact-container">
                                        <div id="uyari2" runat="server" class="alert">
                                            <span class="closebtn">&times;</span>
                                            <strong>DİKKAT!</strong> LÜTFEN PROFİL BİLGİLERİNİ DOLDURUNUZ...
                                        </div>
                                        <div class="row multiple-row v-align-row">
                                            <div class="col-lg-6 col-md-6">
                                                <div class="col-wrap">
                                                    <div class="ico-box bg-gray-light has-radius-medium">

                                                        <h4 class="text-center">ÖN LİSANS</h4>
                                                        <div class="row">
                                                            <div class="col-md-6">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold "><u>BİLGİLERİM</u>:</label>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-6">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlOLErisim" runat="server" class="form-control is-edit-txt"></asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlOLUniversite" runat="server" class="form-control">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <input id="txtOLFakulte" runat="server" type="text" placeholder="BİRİM/FAKÜLTE" class="form-control" />
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <input id="txtOLBolum" runat="server" type="text" placeholder="BÖLÜM" class="form-control" />
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold ">GİRİŞ TARİHİ:</label>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlOLGirisTrh" runat="server" class="form-control is-edit-txt">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold ">MEZUNİYET TARİHİ:</label>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlOLMezuniyetTrh" runat="server" class="form-control is-edit-txt">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-lg-6 col-md-6">
                                                <div class="col-wrap">
                                                    <div class="ico-box bg-gray-light has-radius-medium">
                                                        <h4 class="text-center">LİSANS</h4>
                                                        <div class="row">
                                                            <div class="col-md-6">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold "><u>BİLGİLERİM</u>:</label>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-6">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlLErisim" runat="server" class="form-control is-edit-txt">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlLUniversite" runat="server" class="form-control">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <input id="txtLFakulte" runat="server" type="text" placeholder="BİRİM/FAKÜLTE" class="form-control" />
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <input id="txtLBolum" runat="server" type="text" placeholder="BÖLÜM" class="form-control" />
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold ">GİRİŞ TARİHİ:</label>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlLGirisTrh" runat="server" class="form-control is-edit-txt">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold ">MEZUNİYET TARİHİ:</label>
                                                                </div>
                                                            </div>

                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlLMezuniyetTrh" runat="server" class="form-control is-edit-txt">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-lg-6 col-md-6">
                                                <div class="col-wrap">
                                                    <div class="ico-box bg-gray-light has-radius-medium">
                                                        <h4 class="text-center">YÜKSEK LİSANS</h4>
                                                        <div class="row">
                                                            <div class="col-md-6">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold "><u>BİLGİLERİM</u>:</label>
                                                                </div>
                                                            </div>

                                                            <div class="col-md-6">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlYLErisim" runat="server" class="form-control is-edit-txt">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>

                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlYLUniversite" runat="server" class="form-control">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>

                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <input id="txtYLEnstitü" runat="server" type="text" placeholder="ENSTİTÜ" class="form-control" />
                                                                </div>
                                                            </div>

                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <input id="txtYLAnabilim" runat="server" type="text" placeholder="ANABİLİM DALI" class="form-control" />
                                                                </div>
                                                            </div>

                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold ">GİRİŞ TARİHİ:</label>
                                                                </div>
                                                            </div>

                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlYLGirisTrh" runat="server" class="form-control is-edit-txt">
                                                                    </asp:DropDownList>

                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold ">MEZUNİYET TARİHİ:</label>
                                                                </div>
                                                            </div>

                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlYLMezuniyetTrh" runat="server" class="form-control is-edit-txt">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-lg-6 col-md-6">
                                                <div class="col-wrap">
                                                    <div class="ico-box bg-gray-light has-radius-medium">
                                                        <h4 class="text-center">DOKTORA</h4>
                                                        <div class="row">
                                                            <div class="col-md-6">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold "><u>BİLGİLERİM</u>:</label>
                                                                </div>
                                                            </div>

                                                            <div class="col-md-6">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlDErisim" runat="server" class="form-control is-edit-txt">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>

                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlDUniversite" runat="server" class="form-control">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>

                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <input id="txtDEnstitu" runat="server" type="text" placeholder="ENSTİTÜ" class="form-control" />
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <input id="txtDAnabilim" runat="server" type="text" placeholder="ANABİLİM DALI" class="form-control" />
                                                                </div>
                                                            </div>

                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold ">GİRİŞ TARİHİ:</label>
                                                                </div>
                                                            </div>

                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlDGirisTrh" runat="server" class="form-control">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold ">MEZUNİYET TARİHİ:</label>
                                                                </div>
                                                            </div>

                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlDMezuniyetTrh" runat="server" class="form-control">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-lg-6 col-md-6">
                                                <div class="col-wrap">
                                                    <div class="ico-box bg-gray-light has-radius-medium">
                                                        <h4 class="text-center">TIPTA UZMANLIK</h4>
                                                        <div class="row">
                                                            <div class="col-md-6">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold "><u>BİLGİLERİM</u>:</label>
                                                                </div>
                                                            </div>

                                                            <div class="col-md-6">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlTUErisim" runat="server" class="form-control is-edit-txt">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>

                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlTUniversite" runat="server" class="form-control">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>

                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <input id="txtTUEnstitu" runat="server" type="text" placeholder="ENSTİTÜ" class="form-control" />
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <input id="txtTUAnabilim" runat="server" type="text" placeholder="ANABİLİM DALI" class="form-control" />
                                                                </div>
                                                            </div>

                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold ">GİRİŞ TARİHİ:</label>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlTUGirisTrh" runat="server" class="form-control">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold ">MEZUNİYET TARİHİ:</label>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlTUMezuniyetTrh" runat="server" class="form-control">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <br />
                                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                            <ContentTemplate>
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <div class="form-group">
                                                            <asp:Button ID="btnEgitimKaydet" runat="server" class="btn btn-primary btn-sm" Text="EĞİTİM BİLGİLERİMİ KAYDET" OnClick="btnEgitimKaydet_Click" />

                                                        </div>
                                                    </div>
                                                </div>

                                            </ContentTemplate>
                                            <Triggers>
                                                <asp:PostBackTrigger ControlID="btnEgitimKaydet" />
                                            </Triggers>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </div>
                            <!-- İş -->
                            <div class="tab-pane fade" id="tab7" role="tabpanel">
                                <div class="container">
                                    <div class="contact-container">
                                        <div id="uyari3" runat="server" class="alert">
                                            <span class="closebtn">&times;</span>
                                            <strong>DİKKAT!</strong> LÜTFEN PROFİL BİLGİLERİNİ DOLDURUNUZ...
                                        </div>
                                        <div class="row multiple-row v-align-row">
                                            <div class="col-lg-12 col-md-12">
                                                <div class="col-wrap">
                                                    <div class="ico-box bg-gray-light has-radius-medium">
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold "><u>BİLGİLERİM</u>:</label>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlErişim" runat="server" class="form-control is-edit-txt">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>

                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold ">SEKTÖR:</label>
                                                                </div>
                                                            </div>

                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlSektor" runat="server" class="form-control is-edit-txt">
                                                                    </asp:DropDownList>

                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold ">POZİSYON:</label>
                                                                </div>
                                                            </div>

                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlPozisyon" runat="server" class="form-control is-edit-txt">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold ">KURUM ADI:</label>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <input id="txtKurumAdı" runat="server" type="text" placeholder="Kurum Adı" class="form-control" required />
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold ">KURUM ÖLÇEĞİ:</label>
                                                                </div>
                                                            </div>

                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlKurumOlcegi" runat="server" class="form-control is-edit-txt">
                                                                    </asp:DropDownList>

                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold ">BAŞLAMA YILI:</label>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <asp:DropDownList ID="ddlIsBilYıllar" runat="server" class="form-control is-edit-txt">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <br />
                                        <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                                            <ContentTemplate>
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <div class="form-group">
                                                            <asp:Button ID="btnIsBilgileriKaydet" runat="server" class="btn btn-primary btn-sm" Text="İŞ BİLGİLERİMİ KAYDET" OnClick="btnIsBilgileriKaydet_Click1" />

                                                        </div>
                                                    </div>
                                                </div>

                                            </ContentTemplate>
                                            <Triggers>
                                                <asp:PostBackTrigger ControlID="btnIsBilgileriKaydet" />
                                            </Triggers>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </div>
                            <!-- CV -->
                            <div class="tab-pane fade" id="tab8" role="tabpanel">
                                <div class="container">
                                    <div class="contact-container">
                                        <div id="uyari4" runat="server" class="alert">
                                            <span class="closebtn">&times;</span>
                                            <strong>DİKKAT!</strong> LÜTFEN PROFİL BİLGİLERİNİ DOLDURUNUZ...
                                        </div>
                                        <div class="row multiple-row v-align-row">
                                            <div class="col-lg-12 col-md-12">
                                                <div class="col-wrap">
                                                    <div class="ico-box bg-gray-light has-radius-medium">
                                                        <h3 class="text-center">CV YÜKLEME</h3>

                                                        <div class="row">
                                                            <div class="col-md-8">
                                                                <div class="form-group form-control edit-txt">
                                                                    <asp:FileUpload ID="fluDosya" runat="server" />
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <br />

                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                            <ContentTemplate>
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <div class="form-group">
                                                            <asp:Button ID="btnCvYukle" runat="server" class="btn btn-primary btn-sm" Text="CV YÜKLE" OnClick="btnCvYukle_Click1" />
                                                        </div>
                                                    </div>
                                                </div>
                                            </ContentTemplate>
                                            <Triggers>
                                                <asp:PostBackTrigger ControlID="btnCvYukle" />
                                            </Triggers>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </div>

                            <%--<asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>

                </ContentTemplate>
                    <Triggers>
                        <asp:PostBackTrigger  ControlID=""/>
                    </Triggers>
            </asp:UpdatePanel>--%>
                            <!-- Tavsiyeler -->
                            <div class="tab-pane fade" id="tab9" role="tabpanel">

                                <div class="container">
                                    <div class="contact-container">
                                        <div id="uyari5" runat="server" class="alert">
                                            <span class="closebtn">&times;</span>
                                            <strong>DİKKAT!</strong> LÜTFEN PROFİL BİLGİLERİNİ DOLDURUNUZ...
                                        </div>
                                        <div class="row multiple-row v-align-row">
                                            <div class="col-lg-12 col-md-12">
                                                <div class="col-wrap">
                                                    <div class="ico-box bg-gray-light has-radius-medium">
                                                        <h5 class="text-center">Üniversite veya mesleğiniz ile ilgili tavsiyeleriniz ya da yorumlarınızı bu bölümde paylaşabilirsiniz. </h5>
                                                        <br />
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label class="label-text font-weight-bold ">YORUM:</label>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-8">
                                                                <div class="form-group">
                                                                    <asp:TextBox ID="txtYorumlar" runat="server" class="form-control" TextMode="MultiLine" Height="100"></asp:TextBox>
                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bu Alanı Doldurunuz..." Display="Static" ControlToValidate="txtYorumlar" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <br />
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                            <ContentTemplate>
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <div class="form-group">
                                                            <asp:Button ID="btnTavsiyeGonder" class="btn btn-primary btn-sm" runat="server" Text="TAVSİYE YAZ" OnClick="btnTavsiyeGonder_Click" />
                                                        </div>
                                                    </div>
                                                </div>
                                            </ContentTemplate>
                                            <Triggers>
                                                <asp:PostBackTrigger ControlID="btnTavsiyeGonder" />
                                            </Triggers>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </div>


                        </div>
                    </div>
                    <!-- Modal -->
                    <div class="modal-wrap large-modal">
                        <div class="modal fade" id="exampleModalLong" tabindex="-1" role="dialog" aria-labelledby="exampleModalLongTitle" aria-hidden="true">
                            <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                    <div class="modal-header bg-gray-light">
                                        <h4 class="modal-title content-title contact-title mb-0" id="exampleModalLongTitle">KARABÜK Üniversitesi Mezun Takip Sistemi Üye Kayıt Formu</h4>
                                        <img src="img/logokbu.png" width="150" height="150">
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <i class="icon-ios-close-empty"></i>
                                        </button>
                                    </div>
                                    <div class="top-m-space tab-content">
                                        <div class="container">
                                            <p>Sisteme girdiğiniz kişisel bilgileriniz, KBÜ tarafından istatistik oluşturmak ve iletişime geçmek için kullanılacaktır. Bilgileriniz hiç bir şekilde üçüncü şahıslarla paylaşılmayacaktır.</p>
                                            <p>Mezun Bilgi Sistemi, mezunlarımız ile üniversitemiz arasındaki bağı koparmamak için ve iletişimi korumaya yönelik oluşturulmuş bir iletişim aracıdır ve üye olmak tamamen <b>ücretsizdir </b>.</p>
                                            <p>Doğru bilgi girişi yapılması, üyeliğinizin onaylanması sırasında önem taşıyacaktır. Doldurulması zorunlu alanlar " * " ile belirtilmiştir.</p>
                                            <p>T.C. Kimlik No. ve/veya Öğrenci No. gibi doğrulama için esas teşkil eden bilgileri güncellemenize izin verilmeyecektir. İstediğinizde, değiştirilmesine izin verilen kişisel bilgilerinizi güncelleyebilirsiniz.</p>
                                            <p>Üye olurken, sisteme giriş yapmak için ve parolanızı unuttuğunuzda yeni şifrenizin gönderildiği geçerli bir E-Posta adresinizi giriniz.</p>
                                        </div>
                                    </div>
                                </div>
                                <div class="modal-footer justify-content-start bg-gray-light">
                                    <button type="button" class="btn btn-primary btn-sm" data-dismiss="modal">KAPAT</button>

                                    <div class="col-md-6">

                                        <a href="Kayit1.aspx">&nbsp &nbsp &nbsp KAYIT OL</a>
                                    </div>
                                    <p>
                                        Mevcut Hesabın Var Mı?
        <a href="Login.aspx">Giriş </a>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>

    </main>
</asp:Content>
