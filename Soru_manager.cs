using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Soru_Manager: MonoBehaviour
{
    public GameObject kare;
    public GameObject ickare;
    public GameObject dikdortgen;
    public GameObject icdikdortgen;
    public GameObject ip_ucukare;
    public GameObject ip_ucudikdortgen;
    public GameObject soru;
    public GameObject kolay_btn;
    public GameObject zor_btn;
    public GameObject cember;
    public TMP_Text kolay_soru_metni;
    public TMP_Text a;
    public TMP_Text b;
    public TMP_Text c;
    public TMP_Text d;
    public GameObject nesne;
    public GameObject az;
    public GameObject bz;
    public GameObject cz;
    public GameObject dz;
    public GameObject cizgi;
    public GameObject c_ucgen;
    public GameObject dik_ucgen;
    public GameObject yuvarlak;
    public GameObject icc_ucgen;
    public GameObject icyuvarlak;
    public GameObject ipucu_cizgi;
    public GameObject ipucu_ucgen;
    public GameObject ipucu_ducgen;
    public GameObject ipucu_yuvarlak;
    public GameObject cember2;
    public GameObject kolay;
    public GameObject orta;
    public GameObject zor;
    public GameObject ucgendeki_x;
    public GameObject ucgendeki_y;
    public GameObject ucgendeki_z;
    public GameObject ucgendeki_ikiz_y;
    public GameObject ucgendeki_x1;
    public GameObject ucgendeki_x2;
    public GameObject ipucu_balonu;

    Animator animasyon;

    public GameObject orta_btn;
    void Start()
    {
        animasyon = gameObject.GetComponent<Animator>();
      
    }

    public void dogru() {  }

    
    public void kolay_secici()
    {
        ipucu_balonu.SetActive(false);
        int d_sýk = Random.Range(0, 4);

        kolay.SetActive(true);
        orta.SetActive(false);
        zor.SetActive(false);
        dikdortgen.SetActive(false);
        icdikdortgen.SetActive(false);
        ickare.SetActive(false);
        kare.SetActive(false);
        cember.SetActive(false);
        
        soru.SetActive(false);
        if (Random.Range(0, 2) == 0)
        {
            
            kare.SetActive(true);
           ickare.SetActive(true);
            
            ip_ucukare.SetActive(true);
            ip_ucudikdortgen.SetActive(false);
            ipucu_cizgi.SetActive(false);
            ipucu_ducgen.SetActive(false);
            
            ipucu_ucgen.SetActive(false);
            ipucu_yuvarlak.SetActive(false);

            int x = Random.Range(1, 10);
            kolay_soru_metni.text = "X = " + x + " ise birim cember kare etrafýnda tam tur attýðýnda ne kadar yol almýþ olur";
            x++;
            x *= 4;
            int cevap = x;
            
            if (d_sýk == 0)
            {
                az.SetActive(true);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(false);
                a.text = ""+cevap+"";
                int bb; do { bb = Random.Range(10, 50); } while (bb == cevap); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == bb); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 1) {
                az.SetActive(false);
                bz.SetActive(true);
                cz.SetActive(false);
                dz.SetActive(false);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb = Random.Range(10, 50);
                b.text = "" + cevap + ""; 
                int cc; do { cc = Random.Range(10, 50); } while (cc == aa); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 2)
            {
                az.SetActive(false);
                bz.SetActive(false);
                cz.SetActive(true);
                dz.SetActive(false);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == aa); b.text = "" + bb + "";
                int cc = Random.Range(10, 50);
                c.text = "" + cevap + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == bb); d.text = "" + dd + "";

            }
            if (d_sýk == 3)
            {
                az.SetActive(false);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(true);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == aa); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == bb); c.text = "" + cc + "";
                int dd = Random.Range(10, 50);
                d.text = "" + cevap + "";
               
            }

             



        }
        else
        {

           
            dikdortgen.SetActive(true);
            icdikdortgen.SetActive(true );
            
            ip_ucukare.SetActive(false);
            ip_ucudikdortgen.SetActive(true);
            ipucu_cizgi.SetActive(false);
            ipucu_ducgen.SetActive(false);
            
            ipucu_ucgen.SetActive(false);
            ipucu_yuvarlak.SetActive(false);

            int z;
            int x = Random.Range(15, 30);
            int y = Random.Range(5, 14);
            kolay_soru_metni.text = "X = " + x + " ve Y = " +y+ " ise birim cember dikdortgen etrafýnda tam tur attýðýnda ne kadar yol almýþ olur";
            x++;
            y++;
            y *= 2;
            x *= 2;
            z = x + y;
            int cevap = z;

            if (d_sýk == 0)
            {
                az.SetActive(true);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(false);
                a.text = "" + cevap + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == cevap); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == bb); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 1)
            {
                az.SetActive(false);
                bz.SetActive(true);
                cz.SetActive(false);
                dz.SetActive(false);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb = Random.Range(10, 50);
                b.text = "" + cevap + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == aa); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 2)
            {
                az.SetActive(false);
                bz.SetActive(false);
                cz.SetActive(true);
                dz.SetActive(false);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == aa); b.text = "" + bb + "";
                int cc = Random.Range(10, 50);
                c.text = "" + cevap + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == bb); d.text = "" + dd + "";

            }
            if (d_sýk == 3)
            {
                az.SetActive(false);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(true);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == aa); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == bb); c.text = "" + cc + "";
                int dd = Random.Range(10, 50);
                d.text = "" + cevap + "";

            }



        }
        cember.SetActive(true);
        
        soru.SetActive(true);
        kolay_btn.SetActive(false);
        orta_btn.SetActive(false);
        zor_btn.SetActive(false);
         
        
    }

    public void orta_secici()
    {
        ipucu_balonu.SetActive(false);
        int ucgen_tur = Random.Range(0, 3);

        int d_sýk = Random.Range(0, 4);
        kolay.SetActive(false);
        orta.SetActive(true);
        zor.SetActive(false);

        cizgi.SetActive(false);
        
        icc_ucgen.SetActive(false);
        c_ucgen.SetActive(false);
        cember2.SetActive(false);

        soru.SetActive(false);
        if (Random.Range(0, 2) == 0)
        {

            cizgi.SetActive(true);
            cember2.SetActive(true);
            cember.SetActive(false);

            ipucu_cizgi.SetActive(true);
            ipucu_ducgen.SetActive(false);
           
            ipucu_ucgen.SetActive(false);
            ipucu_yuvarlak.SetActive(false);
            ip_ucukare.SetActive(false);
            ip_ucudikdortgen.SetActive(false);

            int x = Random.Range(10, 30);
            kolay_soru_metni.text = "X = " + x + " ise birim cember çizgi etrafýnda tam tur attýðýnda ne kadar yol almýþ olur";

            x *= 2;
            int cevap = x + 2;

            if (d_sýk == 0)
            {
                az.SetActive(true);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(false);
                a.text = "" + cevap + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == cevap); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == bb); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 0)
            {
                az.SetActive(true);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(false);
                a.text = "" + cevap + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == cevap); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == bb); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 1)
            {
                az.SetActive(false);
                bz.SetActive(true);
                cz.SetActive(false);
                dz.SetActive(false);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb = Random.Range(10, 50);
                b.text = "" + cevap + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == aa); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 2)
            {
                az.SetActive(false);
                bz.SetActive(false);
                cz.SetActive(true);
                dz.SetActive(false);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == aa); b.text = "" + bb + "";
                int cc = Random.Range(10, 50);
                c.text = "" + cevap + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == bb); d.text = "" + dd + "";

            }
            if (d_sýk == 3)
            {
                az.SetActive(false);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(true);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == aa); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == bb); c.text = "" + cc + "";
                int dd = Random.Range(10, 50);
                d.text = "" + cevap + "";

            }

        
        }
        else if(ucgen_tur == 0)
        {
            //çeþit kenar üçgen

            
            c_ucgen.SetActive(true);
            icc_ucgen.SetActive(true);
            cember2.SetActive(false);
            cember.SetActive(true);
            ucgendeki_x.SetActive(true);
            ucgendeki_y.SetActive(true);
            ucgendeki_z.SetActive(true);
            ucgendeki_ikiz_y.SetActive(false);
            ucgendeki_x2.SetActive(false);
            ucgendeki_x1.SetActive(false);

            ipucu_cizgi.SetActive(false);
            ipucu_ducgen.SetActive(false);
           
            ipucu_ucgen.SetActive(true);
            ipucu_yuvarlak.SetActive(false);
            ip_ucukare.SetActive(false);
            ip_ucudikdortgen.SetActive(false);


            int z = Random.Range(5, 20);
            int x = Random.Range(5, 20);
            int y = Random.Range(5, 20);
            kolay_soru_metni.text = "X = " + x + " , Y = " + y + " ve Z = " + z + " ise birim cember çeþit kenar üçgen etrafýnda tam tur attýðýnda ne kadar yol almýþ olur";
            x++;
            y++;
            z++;
            int cevap = z+x+y;

            if (d_sýk == 0)
            {
                az.SetActive(true);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(false);
                a.text = "" + cevap + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == cevap); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == bb); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 1)
            {
                az.SetActive(false);
                bz.SetActive(true);
                cz.SetActive(false);
                dz.SetActive(false);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb = Random.Range(10, 50);
                b.text = "" + cevap + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == aa); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 2)
            {
                az.SetActive(false);
                bz.SetActive(false);
                cz.SetActive(true);
                dz.SetActive(false);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == aa); b.text = "" + bb + "";
                int cc = Random.Range(10, 50);
                c.text = "" + cevap + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == bb); d.text = "" + dd + "";

            }
            if (d_sýk == 3)
            {
                az.SetActive(false);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(true);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == aa); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == bb); c.text = "" + cc + "";
                int dd = Random.Range(10, 50);
                d.text = "" + cevap + "";

            }



        } else if(ucgen_tur == 1) {
            //ikiz kenar üçgen

            c_ucgen.SetActive(true);
            icc_ucgen.SetActive(true);
            cember2.SetActive(false);
            cember.SetActive(true);
            
            ucgendeki_x2.SetActive(false);
            ucgendeki_x1.SetActive(false);
            ucgendeki_x.SetActive(true);
            ucgendeki_y.SetActive(true);
            ucgendeki_z.SetActive(false);
            ucgendeki_ikiz_y.SetActive(true);

            ipucu_cizgi.SetActive(false);
            ipucu_ducgen.SetActive(false);
           
            ipucu_ucgen.SetActive(true);
            ipucu_yuvarlak.SetActive(false);
            ip_ucukare.SetActive(false);
            ip_ucudikdortgen.SetActive(false);


            
            int x = Random.Range(5, 20);
            int y = Random.Range(5, 20);
            kolay_soru_metni.text = "X = " + x + " ve Y = " + y  + " ise birim cember ikiz kenar üçgen etrafýnda tam tur attýðýnda ne kadar yol almýþ olur";
            x++;
            y++;
            
            int cevap = x + y*2;

            if (d_sýk == 0)
            {
                az.SetActive(true);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(false);
                a.text = "" + cevap + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == cevap); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == bb); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 1)
            {
                az.SetActive(false);
                bz.SetActive(true);
                cz.SetActive(false);
                dz.SetActive(false);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb = Random.Range(10, 50);
                b.text = "" + cevap + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == aa); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 2)
            {
                az.SetActive(false);
                bz.SetActive(false);
                cz.SetActive(true);
                dz.SetActive(false);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == aa); b.text = "" + bb + "";
                int cc = Random.Range(10, 50);
                c.text = "" + cevap + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == bb); d.text = "" + dd + "";

            }
            if (d_sýk == 3)
            {
                az.SetActive(false);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(true);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == aa); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == bb); c.text = "" + cc + "";
                int dd = Random.Range(10, 50);
                d.text = "" + cevap + "";

            }
        } else
        {
            //eþkenar üçgen

            c_ucgen.SetActive(true);
            icc_ucgen.SetActive(true);
            cember2.SetActive(false);
            cember.SetActive(true);
            ucgendeki_x2.SetActive(true);
            ucgendeki_x1.SetActive(true);
            ucgendeki_x.SetActive(true);
            ucgendeki_y.SetActive(false);
            ucgendeki_z.SetActive(false);
            ucgendeki_ikiz_y.SetActive(false);

            ipucu_cizgi.SetActive(false);
            ipucu_ducgen.SetActive(false);
            
            ipucu_ucgen.SetActive(true);
            ipucu_yuvarlak.SetActive(false);
            ip_ucukare.SetActive(false);
            ip_ucudikdortgen.SetActive(false);


            
            int x = Random.Range(5, 20);
            
            kolay_soru_metni.text = "X = " + x +" ise birim cember eþkenar üçgen etrafýnda tam tur attýðýnda ne kadar yol almýþ olur";
            x++;
            
            int cevap = x*3;

            if (d_sýk == 0)
            {
                az.SetActive(true);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(false);
                a.text = "" + cevap + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == cevap); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == bb); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 1)
            {
                az.SetActive(false);
                bz.SetActive(true);
                cz.SetActive(false);
                dz.SetActive(false);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb = Random.Range(10, 50);
                b.text = "" + cevap + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == aa); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 2)
            {
                az.SetActive(false);
                bz.SetActive(false);
                cz.SetActive(true);
                dz.SetActive(false);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == aa); b.text = "" + bb + "";
                int cc = Random.Range(10, 50);
                c.text = "" + cevap + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == bb); d.text = "" + dd + "";

            }
            if (d_sýk == 3)
            {
                az.SetActive(false);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(true);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == aa); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == bb); c.text = "" + cc + "";
                int dd = Random.Range(10, 50);
                d.text = "" + cevap + "";

            }
        }
        

        soru.SetActive(true);
        kolay_btn.SetActive(false);
        orta_btn.SetActive(false);
        zor_btn.SetActive(false);


    }

    public void zor_secici() {

        ipucu_balonu.SetActive(false);
        kolay.SetActive(false);
        orta.SetActive(false);
        zor.SetActive(true);

        int d_sýk = Random.Range(0, 4);

        dik_ucgen.SetActive(false);

       
       
        cember2.SetActive(false);

        soru.SetActive(false);
        if (Random.Range(0,2)==0)
        {

            dik_ucgen.SetActive(true);
            cember2.SetActive(true);
            cember.SetActive(false);
            yuvarlak.SetActive(false);
            

            ipucu_cizgi.SetActive(false);
            ipucu_ducgen.SetActive(true);
           
            ipucu_ucgen.SetActive(false);
            ipucu_yuvarlak.SetActive(false);
            ip_ucukare.SetActive(false);
            ip_ucudikdortgen.SetActive(false);

            int k = Random.Range(1, 5);
            



            int y = 3*k;
            int x = 4*k;
            kolay_soru_metni.text = "X = " + x + " Y = "+y+ " ise birim cember dik üçgen etrafýnda tam tur attýðýnda ne kadar yol almýþ olur";

            
            
            int z = 5*k;

            int cevap = x+y+z+3;

            if (d_sýk == 0)
            {
                az.SetActive(true);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(false);
                a.text = "" + cevap + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == cevap); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == bb); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 1)
            {
                az.SetActive(false);
                bz.SetActive(true);
                cz.SetActive(false);
                dz.SetActive(false);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb = Random.Range(10, 50);
                b.text = "" + cevap + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == aa); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 2)
            {
                az.SetActive(false);
                bz.SetActive(false);
                cz.SetActive(true);
                dz.SetActive(false);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == aa); b.text = "" + bb + "";
                int cc = Random.Range(10, 50);
                c.text = "" + cevap + "";
                int dd; do { dd = Random.Range(10, 50); } while (dd == bb); d.text = "" + dd + "";

            }
            if (d_sýk == 3)
            {
                az.SetActive(false);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(true);
                int aa; do { aa = Random.Range(10, 50); } while (aa == cevap); a.text = "" + aa + "";
                int bb; do { bb = Random.Range(10, 50); } while (bb == aa); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(10, 50); } while (cc == bb); c.text = "" + cc + "";
                int dd = Random.Range(10, 50);
                d.text = "" + cevap + "";

            }
        }
        else
        {


            yuvarlak.SetActive(true);
            icyuvarlak.SetActive(true);
            cember2.SetActive(false);
            cember.SetActive(true);

            ipucu_cizgi.SetActive(false);
            ipucu_ducgen.SetActive(false);
            
            ipucu_ucgen.SetActive(false);
            ipucu_yuvarlak.SetActive(true);
            ip_ucukare.SetActive(false);
            ip_ucudikdortgen.SetActive(false);


            
            int x = Random.Range(1, 5);
            
            kolay_soru_metni.text = "r = " + x +" ise birim cember yarý çapý r olan büyük çember etrafýnda tam tur attýðýnda ne kadar yol almýþ olur (pi=3)";
            x++;
            x = x * x;
            int z = 3 * x;

            int cevap = z;

            if (d_sýk == 0)
            {
                az.SetActive(true);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(false);
                a.text = "" + cevap + "";
                int bb; do { bb = Random.Range(50, 100); } while (bb == cevap); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(50, 100); } while (cc == bb); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(50, 100); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 1)
            {
                az.SetActive(false);
                bz.SetActive(true);
                cz.SetActive(false);
                dz.SetActive(false);
                int aa; do { aa = Random.Range(50, 100); } while (aa == cevap); a.text = "" + aa + "";
                int bb = Random.Range(50, 100);
                b.text = "" + cevap + "";
                int cc; do { cc = Random.Range(50, 100); } while (cc == aa); c.text = "" + cc + "";
                int dd; do { dd = Random.Range(50, 100); } while (dd == cc); d.text = "" + dd + "";

            }
            if (d_sýk == 2)
            {
                az.SetActive(false);
                bz.SetActive(false);
                cz.SetActive(true);
                dz.SetActive(false);
                int aa; do { aa = Random.Range(50, 100); } while (aa == cevap); a.text = "" + aa + "";
                int bb; do { bb = Random.Range(50, 100); } while (bb == aa); b.text = "" + bb + "";
                int cc = Random.Range(50, 100);
                c.text = "" + cevap + "";
                int dd; do { dd = Random.Range(50, 100); } while (dd == bb); d.text = "" + dd + "";

            }
            if (d_sýk == 3)
            {
                az.SetActive(false);
                bz.SetActive(false);
                cz.SetActive(false);
                dz.SetActive(true);
                int aa; do { aa = Random.Range(50, 100); } while (aa == cevap); a.text = "" + aa + "";
                int bb; do { bb = Random.Range(50, 100); } while (bb == aa); b.text = "" + bb + "";
                int cc; do { cc = Random.Range(50, 100); } while (cc == bb); c.text = "" + cc + "";
                int dd = Random.Range(50, 100);
                d.text = "" + cevap + "";

            }



        }


        soru.SetActive(true);
        kolay_btn.SetActive(false);
        orta_btn.SetActive(false);
        zor_btn.SetActive(false);


    }



    void Update()
    {

    }
}
