using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsX : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;

    public InputField eleman1;
    public InputField eleman2;
    public InputField eleman3;

    public Slider slider;

    void Start()
    {


        #region Baþlangýç  ( UZUN HALÝ )
        /* 
         
        PlayerPrefs.SetInt("ParaDegeri", 89); // Þuan sisteme  ParaDegeri anahtarýna sahip olan ve  türü int olan bir deðer tanýmladým ve 89 degerini vermiþ oldum.

         Bunu yaptýktan sonra yeni bir deðer tanýmlýcaksak  benim bunu sisteme kaydetmem gerekir. Yani Þöyle :

        PlayerPrefs.Save();

         Þimdi kaydettik KAYDETTÝKTEN SONRADA EKLEMESÝNÝ istiyorum.Yani Þöyle :

        text1.text = PlayerPrefs.GetInt("ParaDegeri").ToString();

      ÖNEMLÝ : Þimdi PlayerPrefs.Save() Kodunu YORUM SATIRI HALÝNE GETÝRSEN BÝLE  SÝSTEMÝN ÖNBELLEÐÝNE KAYDOLDUÐU ÝÇÝN 89 yazýsý YÝNE OYUN BAÞLADIÐINDA GÖZÜKECEKTÝR ! ! 

            */
        #endregion


        #region Baþlangýç ( KISA HALÝ )

        /* 

         PlayerPrefs.SetInt("ParaDegeri", 89);
         PlayerPrefs.SetFloat("Saglik", 55);
         PlayerPrefs.SetString("Ad", "Mika Desen");

          PlayerPrefs.Save();  


         // Debug.Log(PlayerPrefs.GetInt("ParaDegeri").ToString());

         PlayerPrefs.SetString("Ad", "Mikas Seker");
         PlayerPrefs.SetString("Ad", PlayerPrefs.GetString("Ad")+"Kazým Aktepe");  // Mevcut deðerin yanýna bir deðer ekledi.



          Debug.Log(PlayerPrefs.GetString("Ad")); // Ad Deðeri GÜNCELLENDÝ ! ! !
          text2.text = PlayerPrefs.GetString("Ad");

         PlayerPrefs.SetInt("ParaDegeri", PlayerPrefs.GetInt("ParaDegeri") + 10);

         PlayerPrefs.Save();

         */

        #endregion


        #region 2'inci KISIM

        /*
        if (PlayerPrefs.HasKey("Saglik")) // HasKey() : Anahtar var mý yok mu onun kontrolünü yaparýz.
        {
            Debug.Log("Evet Saglik anahtarý sistemde VAR ! ! ! ");
        }
        else
            Debug.Log("Saglik anahtarý sistemde  YOK ! ");

        

        // PlayerPrefs.DeleteKey("Ad"); // Belirtmiþ olduðumuz anahtarý SÝLER ! ! !

         PlayerPrefs.SetInt("YasDegeri", 25);
         PlayerPrefs.SetFloat("Saglik", 35);
         PlayerPrefs.SetString("Ad", "Mika");


        // PlayerPrefs.DeleteAll(); // Bütün anahtari SÝLER ! ! !

        text1.text = PlayerPrefs.GetInt("YasDegeri").ToString(); 
        text3.text = PlayerPrefs.GetFloat("Saglik").ToString();
        text2.text = PlayerPrefs.GetString("Ad");

        //  PlayerPrefs.Equals("ParaDegeri", "Saglik"); // Aþaðýdaki kodla ayný iþlevi görür.
         Equals("ParaDegeri","Saglik"); // 2 tane ANAHTAR birbirinin aynýsý mý kontrol eder. 

        PlayerPrefs.Save();
        */



        #endregion

        /*
        PlayerPrefs.SetInt("YasDegeri", 25);
        PlayerPrefs.SetFloat("Saglik", 35);
        PlayerPrefs.SetString("Ad", "Mika");
      */

        text1.text = PlayerPrefs.GetInt("YasDegeri").ToString();
        text3.text = PlayerPrefs.GetFloat("Saglik").ToString();
        text2.text = PlayerPrefs.GetString("Ad");

        slider.value = PlayerPrefs.GetFloat("Saglik");
        PlayerPrefs.Save();
    }

    public void VerileriGoster()
    {
        PlayerPrefs.SetInt("YasDegeri", 25);
        PlayerPrefs.SetFloat("Saglik", 35);
        PlayerPrefs.SetString("Ad", "Mika");
        PlayerPrefs.Save();
        VerileriGuncelle();
    }
    void VerileriGuncelle()
    {
        text1.text = PlayerPrefs.GetInt("YasDegeri").ToString();
        text3.text = PlayerPrefs.GetFloat("Saglik").ToString();
        text2.text = PlayerPrefs.GetString("Ad");
    }

    public void YeniVerileriKaydet()
    {


        if(eleman1.text!="")
        PlayerPrefs.SetInt("ParaDegeri",int.Parse(eleman1.text));

        if(eleman2.text!="")
        PlayerPrefs.SetString("Ad", eleman2.text);

        if(eleman3.text!="")
        PlayerPrefs.SetFloat("Saglik", float.Parse(eleman3.text));
        PlayerPrefs.Save();

        VerileriGuncelle();
       
    }
    public void HepsiniSil()
    {
        PlayerPrefs.DeleteAll();
        VerileriGuncelle();
    }

    public void AnlikDegerGuncellemesi(float deger) // Unity tarafýnda Slider Inpectoru => Dynamic float 'dan AnlikDegerGuncellemesi'ni  SEÇ  ! ! !
    {
        PlayerPrefs.SetFloat("Saglik", deger);
        VerileriGuncelle();

    }
}
