using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class S�klar: MonoBehaviour
{
    public GameObject nesne;
    public kolay_soru_manager h;
    public GameObject az;
    public GameObject bz;
    public GameObject cz;
    public GameObject dz;
    public GameObject kolay;
    public GameObject orta;
    public GameObject zor;
    public GameObject ipucu_balonu;
    public TMP_Text ipucu_metni;

    

    public void a_tus()
    {
        ipucu_balonu.SetActive(false);
        if (az.activeInHierarchy)
        {
            if (kolay.activeInHierarchy) { h.kolay_secici(); }
            else if (orta.activeInHierarchy) { h.orta_secici(); }
            else if (zor.activeInHierarchy) { h.zor_secici(); }
        }

    }
    
    public void b_tus() {
        ipucu_balonu.SetActive(false);
        if (bz.activeInHierarchy)
        {
            if (kolay.activeInHierarchy) { h.kolay_secici(); }
            else if (orta.activeInHierarchy) { h.orta_secici(); }
            else if (zor.activeInHierarchy) { h.zor_secici(); }
        }
     }
    public void c_tus() { if (cz.activeInHierarchy)
        {
            ipucu_balonu.SetActive(false);
            if (kolay.activeInHierarchy) { h.kolay_secici(); }
            else if (orta.activeInHierarchy) { h.orta_secici(); }
            else if (zor.activeInHierarchy) { h.zor_secici(); }
        }
    }
    public void d_tus() { if (dz.activeInHierarchy)
        {
            ipucu_balonu.SetActive(false);
            if (kolay.activeInHierarchy) { h.kolay_secici(); }
            else if (orta.activeInHierarchy) { h.orta_secici(); }
            else if (zor.activeInHierarchy) { h.zor_secici(); }
        } 
    }
    
    public void menu_tus() { SceneManager.LoadScene(0); }

    public void ipucu_kare() { ipucu_balonu.SetActive(true); ipucu_metni.text = "kare �evresi form�l�: X * 4"; }
    public void ipucu_dikdortgen(){ipucu_balonu.SetActive(true); ipucu_metni.text = "dikd�rtgen �evresi form�l�: X * 2 + Y * 2";}
    public void ipucu_cizgi() { ipucu_balonu.SetActive(true); ipucu_metni.text = "�izgi �evresi form�l�: X * 2 + 2"; }
    public void ipucu_dik_ucgen() { ipucu_balonu.SetActive(true); ipucu_metni.text = "hipoten�s form�l�: x� * y� = z�"; }
    public void ipucu_yuvarlak() { ipucu_balonu.SetActive(true); ipucu_metni.text = "�ember �evresi form�l�: pi * r�"; }
    


  
}
