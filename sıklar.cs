using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Sýklar: MonoBehaviour
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

    public void ipucu_kare() { ipucu_balonu.SetActive(true); ipucu_metni.text = "kare çevresi formülü: X * 4"; }
    public void ipucu_dikdortgen(){ipucu_balonu.SetActive(true); ipucu_metni.text = "dikdörtgen çevresi formülü: X * 2 + Y * 2";}
    public void ipucu_cizgi() { ipucu_balonu.SetActive(true); ipucu_metni.text = "çizgi çevresi formülü: X * 2 + 2"; }
    public void ipucu_dik_ucgen() { ipucu_balonu.SetActive(true); ipucu_metni.text = "hipotenüs formülü: x² * y² = z²"; }
    public void ipucu_yuvarlak() { ipucu_balonu.SetActive(true); ipucu_metni.text = "çember çevresi formülü: pi * r²"; }
    


  
}
