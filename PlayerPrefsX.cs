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


        #region Ba�lang��  ( UZUN HAL� )
        /* 
         
        PlayerPrefs.SetInt("ParaDegeri", 89); // �uan sisteme  ParaDegeri anahtar�na sahip olan ve  t�r� int olan bir de�er tan�mlad�m ve 89 degerini vermi� oldum.

         Bunu yapt�ktan sonra yeni bir de�er tan�ml�caksak  benim bunu sisteme kaydetmem gerekir. Yani ��yle :

        PlayerPrefs.Save();

         �imdi kaydettik KAYDETT�KTEN SONRADA EKLEMES�N� istiyorum.Yani ��yle :

        text1.text = PlayerPrefs.GetInt("ParaDegeri").ToString();

      �NEML� : �imdi PlayerPrefs.Save() Kodunu YORUM SATIRI HAL�NE GET�RSEN B�LE  S�STEM�N �NBELLE��NE KAYDOLDU�U ���N 89 yaz�s� Y�NE OYUN BA�LADI�INDA G�Z�KECEKT�R ! ! 

            */
        #endregion


        #region Ba�lang�� ( KISA HAL� )

        /* 

         PlayerPrefs.SetInt("ParaDegeri", 89);
         PlayerPrefs.SetFloat("Saglik", 55);
         PlayerPrefs.SetString("Ad", "Mika Desen");

          PlayerPrefs.Save();  


         // Debug.Log(PlayerPrefs.GetInt("ParaDegeri").ToString());

         PlayerPrefs.SetString("Ad", "Mikas Seker");
         PlayerPrefs.SetString("Ad", PlayerPrefs.GetString("Ad")+"Kaz�m Aktepe");  // Mevcut de�erin yan�na bir de�er ekledi.



          Debug.Log(PlayerPrefs.GetString("Ad")); // Ad De�eri G�NCELLEND� ! ! !
          text2.text = PlayerPrefs.GetString("Ad");

         PlayerPrefs.SetInt("ParaDegeri", PlayerPrefs.GetInt("ParaDegeri") + 10);

         PlayerPrefs.Save();

         */

        #endregion


        #region 2'inci KISIM

        /*
        if (PlayerPrefs.HasKey("Saglik")) // HasKey() : Anahtar var m� yok mu onun kontrol�n� yapar�z.
        {
            Debug.Log("Evet Saglik anahtar� sistemde VAR ! ! ! ");
        }
        else
            Debug.Log("Saglik anahtar� sistemde  YOK ! ");

        

        // PlayerPrefs.DeleteKey("Ad"); // Belirtmi� oldu�umuz anahtar� S�LER ! ! !

         PlayerPrefs.SetInt("YasDegeri", 25);
         PlayerPrefs.SetFloat("Saglik", 35);
         PlayerPrefs.SetString("Ad", "Mika");


        // PlayerPrefs.DeleteAll(); // B�t�n anahtari S�LER ! ! !

        text1.text = PlayerPrefs.GetInt("YasDegeri").ToString(); 
        text3.text = PlayerPrefs.GetFloat("Saglik").ToString();
        text2.text = PlayerPrefs.GetString("Ad");

        //  PlayerPrefs.Equals("ParaDegeri", "Saglik"); // A�a��daki kodla ayn� i�levi g�r�r.
         Equals("ParaDegeri","Saglik"); // 2 tane ANAHTAR birbirinin ayn�s� m� kontrol eder. 

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

    public void AnlikDegerGuncellemesi(float deger) // Unity taraf�nda Slider Inpectoru => Dynamic float 'dan AnlikDegerGuncellemesi'ni  SE�  ! ! !
    {
        PlayerPrefs.SetFloat("Saglik", deger);
        VerileriGuncelle();

    }
}
