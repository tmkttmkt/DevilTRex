using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{   
   
    public AudioSource BGM,BGM2,BGM3;
    private syujinnkou syu;
    public AudioSource pannti,open1,erebetasimaru,erebetahiraku,erebetaugoku,koukaonn1,koukaonn2,koukaonn3,moritabatoruBGM,tusimaBGM,takatukaBGM,arukuoto,hiraku1;
    
    // Start is called before the first frame update
    private serihu2 serihu;
    void Start()
    {
        syu= FindObjectOfType<syujinnkou>();
        serihu= FindObjectOfType<serihu2>();
        BGM2.Stop();
        BGM3.Stop();
        moritabatoruBGM.Stop();
        koukaonn1.Stop();
        koukaonn2.Stop();
        koukaonn3.Stop();
        tusimaBGM.Stop();
        takatukaBGM.Stop();
        arukuoto.Stop();
        hiraku1.Stop();
        erebetaugoku.Stop();
        erebetasimaru.Stop();
        erebetahiraku.Stop();
        open1.Stop();
        pannti.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (syu.i==1)
        {
            
        }
        if (syu.i==0)
        {
            BGM.Stop();
        }
    }
    public void BGM2_start()
    {
        BGM2.Play();
    }
    public void BGM2_stop()
    {
        BGM2.Stop();
    }
    public void Koukaonn1()
    {
        if(serihu.messageToDisplay!="")koukaonn1.Play();//if文で文が表示されているときにだけ音が鳴るようにしてる
    }
    public void Koukaonn2()
    {
        koukaonn2.Play();
    }
        public void Koukaonn3()
    {
        koukaonn3.Play();
    }
    public void BGM3_start()
    {
        BGM3.Play();
    }
    public void BGM3_stop()
    {
        BGM3.Stop();
    }
    public void BGM_morita()
    {
        moritabatoruBGM.Play();
    }
        public void BGM_morita2()
    {
        moritabatoruBGM.Stop();
    }
    public void BGM_tusima()
    {
        tusimaBGM.Play();
    }
    public void BGM_tusima2()
    {
        tusimaBGM.Stop();
    }
    public void BGM_takatuka()
    {
        takatukaBGM.Play();
    }
        public void BGM_takatuka2()
    {
        takatukaBGM.Stop();
    }
        public void BGM_arukuoto()
    {
        arukuoto.Play();
    }
        public void BGM_arukuoto2()
    {
        arukuoto.Stop();
    }
     public void hiraku()
    {
        hiraku1.Play();
    }
    public void erebeta()
    {
        erebetaugoku.Play();
    }
    public void erebeta2()
    {
        erebetaugoku.Stop();
    }
     public void erebetahiraku1()
    {
        erebetahiraku.Play();
    }
     public void erebetasimaru1()
    {
        erebetasimaru.Play();
    }
         public void open()
    {
        open1.Play();
    }
     public void pannti1()
     {
        pannti.Play();
     }
    
   

    
}
