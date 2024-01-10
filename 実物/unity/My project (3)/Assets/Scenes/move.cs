using System;
using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{
    public Vector3Int moritaF1,moritaF2,moritaF3; 
    public Canvas main,erebeta;
    private ITEM item;
    // Start is called before the first frame update
    public GameObject tobira1,tobira2,tobira3,Key2Fdoa;
    public GameObject moritagousuto,tusimaro,tusimaro2,thirano;
    //public Vector3Int erebeitaa1_position,erebeitaa2_position,erebeitaa3_position;
    public GameObject syuzinnkou;
    public GameObject[] moritagousuto_doa=new GameObject[3];
    public GameObject hiraku_1F,hiraku_2F,hiraku_3F,takaramae,F2key,saigonokaginomaenodoa;
    public GameObject moritagousutoerebeitaa;
    public int[] move_onoff=new int[10];
    private Story s;
    private syujinnkou syu;
    private sound sou;
    public int arukanai,atattenai;
    
    void Start()
    {
        s=FindObjectOfType<Story>();
        item=FindObjectOfType<ITEM>();
        sou=FindObjectOfType<sound>();
    }

    // Update is called once per frame
    void Update()
    {
    
        if(move_onoff[1]==1&&(s.storykaunnto==15||s.storykaunnto==19)&&move_onoff[0]==1)
        {
            moritagousuto_doa[0].transform.position-=transform.up/10;
            if(move_onoff[8]==0)
            {
                sou.open();
                move_onoff[8]=1;
            }
            
        }
        if(move_onoff[1]==2&&(s.storykaunnto==15||s.storykaunnto==19)&&move_onoff[0]==2)
        {
            takaramae.transform.position+=transform.up/10;
            item.item2.text="アイテムは現在ありません";
            if(move_onoff[8]==1)
            {
                sou.open();
                move_onoff[8]=2;
            }
            
        }
        if(move_onoff[1]==4&&(s.storykaunnto==15||s.storykaunnto==19)&&move_onoff[0]==4)
        {
            Key2Fdoa.transform.position+=transform.up/10;
            item.item1.text="アイテムは現在ありません";
            item.item2.text="アイテムは現在ありません";
            item.item3.text="アイテムは現在ありません";
            item.item4.text="アイテムは現在ありません";
            if(move_onoff[8]==4)
            {
                sou.open();
                move_onoff[8]=5;
            }
        }
        if(move_onoff[1]==5&&(s.storykaunnto==15||s.storykaunnto==19)&&move_onoff[0]==5)
        {
            saigonokaginomaenodoa.transform.position-=transform.up/10;
             item.item3.text="アイテムは現在ありません";
            if(move_onoff[8]==5)
            {
                sou.open();
                move_onoff[8]=6;
            }
        }
        if(move_onoff[1]==3&&(s.storykaunnto==15||s.storykaunnto==19)&&move_onoff[0]==3)
        {
            moritagousuto_doa[1].transform.position-=transform.up/10;
            if(move_onoff[8]==2)
            {
                sou.open();
                move_onoff[8]=4;
            }
        }
        if(move_onoff[2]==1&&(s.storykaunnto==15||s.storykaunnto==19)&&move_onoff[3]==2)moritagousutoerebeitaa2Fhe_up();
        if((move_onoff[2]==1||move_onoff[2]==2)&&s.storykaunnto==15&&move_onoff[3]==3)moritagousutoerebeitaa3Fhe_up();
        if(move_onoff[2]==3&&(s.storykaunnto==15||s.storykaunnto==19)&&move_onoff[3]==2)moritagousutoerebeitaa2Fhe_down();
        if((move_onoff[2]==3||move_onoff[2]==2)&&(s.storykaunnto==15||s.storykaunnto==19)&&move_onoff[3]==1)moritagousutoerebeitaa1Fhe_down();
    }//move_onoff[2]現在の階数//move_onoff[3]移動階
    public void moritagousuto_up()
    {
       if(moritagousuto.transform.position.y<4f)moritagousuto.transform.position+=transform.up/10;//森田ゴーストを動かす(上)
      
    }
    public void moritagousuto_down()
    {
        if(moritagousuto.transform.position.y>-10f)moritagousuto.transform.position-=transform.up/10;//森田ゴーストを動かす(下)
    }
        public void tusimaro_up()
    {
       
      if(tusimaro.transform.position.y>23f)tusimaro.transform.position-=transform.up/10;//森田ゴーストを動かす(下)
    }
    public void tusimaro_down()
    {
     tusimaro.transform.position+=transform.up/10;//森田ゴーストを動かす(上)
    }
      public void moritagousuto_doa3()//セリフ出ている間に最後のドア開く関数
    {
        if(s.storykaunnto==22)
        {
            if(move_onoff[8]==6)
            {
                sou.open();
                move_onoff[8]=7;
            }
            moritagousuto_doa[2].transform.position+=transform.up/100;
        }
    }
    public void moritagousutoerebeitaa2Fhe_up()//1下の階から２階へ
    { 
      if(move_onoff[4]<1400)moritagousutoerebeitaa.transform.position+=transform.up/100;
      if(move_onoff[4]<1400)syuzinnkou.transform.transform.position+=transform.up/100;
      if(move_onoff[4]==1400)
      {
        hiraku_2F.SetActive(false);
        arukanai=0;
        main.enabled=true;
        erebeta.enabled=false;
        sou.erebeta2();
        sou.erebetahiraku1();
      }

      move_onoff[4]+=1;
    }
    public void thirano1()
    {
        //if(tusimaro.transform.position.y>19f)
        thirano.transform.position-=transform.up/10;
    } 
    public void moritagousutoerebeitaa3Fhe_up()//下の階から３階へ
    {
         if (move_onoff[2]==1&&move_onoff[4]<3000)moritagousutoerebeitaa.transform.position+=transform.up/100;
         if (move_onoff[2]==2&&move_onoff[4]<1600)moritagousutoerebeitaa.transform.position+=transform.up/100;
         if (move_onoff[2]==1&&move_onoff[4]<3000)syuzinnkou.transform.transform.position+=transform.up/100;
         if (move_onoff[2]==2&&move_onoff[4]<1600)syuzinnkou.transform.transform.position+=transform.up/100;
         move_onoff[4]+=1;
         if(move_onoff[4]==3000&&move_onoff[2]==1)
         {
            hiraku_3F.SetActive(false);
            arukanai=0;
            main.enabled=true;
      
            erebeta.enabled=false;
            sou.erebeta2();
            sou.erebetahiraku1();
         }
         if(move_onoff[4]==1600&&move_onoff[2]==2)
         {
            hiraku_3F.SetActive(false);
            arukanai=0;
            main.enabled=true;
            erebeta.enabled=false;
            sou.erebeta2();
            sou.erebetahiraku1();
      
         }
     
        
    }
    public void moritagousutoerebeitaa1Fhe_down()//上の階から１階へ
    {
     if (move_onoff[2]==2&&move_onoff[4]<1400)moritagousutoerebeitaa.transform.position-=transform.up/100;
     if (move_onoff[2]==3&&move_onoff[4]<3000)moritagousutoerebeitaa.transform.position-=transform.up/100;
     if (move_onoff[2]==2&&move_onoff[4]<1400)syuzinnkou.transform.transform.position-=transform.up/100;
     if (move_onoff[2]==3&&move_onoff[4]<3000)syuzinnkou.transform.transform.position-=transform.up/100;
     if (move_onoff[2]==2&&move_onoff[4]==1400)
     {
        hiraku_1F.SetActive(false);
        arukanai=0;
        main.enabled=true;
        erebeta.enabled=false;
        sou.erebeta2();
        sou.erebetahiraku1();
        
     }
     if (move_onoff[2]==3&&move_onoff[4]==3000)
     {
        hiraku_1F.SetActive(false);
        arukanai=0;
        main.enabled=true;
        erebeta.enabled=false;
        sou.erebeta2();
        sou.erebetahiraku1();
        
     }

     move_onoff[4]+=1;
    

    }
    public void moritagousutoerebeitaa2Fhe_down()//上の階から２階へ
    {
       if(move_onoff[2]==3&&move_onoff[4]<1600)moritagousutoerebeitaa.transform.position-=transform.up/100;
       if(move_onoff[4]<1400)syuzinnkou.transform.transform.position-=transform.up/100;
       if(move_onoff[4]==1400)
       {
        hiraku_2F.SetActive(false);
        main.enabled=true;
        arukanai=0;
        erebeta.enabled=false;
        sou.erebeta2();
        sou.erebetahiraku1();
      
     }
       move_onoff[4]+=1;
    }
   
     
}
