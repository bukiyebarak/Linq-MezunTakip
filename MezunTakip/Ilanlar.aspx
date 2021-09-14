<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ilanlar.aspx.cs" Inherits="MezunTakip.Ilanlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <!-- visual/banner of the page -->
        <section class="visual">
            <div class="visual-inner visual-banner-v22 dark-overlay parallax" data-stellar-background-ratio="0.55">
                <div class="centered">
                    <div class="container">
                        <div class="visual-text visual-center">
                            <h1 class="visual-title visual-sub-title">İLANLAR</h1>
                            <div class="breadcrumb-block">
                                <ol class="breadcrumb">
                                    <li class="breadcrumb-item"><a href="Anasayfa.aspx">Ana Sayfa </a></li>
                                    <li class="breadcrumb-item active">İlanlar </li>
                                </ol>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--/visual/banner of the page -->
        <!-- main content wrapper -->
        <br />
        <br />
        <br />
        <div class="accordion-container accordion-secondary">
            <div id="accordion4" role="tablist" aria-multiselectable="true">
                <div class="card">
                    <div class="card-header" role="tab" id="headingThirteen">
                        <h5 class="mb-0"><a data-toggle="collapse" href="#collapseThirteen" aria-expanded="true" aria-controls="collapseThirteen">Güncel İş Teklifleri</a></h5>
                    </div>
                    <div id="collapseThirteen" class="collapse show" role="tabpanel" aria-labelledby="headingThirteen">
                        <div class="card-block">
                          <h5>Kendinize uygun iş ilanlarını aşagıdaki bağlantılardan bulabilirsiniz:</h5>
                            <h4><a href="https://www.kariyer.net/is-ilanlari/yeni">Kariyer.net</a></h4>
                            <h4><a href="https://www.yenibiris.com/">Yeni Bir İş</a></h4>
                            <h4><a href="https://esube.iskur.gov.tr/Istihdam/AcikIsIlanAra.aspx">İşKur</a></h4>
                            <h4><a href="https://www.eleman.net/">Eleman.net</a></h4>
                            <h4><a href="https://tr.linkedin.com/">LinkenIn</a></h4>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--/main content wrapper -->
    </main>
</asp:Content>
