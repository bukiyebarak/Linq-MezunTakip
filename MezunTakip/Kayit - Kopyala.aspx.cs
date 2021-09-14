using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace MezunTakip
{
    public partial class Kayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                using (DataClassesDataContext db = new DataClassesDataContext())
                {
                    #region Erisim izni

                    var erisimlist = (from er in db.Erisim_Izni select er).ToList();

                    if (erisimlist != null)
                    {
                        #region Is Bilgileri Erisim

                        ddlErişim.DataSource = erisimlist;
                        ddlErişim.DataValueField = "Id";
                        ddlErişim.DataTextField = "ErisimDurumu";
                        ddlErişim.DataBind();

                        #endregion

                        #region Egitim Bilgileri Erisimler

                        ddlOLErisim.DataSource = erisimlist;
                        ddlOLErisim.DataValueField = "Id";
                        ddlOLErisim.DataTextField = "ErisimDurumu";
                        ddlOLErisim.DataBind();

                        ddlLErisim.DataSource = erisimlist;
                        ddlLErisim.DataValueField = "Id";
                        ddlLErisim.DataTextField = "ErisimDurumu";
                        ddlLErisim.DataBind();

                        ddlYLErisim.DataSource = erisimlist;
                        ddlYLErisim.DataValueField = "Id";
                        ddlYLErisim.DataTextField = "ErisimDurumu";
                        ddlYLErisim.DataBind();

                        ddlDErisim.DataSource = erisimlist;
                        ddlDErisim.DataValueField = "Id";
                        ddlDErisim.DataTextField = "ErisimDurumu";
                        ddlDErisim.DataBind();

                        ddlTUErisim.DataSource = erisimlist;
                        ddlTUErisim.DataValueField = "Id";
                        ddlTUErisim.DataTextField = "ErisimDurumu";
                        ddlTUErisim.DataBind();
                        #endregion

                        #region Profil Bilgileri

                        ddlResimErisim.DataSource = erisimlist;
                        ddlResimErisim.DataValueField = "Id";
                        ddlResimErisim.DataTextField = "ErisimDurumu";
                        ddlResimErisim.DataBind();

                        ddlIsimErisim.DataSource = erisimlist;
                        ddlIsimErisim.DataValueField = "Id";
                        ddlIsimErisim.DataTextField = "ErisimDurumu";
                        ddlIsimErisim.DataBind();

                        ddlSoyIsimErisim.DataSource = erisimlist;
                        ddlSoyIsimErisim.DataValueField = "Id";
                        ddlSoyIsimErisim.DataTextField = "ErisimDurumu";
                        ddlSoyIsimErisim.DataBind();

                        ddlOgrenciNoErisim.DataSource = erisimlist;
                        ddlOgrenciNoErisim.DataValueField = "Id";
                        ddlOgrenciNoErisim.DataTextField = "ErisimDurumu";
                        ddlOgrenciNoErisim.DataBind();

                        ddlEmailErisim.DataSource = erisimlist;
                        ddlEmailErisim.DataValueField = "Id";
                        ddlEmailErisim.DataTextField = "ErisimDurumu";
                        ddlEmailErisim.DataBind();

                        ddlDogumYeriErisim.DataSource = erisimlist;
                        ddlDogumYeriErisim.DataValueField = "Id";
                        ddlDogumYeriErisim.DataTextField = "ErisimDurumu";
                        ddlDogumYeriErisim.DataBind();

                        ddlAdresErisim.DataSource = erisimlist;
                        ddlAdresErisim.DataValueField = "Id";
                        ddlAdresErisim.DataTextField = "ErisimDurumu";
                        ddlAdresErisim.DataBind();

                        ddlCepTelErisim.DataSource = erisimlist;
                        ddlCepTelErisim.DataValueField = "Id";
                        ddlCepTelErisim.DataTextField = "ErisimDurumu";
                        ddlCepTelErisim.DataBind();

                        ddlEvTelErisim.DataSource = erisimlist;
                        ddlEvTelErisim.DataValueField = "Id";
                        ddlEvTelErisim.DataTextField = "ErisimDurumu";
                        ddlEvTelErisim.DataBind();

                        ddlWebErisim.DataSource = erisimlist;
                        ddlWebErisim.DataValueField = "Id";
                        ddlWebErisim.DataTextField = "ErisimDurumu";
                        ddlWebErisim.DataBind();

                        ddlFacebookErisim.DataSource = erisimlist;
                        ddlFacebookErisim.DataValueField = "Id";
                        ddlFacebookErisim.DataTextField = "ErisimDurumu";
                        ddlFacebookErisim.DataBind();

                        ddlTwitterErisim.DataSource = erisimlist;
                        ddlTwitterErisim.DataValueField = "Id";
                        ddlTwitterErisim.DataTextField = "ErisimDurumu";
                        ddlTwitterErisim.DataBind();

                        ddlLinkedinErisim.DataSource = erisimlist;
                        ddlLinkedinErisim.DataValueField = "Id";
                        ddlLinkedinErisim.DataTextField = "ErisimDurumu";
                        ddlLinkedinErisim.DataBind();

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
                }
            }
        }

        protected void btnEgitimKaydet_Click(object sender, EventArgs e)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
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
                    TUAnabilim = txtTUAnabilim.Value
                };

                db.Egitim_Bilgileri.InsertOnSubmit(kullaniciEgitim);
                db.SubmitChanges();
            }
        }

        protected void btnTavsiyeGonder_Click(object sender, EventArgs e)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var profilkullanici = (from o_number in db.Profil_Bilgileri where o_number.OgrenciNo == "1" select o_number).FirstOrDefault();

                if (profilkullanici != null)
                {
                    //update
                    Tavsiyeler tavsiyem = (from tav in db.Tavsiyeler where tav.TavsiyeOgrenciNo == profilkullanici.OgrenciNo select tav).FirstOrDefault();
                    tavsiyem.Yorum = txtYorumlar.Text;
                    db.SubmitChanges();
                }
                else
                { //insert
                    Tavsiyeler tavsiye = new Tavsiyeler
                    {
                        TavsiyeOgrenciNo = "1",
                        Yorum = txtYorumlar.Text
                    };

                    db.Tavsiyeler.InsertOnSubmit(tavsiye);
                    db.SubmitChanges();
                }

            }
        }
        protected void btnProfilKaydet_Click(object sender, EventArgs e)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var kullanici = (from o_number in db.Profil_Bilgileri where o_number.OgrenciNo == "1" select o_number).FirstOrDefault();
                if (kullanici != null)
                {
                    //update
                    // tavsiyem = (from tav in db.Tavsiyeler where tav.OgrenciNumarası == profilkullanici.OgrenciNo select tav).FirstOrDefault();
                    //tavsiyem.Yorum = txtYorumlar.Text;
                    //db.SubmitChanges();
                }
                else
                {
                    //insert
                    Profil_Bilgileri profil = new Profil_Bilgileri
                    {
                        Isım = txtProfilIsim.Value,
                        IsımId = ddlIsimErisim.SelectedItem.Value.ToString(),
                        SoyIsım = txtProfilSoyisim.Value,
                        SoyIsımId = ddlSoyIsimErisim.SelectedItem.Value.ToString(),
                        EMail = txtProfilEMail.Value,
                        EmailId = ddlEmailErisim.SelectedItem.Value.ToString(),
                        OgrenciNo = txtProfilOgrenciNo.Value,
                        OgrenciNoId = ddlOgrenciNoErisim.SelectedItem.Value.ToString(),
                        Adres = txtProfilAdres.Text,
                        AdresId = ddlAdresErisim.SelectedItem.Value.ToString(),
                        CepTel = txtProfilCepTel.Value,
                        CepTelId = ddlCepTelErisim.SelectedItem.Value.ToString(),
                        EvTel = txtProfilEvTel.Value,
                        EvTelId = ddlEvTelErisim.SelectedItem.Value.ToString(),
                        Web = txtProfilWeb.Value,
                        WebId = ddlWebErisim.SelectedItem.Value.ToString(),
                        Facebook = txtProfilFacebook.Value,
                        FacebookId = ddlFacebookErisim.SelectedItem.Value.ToString(),
                        Twitter = txtProfilTwitter.Value,
                        TwitterId = ddlTwitterErisim.SelectedItem.Value.ToString(),
                        Linkedin = txtProfilLinkedin.Value,
                        linkedinId = ddlLinkedinErisim.SelectedItem.Value.ToString(),
                        DogumYeri = ddlIller.SelectedItem.Value.ToString(),
                        DogumYeriId = ddlDogumYeriErisim.SelectedItem.Value.ToString()

                    };
                    db.Profil_Bilgileri.InsertOnSubmit(profil);
                    db.SubmitChanges();
                }
            }
        }
        protected void btnIsBilgileriKaydet_Click1(object sender, EventArgs e)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                //insert
                Is_Bilgileri kullanici = new Is_Bilgileri
                {
                    KurumAdi = txtKurumAdı.Value,
                    IErisimId = ddlErişim.SelectedItem.Value.ToString(),
                    SektorId = ddlSektor.SelectedItem.Value.ToString(),
                    PozisyonId = ddlPozisyon.SelectedItem.Value.ToString(),
                    KurumOlcegiId = ddlKurumOlcegi.SelectedItem.Value.ToString(),
                    Yıllar = ddlIsBilYıllar.SelectedItem.Value.ToString()

                };
                db.Is_Bilgileri.InsertOnSubmit(kullanici);
                db.SubmitChanges();

            }
        }
        protected void btnCvYukle_Click1(object sender, EventArgs e)
        {

            using (DataClassesDataContext db = new DataClassesDataContext())
            {
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
                        CVOgrenciNo = "1",
                        Konum = kayitYeri
                    };
                    db.CV.InsertOnSubmit(yeniDosya);
                    db.SubmitChanges();
                }

            }
        }

    }
}
