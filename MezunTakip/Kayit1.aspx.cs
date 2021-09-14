using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MezunTakip
{

    public partial class Kayit1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                uyari2.Visible = false;
                uyari3.Visible = false;
                uyari4.Visible = false;
                uyari5.Visible = false;

                using (DataClassesDataContext db = new DataClassesDataContext())
                {
                    #region Başlangıc parametreleri


                    #region Erisim izni

                    var erisimlist = (from er in db.Erisim_Izni select er).ToList();

                    if (erisimlist != null)
                    {
                        #region Is Bilgileri Erisim

                        ddlErişim.DataSource = erisimlist;
                        ddlErişim.DataValueField = "Id";
                        ddlErişim.DataTextField = "ErisimDurumu";
                        ddlErişim.DataBind();
                        ddlErişim.Items.Insert(0, "SEÇİNİZ");

                        #endregion

                        #region Egitim Bilgileri Erisimler

                        ddlOLErisim.DataSource = erisimlist;
                        ddlOLErisim.DataValueField = "Id";
                        ddlOLErisim.DataTextField = "ErisimDurumu";
                        ddlOLErisim.DataBind();
                        ddlOLErisim.Items.Insert(0, "SEÇİNİZ");

                        ddlLErisim.DataSource = erisimlist;
                        ddlLErisim.DataValueField = "Id";
                        ddlLErisim.DataTextField = "ErisimDurumu";
                        ddlLErisim.DataBind();
                        ddlLErisim.Items.Insert(0, "SEÇİNİZ");

                        ddlYLErisim.DataSource = erisimlist;
                        ddlYLErisim.DataValueField = "Id";
                        ddlYLErisim.DataTextField = "ErisimDurumu";
                        ddlYLErisim.DataBind();
                        ddlYLErisim.Items.Insert(0, "SEÇİNİZ");

                        ddlDErisim.DataSource = erisimlist;
                        ddlDErisim.DataValueField = "Id";
                        ddlDErisim.DataTextField = "ErisimDurumu";
                        ddlDErisim.DataBind();
                        ddlDErisim.Items.Insert(0, "SEÇİNİZ");

                        ddlTUErisim.DataSource = erisimlist;
                        ddlTUErisim.DataValueField = "Id";
                        ddlTUErisim.DataTextField = "ErisimDurumu";
                        ddlTUErisim.DataBind();
                        ddlTUErisim.Items.Insert(0, "SEÇİNİZ");
                        #endregion

                        #region Profil Bilgileri

                        ddlResimErisim.DataSource = erisimlist;
                        ddlResimErisim.DataValueField = "Id";
                        ddlResimErisim.DataTextField = "ErisimDurumu";
                        ddlResimErisim.DataBind();
                        ddlResimErisim.Items.Insert(0, "SEÇİNİZ");

                        ddlIsimErisim.DataSource = erisimlist;
                        ddlIsimErisim.DataValueField = "Id";
                        ddlIsimErisim.DataTextField = "ErisimDurumu";
                        ddlIsimErisim.DataBind();
                        ddlIsimErisim.Items.Insert(0, "SEÇİNİZ");

                        ddlSoyIsimErisim.DataSource = erisimlist;
                        ddlSoyIsimErisim.DataValueField = "Id";
                        ddlSoyIsimErisim.DataTextField = "ErisimDurumu";
                        ddlSoyIsimErisim.DataBind();
                        ddlSoyIsimErisim.Items.Insert(0, "SEÇİNİZ");

                        ddlOgrenciNoErisim.DataSource = erisimlist;
                        ddlOgrenciNoErisim.DataValueField = "Id";
                        ddlOgrenciNoErisim.DataTextField = "ErisimDurumu";
                        ddlOgrenciNoErisim.DataBind();
                        ddlOgrenciNoErisim.Items.Insert(0, "SEÇİNİZ");

                        ddlEmailErisim.DataSource = erisimlist;
                        ddlEmailErisim.DataValueField = "Id";
                        ddlEmailErisim.DataTextField = "ErisimDurumu";
                        ddlEmailErisim.DataBind();
                        ddlEmailErisim.Items.Insert(0, "SEÇİNİZ");

                        ddlDogumYeriErisim.DataSource = erisimlist;
                        ddlDogumYeriErisim.DataValueField = "Id";
                        ddlDogumYeriErisim.DataTextField = "ErisimDurumu";
                        ddlDogumYeriErisim.DataBind();
                        ddlDogumYeriErisim.Items.Insert(0, "SEÇİNİZ");

                        ddlAdresErisim.DataSource = erisimlist;
                        ddlAdresErisim.DataValueField = "Id";
                        ddlAdresErisim.DataTextField = "ErisimDurumu";
                        ddlAdresErisim.DataBind();
                        ddlAdresErisim.Items.Insert(0, "SEÇİNİZ");

                        ddlCepTelErisim.DataSource = erisimlist;
                        ddlCepTelErisim.DataValueField = "Id";
                        ddlCepTelErisim.DataTextField = "ErisimDurumu";
                        ddlCepTelErisim.DataBind();
                        ddlCepTelErisim.Items.Insert(0, "SEÇİNİZ");

                        ddlEvTelErisim.DataSource = erisimlist;
                        ddlEvTelErisim.DataValueField = "Id";
                        ddlEvTelErisim.DataTextField = "ErisimDurumu";
                        ddlEvTelErisim.DataBind();
                        ddlEvTelErisim.Items.Insert(0, "SEÇİNİZ");

                        ddlWebErisim.DataSource = erisimlist;
                        ddlWebErisim.DataValueField = "Id";
                        ddlWebErisim.DataTextField = "ErisimDurumu";
                        ddlWebErisim.DataBind();
                        ddlWebErisim.Items.Insert(0, "SEÇİNİZ");

                        ddlFacebookErisim.DataSource = erisimlist;
                        ddlFacebookErisim.DataValueField = "Id";
                        ddlFacebookErisim.DataTextField = "ErisimDurumu";
                        ddlFacebookErisim.DataBind();
                        ddlFacebookErisim.Items.Insert(0, "SEÇİNİZ");

                        ddlTwitterErisim.DataSource = erisimlist;
                        ddlTwitterErisim.DataValueField = "Id";
                        ddlTwitterErisim.DataTextField = "ErisimDurumu";
                        ddlTwitterErisim.DataBind();
                        ddlTwitterErisim.Items.Insert(0, "SEÇİNİZ");

                        ddlLinkedinErisim.DataSource = erisimlist;
                        ddlLinkedinErisim.DataValueField = "Id";
                        ddlLinkedinErisim.DataTextField = "ErisimDurumu";
                        ddlLinkedinErisim.DataBind();
                        ddlLinkedinErisim.Items.Insert(0, "SEÇİNİZ");

                        #endregion
                    }

                    #endregion

                    #region Sektor Bilgileri

                    var sektorlist = (from s in db.Sektor_Bilgileri select s).ToList();
                    if (sektorlist != null)
                    {
                        ddlSektor.DataSource = sektorlist;
                        ddlSektor.DataValueField = "Id";
                        ddlSektor.DataTextField = "SektorAdi";
                        ddlSektor.DataBind();
                    }
                    #endregion

                    #region Pozisyon Bilgileri
                    var pozisyonlist = (from p in db.Pozisyon_Bilgileri select p).ToList();
                    if (pozisyonlist != null)
                    {
                        ddlPozisyon.DataSource = pozisyonlist;
                        ddlPozisyon.DataValueField = "Id";
                        ddlPozisyon.DataTextField = "PozisyonAdi";
                        ddlPozisyon.DataBind();
                    }
                    #endregion

                    #region Kurum Olcegi Bilgileri

                    var kurumolcegilist = (from ko in db.Kurum_Olcegi_Bilgileri select ko).ToList();
                    if (kurumolcegilist != null)
                    {
                        ddlKurumOlcegi.DataSource = kurumolcegilist;
                        ddlKurumOlcegi.DataValueField = "Id";
                        ddlKurumOlcegi.DataTextField = "KurumOlcegiAdi";
                        ddlKurumOlcegi.DataBind();
                    }
                    #endregion

                    #region Universiteler

                    var universitelist = (from u in db.Universite select u).ToList();
                    if (universitelist != null)
                    {
                        ddlOLUniversite.DataSource = universitelist;
                        ddlOLUniversite.DataValueField = "Id";
                        ddlOLUniversite.DataTextField = "UniversiteAdi";
                        ddlOLUniversite.DataBind();

                        ddlLUniversite.DataSource = universitelist;
                        ddlLUniversite.DataValueField = "Id";
                        ddlLUniversite.DataTextField = "UniversiteAdi";
                        ddlLUniversite.DataBind();

                        ddlYLUniversite.DataSource = universitelist;
                        ddlYLUniversite.DataValueField = "Id";
                        ddlYLUniversite.DataTextField = "UniversiteAdi";
                        ddlYLUniversite.DataBind();

                        ddlDUniversite.DataSource = universitelist;
                        ddlDUniversite.DataValueField = "Id";
                        ddlDUniversite.DataTextField = "UniversiteAdi";
                        ddlDUniversite.DataBind();

                        ddlTUniversite.DataSource = universitelist;
                        ddlTUniversite.DataValueField = "Id";
                        ddlTUniversite.DataTextField = "UniversiteAdi";
                        ddlTUniversite.DataBind();
                    }
                    #endregion

                    #region Yıllar
                    var yıllarlist = (from y in db.Yıl select y).ToList();
                    if (yıllarlist != null)
                    {
                        #region Iş Bilgileri Baslama Yılı

                        ddlIsBilYıllar.DataSource = yıllarlist;
                        ddlIsBilYıllar.DataValueField = "Id";
                        ddlIsBilYıllar.DataTextField = "Yıllar";
                        ddlIsBilYıllar.DataBind();
                        #endregion

                        #region Egitim Bilgileri Yıllar

                        ddlOLGirisTrh.DataSource = yıllarlist;
                        ddlOLGirisTrh.DataValueField = "Id";
                        ddlOLGirisTrh.DataTextField = "Yıllar";
                        ddlOLGirisTrh.DataBind();

                        ddlOLMezuniyetTrh.DataSource = yıllarlist;
                        ddlOLMezuniyetTrh.DataValueField = "Id";
                        ddlOLMezuniyetTrh.DataTextField = "Yıllar";
                        ddlOLMezuniyetTrh.DataBind();

                        ddlLGirisTrh.DataSource = yıllarlist;
                        ddlLGirisTrh.DataValueField = "Id";
                        ddlLGirisTrh.DataTextField = "Yıllar";
                        ddlLGirisTrh.DataBind();

                        ddlLMezuniyetTrh.DataSource = yıllarlist;
                        ddlLMezuniyetTrh.DataValueField = "Id";
                        ddlLMezuniyetTrh.DataTextField = "Yıllar";
                        ddlLMezuniyetTrh.DataBind();

                        ddlYLGirisTrh.DataSource = yıllarlist;
                        ddlYLGirisTrh.DataValueField = "Id";
                        ddlYLGirisTrh.DataTextField = "Yıllar";
                        ddlYLGirisTrh.DataBind();

                        ddlYLMezuniyetTrh.DataSource = yıllarlist;
                        ddlYLMezuniyetTrh.DataValueField = "Id";
                        ddlYLMezuniyetTrh.DataTextField = "Yıllar";
                        ddlYLMezuniyetTrh.DataBind();

                        ddlDGirisTrh.DataSource = yıllarlist;
                        ddlDGirisTrh.DataValueField = "Id";
                        ddlDGirisTrh.DataTextField = "Yıllar";
                        ddlDGirisTrh.DataBind();

                        ddlDMezuniyetTrh.DataSource = yıllarlist;
                        ddlDMezuniyetTrh.DataValueField = "Id";
                        ddlDMezuniyetTrh.DataTextField = "Yıllar";
                        ddlDMezuniyetTrh.DataBind();

                        ddlTUGirisTrh.DataSource = yıllarlist;
                        ddlTUGirisTrh.DataValueField = "Id";
                        ddlTUGirisTrh.DataTextField = "Yıllar";
                        ddlTUGirisTrh.DataBind();

                        ddlTUMezuniyetTrh.DataSource = yıllarlist;
                        ddlTUMezuniyetTrh.DataValueField = "Id";
                        ddlTUMezuniyetTrh.DataTextField = "Yıllar";
                        ddlTUMezuniyetTrh.DataBind();


                        #endregion
                    }
                    #endregion

                    #region Iller

                    var illerlist = (from il in db.Iller select il).ToList();
                    if (illerlist != null)
                    {
                        ddlIller.DataSource = illerlist;
                        ddlIller.DataValueField = "pkod";
                        ddlIller.DataTextField = "pchar";
                        ddlIller.DataBind();
                        ddlIller.Items.Insert(0, "SEÇİNİZ");

                    }
                    #endregion
                    #endregion

                    #region Veri Yükleme
                    if (Session["kullaniciAdi"] != null && Session["Sifre"] != null)
                    {
                        var kullanici = (from k in db.vw_KullaniciBilgileri where k.EMail == Session["kullaniciAdi"].ToString() && k.Sifre == Session["Sifre"].ToString() select k).FirstOrDefault();
                        string noSorgu = kullanici.OgrenciNo;
                        if (!string.IsNullOrEmpty(noSorgu))
                        {

                            #region profil

                            var profilKullanici = (from o_number in db.Profil_Bilgileri where o_number.OgrenciNo == noSorgu select o_number).FirstOrDefault();

                            txtProfilIsim.Value = profilKullanici.Isım;
                            ddlIsimErisim.SelectedValue = profilKullanici.IsımId;
                            txtProfilSoyisim.Value = profilKullanici.SoyIsım;
                            ddlSoyIsimErisim.SelectedValue = profilKullanici.SoyIsımId;
                            txtProfilEMail.Value = profilKullanici.EMail;
                            ddlEmailErisim.SelectedValue = profilKullanici.EmailId;
                            txtProfilOgrenciNo.Value = profilKullanici.OgrenciNo;
                            ddlOgrenciNoErisim.SelectedValue = profilKullanici.OgrenciNoId;
                            txtProfilAdres.Text = profilKullanici.Adres;
                            ddlAdresErisim.SelectedValue = profilKullanici.AdresId;
                            txtProfilCepTel.Value = profilKullanici.CepTel;
                            ddlCepTelErisim.SelectedValue = profilKullanici.CepTelId;
                            txtProfilEvTel.Value = profilKullanici.EvTel;
                            ddlEvTelErisim.SelectedItem.Value = profilKullanici.EvTelId;
                            txtProfilWeb.Value = profilKullanici.Web;
                            ddlWebErisim.SelectedValue = profilKullanici.WebId;
                            txtProfilFacebook.Value = profilKullanici.Facebook;
                            ddlFacebookErisim.SelectedValue = profilKullanici.FacebookId;
                            txtProfilTwitter.Value = profilKullanici.Twitter;
                            ddlTwitterErisim.SelectedValue = profilKullanici.TwitterId;
                            txtProfilLinkedin.Value = profilKullanici.Linkedin;
                            ddlLinkedinErisim.SelectedValue = profilKullanici.linkedinId;
                            ddlIller.SelectedValue = profilKullanici.DogumYeri;
                            ddlDogumYeriErisim.SelectedValue = profilKullanici.DogumYeriId;
                            #endregion

                            #region is bilgileri
                            var isbilgisi = (from k in db.Is_Bilgileri where k.IsOgrenciNo == noSorgu select k).FirstOrDefault();
                            txtKurumAdı.Value = isbilgisi.KurumAdi;
                            ddlErişim.SelectedValue = isbilgisi.IErisimId;
                            ddlSektor.SelectedValue = isbilgisi.SektorId;
                            ddlPozisyon.SelectedValue = isbilgisi.PozisyonId;
                            ddlKurumOlcegi.SelectedValue = isbilgisi.KurumOlcegiId;
                            ddlIsBilYıllar.SelectedValue = isbilgisi.Yıllar;
                            txtProfilOgrenciNo.Value = isbilgisi.IsOgrenciNo;
                            #endregion

                            #region egitim
                            var egitimkullanici = (from egitim in db.Egitim_Bilgileri where egitim.EgitimOgrenciNo == noSorgu select egitim).FirstOrDefault();

                            ddlOLErisim.SelectedValue = egitimkullanici.OLErisimId;
                            ddlOLUniversite.SelectedValue = egitimkullanici.OLUniversiteId;
                            txtOLFakulte.Value = egitimkullanici.OLFakulte;
                            ddlOLGirisTrh.SelectedValue = egitimkullanici.OLGirisTarihi;
                            ddlOLMezuniyetTrh.SelectedValue = egitimkullanici.OLMezuniyetTarihi;
                            ddlOLErisim.SelectedValue = egitimkullanici.OLErisimId;
                            ddlOLUniversite.SelectedValue = egitimkullanici.OLUniversiteId;
                            txtOLFakulte.Value = egitimkullanici.OLFakulte;
                            ddlOLGirisTrh.SelectedValue = egitimkullanici.OLGirisTarihi;
                            ddlOLMezuniyetTrh.SelectedValue = egitimkullanici.OLMezuniyetTarihi;
                            ddlLErisim.SelectedValue = egitimkullanici.LErisimId;
                            ddlLUniversite.SelectedValue = egitimkullanici.LUniversiteId;
                            txtLFakulte.Value = egitimkullanici.LFakulte;
                            ddlLGirisTrh.SelectedValue = egitimkullanici.LGirisTarihi;
                            ddlLMezuniyetTrh.SelectedValue = egitimkullanici.LMezuniyetTarihi;
                            ddlYLErisim.SelectedValue = egitimkullanici.YLErisimId;
                            ddlYLUniversite.SelectedValue = egitimkullanici.YLUniversiteId;
                            txtYLEnstitü.Value = egitimkullanici.YLEnstitü;
                            ddlYLGirisTrh.SelectedValue = egitimkullanici.YLGirisTarihi;
                            ddlYLMezuniyetTrh.SelectedValue = egitimkullanici.YLMezuniyetTarihi;
                            ddlDErisim.SelectedValue = egitimkullanici.DokErisimId;
                            ddlDUniversite.SelectedValue = egitimkullanici.DokUniversiteId;
                            txtDEnstitu.Value = egitimkullanici.DokEnstitü;
                            ddlDGirisTrh.SelectedValue = egitimkullanici.DokGirisTarihi;
                            ddlDMezuniyetTrh.SelectedValue = egitimkullanici.DokMezuniyetTarihi;
                            ddlTUErisim.SelectedValue = egitimkullanici.TıpErisimId;
                            ddlTUniversite.SelectedValue = egitimkullanici.TıpUniversiteId;
                            txtTUEnstitu.Value = egitimkullanici.TıpEnstitü;
                            ddlTUGirisTrh.SelectedValue = egitimkullanici.TıpGirisTarihi;
                            ddlTUMezuniyetTrh.SelectedValue = egitimkullanici.TıpMezuniyetTarihi;
                            txtOLBolum.Value = egitimkullanici.OLBolum;
                            txtLBolum.Value = egitimkullanici.LBolum;
                            txtYLAnabilim.Value = egitimkullanici.YLAnabilim;
                            txtDAnabilim.Value = egitimkullanici.DAnabilim;
                            txtTUAnabilim.Value = egitimkullanici.TUAnabilim;
                            txtProfilOgrenciNo.Value = egitimkullanici.EgitimOgrenciNo;
                            #endregion
                            #region tavsiye
                            var tavsiyem = (from o_number in db.Tavsiyeler where o_number.TavsiyeOgrenciNo == noSorgu select o_number).FirstOrDefault();

                            txtYorumlar.Text = tavsiyem.Yorum;
                            txtProfilOgrenciNo.Value = tavsiyem.TavsiyeOgrenciNo ;

                            #endregion

                            #region Cv
                            

                            #endregion

                        }

                    }
                    #endregion
                }
            }
        }

        protected void btnEgitimKaydet_Click(object sender, EventArgs e)
        {


            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                if (!string.IsNullOrEmpty(txtProfilOgrenciNo.Value))
                {
                    var egitimkullanici = (from egitim in db.Egitim_Bilgileri where egitim.EgitimOgrenciNo == txtProfilOgrenciNo.Value select egitim).FirstOrDefault();
                    if (egitimkullanici != null)
                    {
                        //Update
                        egitimkullanici.OLErisimId = ddlOLErisim.SelectedItem.Value.ToString();
                        egitimkullanici.OLUniversiteId = ddlOLUniversite.SelectedItem.Value.ToString();
                        egitimkullanici.OLFakulte = txtOLFakulte.Value;
                        egitimkullanici.OLGirisTarihi = ddlOLGirisTrh.SelectedItem.Value.ToString();
                        egitimkullanici.OLMezuniyetTarihi = ddlOLMezuniyetTrh.SelectedItem.Value.ToString();
                        egitimkullanici.LErisimId = ddlLErisim.SelectedItem.Value.ToString();
                        egitimkullanici.LUniversiteId = ddlLUniversite.SelectedItem.Value.ToString();
                        egitimkullanici.LFakulte = txtLFakulte.Value;
                        egitimkullanici.LGirisTarihi = ddlLGirisTrh.SelectedItem.Value.ToString();
                        egitimkullanici.LMezuniyetTarihi = ddlLMezuniyetTrh.SelectedItem.Value.ToString();
                        egitimkullanici.YLErisimId = ddlYLErisim.SelectedItem.Value.ToString();
                        egitimkullanici.YLUniversiteId = ddlYLUniversite.SelectedItem.Value.ToString();
                        egitimkullanici.YLEnstitü = txtYLEnstitü.Value;
                        egitimkullanici.YLGirisTarihi = ddlYLGirisTrh.SelectedItem.Value.ToString();
                        egitimkullanici.YLMezuniyetTarihi = ddlYLMezuniyetTrh.SelectedItem.Value.ToString();
                        egitimkullanici.DokErisimId = ddlDErisim.SelectedItem.Value.ToString();
                        egitimkullanici.DokUniversiteId = ddlDUniversite.SelectedItem.Value.ToString();
                        egitimkullanici.DokEnstitü = txtDEnstitu.Value;
                        egitimkullanici.DokGirisTarihi = ddlDGirisTrh.SelectedItem.Value.ToString();
                        egitimkullanici.DokMezuniyetTarihi = ddlDMezuniyetTrh.SelectedItem.Value.ToString();
                        egitimkullanici.TıpErisimId = ddlTUErisim.SelectedItem.Value.ToString();
                        egitimkullanici.TıpUniversiteId = ddlTUniversite.SelectedItem.Value.ToString();
                        egitimkullanici.TıpEnstitü = txtTUEnstitu.Value;
                        egitimkullanici.TıpGirisTarihi = ddlTUGirisTrh.SelectedItem.Value.ToString();
                        egitimkullanici.TıpMezuniyetTarihi = ddlTUMezuniyetTrh.SelectedItem.Value.ToString();
                        egitimkullanici.OLBolum = txtOLBolum.Value;
                        egitimkullanici.LBolum = txtLBolum.Value;
                        egitimkullanici.YLAnabilim = txtYLAnabilim.Value;
                        egitimkullanici.DAnabilim = txtDAnabilim.Value;
                        egitimkullanici.TUAnabilim = txtTUAnabilim.Value;
                        egitimkullanici.EgitimOgrenciNo = txtProfilOgrenciNo.Value;

                        db.SubmitChanges();
                    }
                    else
                    {
                        Egitim_Bilgileri kullaniciEgitim = new Egitim_Bilgileri
                        {
                            OLErisimId = ddlOLErisim.SelectedItem.Value.ToString(),
                            OLUniversiteId = ddlOLUniversite.SelectedItem.Value.ToString(),
                            OLFakulte = txtOLFakulte.Value,
                            OLGirisTarihi = ddlOLGirisTrh.SelectedItem.Value.ToString(),
                            OLMezuniyetTarihi = ddlOLMezuniyetTrh.SelectedItem.Value.ToString(),
                            LErisimId = ddlLErisim.SelectedItem.Value.ToString(),
                            LUniversiteId = ddlLUniversite.SelectedItem.Value.ToString(),
                            LFakulte = txtLFakulte.Value,
                            LGirisTarihi = ddlLGirisTrh.SelectedItem.Value.ToString(),
                            LMezuniyetTarihi = ddlLMezuniyetTrh.SelectedItem.Value.ToString(),
                            YLErisimId = ddlYLErisim.SelectedItem.Value.ToString(),
                            YLUniversiteId = ddlYLUniversite.SelectedItem.Value.ToString(),
                            YLEnstitü = txtYLEnstitü.Value,
                            YLGirisTarihi = ddlYLGirisTrh.SelectedItem.Value.ToString(),
                            YLMezuniyetTarihi = ddlYLMezuniyetTrh.SelectedItem.Value.ToString(),
                            DokErisimId = ddlDErisim.SelectedItem.Value.ToString(),
                            DokUniversiteId = ddlDUniversite.SelectedItem.Value.ToString(),
                            DokEnstitü = txtDEnstitu.Value,
                            DokGirisTarihi = ddlDGirisTrh.SelectedItem.Value.ToString(),
                            DokMezuniyetTarihi = ddlDMezuniyetTrh.SelectedItem.Value.ToString(),
                            TıpErisimId = ddlTUErisim.SelectedItem.Value.ToString(),
                            TıpUniversiteId = ddlTUniversite.SelectedItem.Value.ToString(),
                            TıpEnstitü = txtTUEnstitu.Value,
                            TıpGirisTarihi = ddlTUGirisTrh.SelectedItem.Value.ToString(),
                            TıpMezuniyetTarihi = ddlTUMezuniyetTrh.SelectedItem.Value.ToString(),
                            OLBolum = txtOLBolum.Value,
                            LBolum = txtLBolum.Value,
                            YLAnabilim = txtYLAnabilim.Value,
                            DAnabilim = txtDAnabilim.Value,
                            EgitimOgrenciNo = txtProfilOgrenciNo.Value
                        };

                        db.Egitim_Bilgileri.InsertOnSubmit(kullaniciEgitim);
                        db.SubmitChanges();
                    }
                }
                else
                {
                    uyari2.Visible = true;
                }
            }
        }
        protected void btnTavsiyeGonder_Click(object sender, EventArgs e)
        {

            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                if (!String.IsNullOrEmpty(txtProfilOgrenciNo.Value))
                {
                    var tavsiyem = (from o_number in db.Tavsiyeler where o_number.TavsiyeOgrenciNo == txtProfilOgrenciNo.Value select o_number).FirstOrDefault();

                    if (tavsiyem != null)
                    {
                        //update                        
                        tavsiyem.Yorum = txtYorumlar.Text;
                        tavsiyem.TavsiyeOgrenciNo = txtProfilOgrenciNo.Value;
                        db.SubmitChanges();
                    }
                    else
                    { //insert
                        Tavsiyeler tavsiye = new Tavsiyeler
                        {
                            TavsiyeOgrenciNo = txtProfilOgrenciNo.Value,
                            Yorum = txtYorumlar.Text,

                        };
                        db.Tavsiyeler.InsertOnSubmit(tavsiye);
                        db.SubmitChanges();
                    }
                }
                else
                {
                    uyari5.Visible = true;
                }
            }
        }
        protected void btnProfilKaydet_Click(object sender, EventArgs e)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var profilKullanici = (from o_number in db.Profil_Bilgileri where o_number.OgrenciNo == txtProfilOgrenciNo.Value select o_number).FirstOrDefault();
               
                if (profilKullanici != null)
                {
                    //update
                    profilKullanici.Isım = txtProfilIsim.Value;
                    profilKullanici.IsımId = ddlIsimErisim.SelectedValue.ToString();
                    profilKullanici.SoyIsım = txtProfilSoyisim.Value;
                    profilKullanici.SoyIsımId = ddlSoyIsimErisim.SelectedValue.ToString();
                    profilKullanici.EMail = txtProfilEMail.Value;
                    profilKullanici.EmailId = ddlEmailErisim.SelectedValue.ToString();
                    profilKullanici.OgrenciNo = txtProfilOgrenciNo.Value;
                    profilKullanici.OgrenciNoId = ddlOgrenciNoErisim.SelectedValue.ToString();
                    profilKullanici.Adres = txtProfilAdres.Text;
                    profilKullanici.AdresId = ddlAdresErisim.SelectedValue.ToString();
                    profilKullanici.CepTel = txtProfilCepTel.Value;
                    profilKullanici.CepTelId = ddlCepTelErisim.SelectedValue.ToString();
                    profilKullanici.EvTel = txtProfilEvTel.Value;
                    profilKullanici.EvTelId = ddlEvTelErisim.SelectedItem.Value.ToString();
                    profilKullanici.Web = txtProfilWeb.Value;
                    profilKullanici.WebId = ddlWebErisim.SelectedValue.ToString();
                    profilKullanici.Facebook = txtProfilFacebook.Value;
                    profilKullanici.FacebookId = ddlFacebookErisim.SelectedValue.ToString();
                    profilKullanici.Twitter = txtProfilTwitter.Value;
                    profilKullanici.TwitterId = ddlTwitterErisim.SelectedValue.ToString();
                    profilKullanici.Linkedin = txtProfilLinkedin.Value;
                    profilKullanici.linkedinId = ddlLinkedinErisim.SelectedValue.ToString();
                    profilKullanici.DogumYeri = ddlIller.SelectedItem.Value.ToString();
                    profilKullanici.DogumYeriId = ddlDogumYeriErisim.SelectedValue.ToString();


                    db.SubmitChanges();
                }
                else
                {
                    //insert
                    Profil_Bilgileri profil = new Profil_Bilgileri
                    {
                        Isım = txtProfilIsim.Value,
                        IsımId = ddlIsimErisim.SelectedValue.ToString(),
                        SoyIsım = txtProfilSoyisim.Value,
                        SoyIsımId = ddlSoyIsimErisim.SelectedValue.ToString(),
                        EMail = txtProfilEMail.Value,
                        EmailId = ddlEmailErisim.SelectedValue.ToString(),
                        OgrenciNo = txtProfilOgrenciNo.Value,
                        OgrenciNoId = ddlOgrenciNoErisim.SelectedValue.ToString(),
                        Adres = txtProfilAdres.Text,
                        AdresId = ddlAdresErisim.SelectedValue.ToString(),
                        CepTel = txtProfilCepTel.Value,
                        CepTelId = ddlCepTelErisim.SelectedValue.ToString(),
                        EvTel = txtProfilEvTel.Value,
                        EvTelId = ddlEvTelErisim.SelectedValue.ToString(),
                        Web = txtProfilWeb.Value,
                        WebId = ddlWebErisim.SelectedValue.ToString(),
                        Facebook = txtProfilFacebook.Value,
                        FacebookId = ddlFacebookErisim.SelectedValue.ToString(),
                        Twitter = txtProfilTwitter.Value,
                        TwitterId = ddlTwitterErisim.SelectedValue.ToString(),
                        Linkedin = txtProfilLinkedin.Value,
                        linkedinId = ddlLinkedinErisim.SelectedValue.ToString(),
                        DogumYeri = ddlIller.SelectedItem.Value.ToString(),
                        DogumYeriId = ddlDogumYeriErisim.SelectedValue.ToString()

                    };

                    Kullanıcı_Bilgileri kul = new Kullanıcı_Bilgileri
                    {
                        KullanıcıAdı = txtProfilEMail.Value,
                        Sifre = txtProfilSifre.Value,
                        OgrenciNo=txtProfilOgrenciNo.Value
                        
                    };
                    db.Kullanıcı_Bilgileri.InsertOnSubmit(kul);
                    db.Profil_Bilgileri.InsertOnSubmit(profil);
                    db.SubmitChanges();
                }
            }
        }
        protected void btnIsBilgileriKaydet_Click1(object sender, EventArgs e)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                if (!String.IsNullOrEmpty(txtProfilOgrenciNo.Value))
                {
                    var isbilgisi = (from k in db.Is_Bilgileri where k.IsOgrenciNo == txtProfilOgrenciNo.Value select k).FirstOrDefault();
                    if (isbilgisi == null)
                    {
                        //insert
                        Is_Bilgileri kullanici = new Is_Bilgileri
                        {
                            KurumAdi = txtKurumAdı.Value,
                            IErisimId = ddlErişim.SelectedItem.Value.ToString(),
                            SektorId = ddlSektor.SelectedItem.Value.ToString(),
                            PozisyonId = ddlPozisyon.SelectedItem.Value.ToString(),
                            KurumOlcegiId = ddlKurumOlcegi.SelectedItem.Value.ToString(),
                            Yıllar = ddlIsBilYıllar.SelectedItem.Value.ToString(),
                            IsOgrenciNo = txtProfilOgrenciNo.Value

                        };
                        db.Is_Bilgileri.InsertOnSubmit(kullanici);

                    }
                    else
                    {
                        //update
                        isbilgisi.KurumAdi = txtKurumAdı.Value;
                        isbilgisi.IErisimId = ddlErişim.SelectedItem.Value.ToString();
                        isbilgisi.SektorId = ddlSektor.SelectedItem.Value.ToString();
                        isbilgisi.PozisyonId = ddlPozisyon.SelectedItem.Value.ToString();
                        isbilgisi.KurumOlcegiId = ddlKurumOlcegi.SelectedItem.Value.ToString();
                        isbilgisi.Yıllar = ddlIsBilYıllar.SelectedItem.Value.ToString();
                        isbilgisi.IsOgrenciNo = txtProfilOgrenciNo.Value;

                    }
                    db.SubmitChanges();
                }
                else
                {
                    uyari3.Visible = true;
                }
            }
        }
        protected void btnCvYukle_Click1(object sender, EventArgs e)
        {

            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                if (!String.IsNullOrEmpty(txtProfilOgrenciNo.Value))
                {
                    var CVyukle = (from k in db.CV where k.CVOgrenciNo == txtProfilOgrenciNo.Value select k).FirstOrDefault();
                    if (CVyukle == null)
                    {
                        //insert
                        HttpPostedFile yuklenecekDosya = fluDosya.PostedFile;
                        if (yuklenecekDosya != null)
                        {
                            FileInfo dosyaBilgisi = new FileInfo(yuklenecekDosya.FileName);
                            string klasor = "Dosyalar";

                            string dosyaAdi = dosyaBilgisi.Name.Substring(0, dosyaBilgisi.Name.Length - dosyaBilgisi.Extension.Length);
                            dosyaAdi += "-" + Guid.NewGuid().ToString().Replace("-", "") + dosyaBilgisi.Extension;
                            string yuklemeYeri = Server.MapPath("~/" + klasor + "/" + dosyaAdi);
                            fluDosya.SaveAs(yuklemeYeri);

                            string kayitYeri = klasor + "/" + dosyaAdi;

                            CV yeniDosya = new CV()
                            {
                                CVOgrenciNo = txtProfilOgrenciNo.Value,
                                Konum = kayitYeri
                            };
                            db.CV.InsertOnSubmit(yeniDosya);
                            db.SubmitChanges();
                        }
                    }
                    else
                    {
                        //update
                        var CvBilgisi = (from k in db.CV where k.CVOgrenciNo == txtProfilOgrenciNo.Value select k).FirstOrDefault();
                        string dosyaeskiadi = Server.MapPath("~/" + CvBilgisi.Konum);
                        File.Delete(dosyaeskiadi);

                        FileInfo dosyaBilgisi = new FileInfo(fluDosya.FileName);
                        string klasor = "Dosyalar";
                        string dosyaAdi = dosyaBilgisi.Name.Substring(0, dosyaBilgisi.Name.Length - dosyaBilgisi.Extension.Length);
                        dosyaAdi += "-" + Guid.NewGuid().ToString().Replace("-", "") + dosyaBilgisi.Extension;
                        string yuklemeYeri = Server.MapPath("~/" + klasor + "/" + dosyaAdi);
                        fluDosya.SaveAs(yuklemeYeri);

                        string kayitYeri = klasor + "/" + dosyaAdi;
                        CvBilgisi.Konum = kayitYeri;

                        db.SubmitChanges();
                    }

                }
                else
                {
                    uyari4.Visible = true;
                }

            }
        }

    }

}