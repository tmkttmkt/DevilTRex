using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ITEM : MonoBehaviour
{    
    public Text Getsainn;
    public Canvas canvas; // ボタンのGameObjectを指定
    public Canvas Itemcanvas; // ボタンのGameObjectを指定
    public Canvas serihu;
    private syujinnkou syu;
    private sitenn sitenn;
    private serihu2 serihu2;
    public Text item1;
    public Text item2;
    public Text item3;
    public Text item4;
    public string name1,name2,name3,name4;
    private sound sound;
    private Story st;
    private move m;
    private pasCanvas p;

     void Start()
    {
      syu= FindObjectOfType<syujinnkou>();
      sitenn= FindObjectOfType<sitenn>();
      sound=FindObjectOfType<sound>();
      st= FindObjectOfType<Story>();
      m= FindObjectOfType<move>();
      p=FindObjectOfType<pasCanvas>();
    }

    void Update()
    {
        if (syu.i==0)
        {
      
         
        }
         if(Input.GetKeyDown(KeyCode.E))//Eキーを押したらcanvasを開く、もしくは閉じる
         {
    
            if(p.pas.enabled ==false&&m.arukanai==0&&st.storykaunnto!=11&&st.storykaunnto!=17&&st.storykaunnto!=23)
            {
                sound.hiraku();
                if (canvas.enabled ==true)
                {
                    Itemcanvas.enabled = true;
                    canvas.enabled = false; 
                }
                else 
                {
                    Itemcanvas.enabled = false; 
                    canvas.enabled = true;
                }
            }
         }
         

    }
    public void item_get()
    {
        Getsainn.gameObject.SetActive(!Getsainn.gameObject.activeSelf);
    }    

    public void item1_get()
    {
        item1.text=name1;
        get();
        if(st.storykaunnto==15)m.move_onoff[0]=1;//鍵一つ持っていたら空けれる場所を通れるようにする
    }
    public void item2_get()
    {
        item2.text=name2;
        get();
        if(st.storykaunnto==15)
        {
            if(name2=="宝箱の鍵")m.move_onoff[0]=2;//鍵二つ持っていたら空けれる場所を通れるようにする
            if(name2=="2Fの部屋鍵2つ目")m.move_onoff[0]=3;//鍵二つ持っていたら空けれる場所を通れるようにする
        }
    }
    public void item3_get()
    {
        item3.text=name3;
        get();
        if(st.storykaunnto==15)
        {
             if(name3=="2Fの部屋鍵3つ目")m.move_onoff[0]=4;
        }
        if(st.storykaunnto==19)
        {
             if(name3=="髙塚の部屋の鍵")m.move_onoff[0]=5;
        }
        }
    
    public void item4_get()
    {
        item4.text=name4;
        get();
    }
    void get()
    {
        sound.Koukaonn2();
        item_get();
        Invoke("item_get", 5f);
    }
    // Canvasを有効にする関数
    public void EnableCanvas()
    {
        
    }
}
