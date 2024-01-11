using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

//using UnityEditor;

public class Story : MonoBehaviour
{
    public Text mokuhyou;
    public int storykaunnto=0,serihuokuru=0,susumiseigyo;
    private serihu2 serihu2;
    private pasuwado pas;
    public Canvas main;
    public GameObject syuzinnkou;
    public Text siraberu; // キャンバス内のTextオブジェクトの参照
    public ITEM item;
    private move move;
    private erebeitaa e;
    private tatakai tatakai;

    private syujinnkou sy;//テストプレイ用！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！
    // Start is called before the first frame update
    private gamekirikae gamekirikae;
    private sound sound;
    private pasCanvas p;
    public string devele="start2.exe",text="k.txt";
    //Devil・ｔ・REXのパスと、セーブ用のテキストフォルダのパス↑//rexgameのファイルでもパス指定してる
    void Start()
    {
         serihu2= FindObjectOfType<serihu2>();
         pas= FindObjectOfType<pasuwado>();
         item=FindObjectOfType<ITEM>();
         move=FindObjectOfType<move>();
         sy=FindObjectOfType<syujinnkou>();
         e=FindObjectOfType<erebeitaa>();
         tatakai=FindObjectOfType<tatakai>();
         gamekirikae=FindObjectOfType<gamekirikae>();
         sound=FindObjectOfType<sound>();
         //storykaunnto=21;//テストプレイ用！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！
         //sy.i=0;//テストプレイ用！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！
         p=FindObjectOfType<pasCanvas>();
         
    }

    // Update is called once per frame
    void Update()
    {
        if(storykaunnto==1)mokuhyou.text ="目標:建物の中に入ろう";
        if(storykaunnto==3)mokuhyou.text ="目標:部屋を探索しよう";
        if(storykaunnto==5)mokuhyou.text ="目標:音がなった場所を探そう";
        if(storykaunnto==7)mokuhyou.text ="目標:白い柵を探そう";
        if(storykaunnto==9)mokuhyou.text ="目標:森田と戦いに行こう";
        if(storykaunnto==13)mokuhyou.text ="目標:さっき通れなかった白い柵の向こうを探索しよう";
        if(storykaunnto==15)mokuhyou.text ="目標:1Fと3Fを探索して2Fの部屋の鍵を手に入れて2Fの部屋に入ろう";
        if(storykaunnto==19)mokuhyou.text ="目標:髙塚の部屋に入り中を探索しよう";
        if(storykaunnto==25)mokuhyou.text ="目標:研究室に向かおう";
        if(storykaunnto==27)mokuhyou.text ="目標:赤色の絨毯の上に行こう";
        if(storykaunnto==11)tatakai.tatakai1();
        if(storykaunnto==17)
        {
            tatakai.tatakai1();
            tatakai.tusimaba();
        }
        if(storykaunnto==23)
        {
            tatakai.tatakai1();
            tatakai.takatu();
        }

    }
    
        void OnCollisionEnter(Collision collision)
        {
         if  (collision.gameObject.CompareTag("ITEM"))//ITEMゲットできるオブジェクトにぶつかったら
         {
            if(collision.gameObject.name == "morita_kagi1"&&storykaunnto==15)
            {
                item.name1="2Fの部屋鍵1つ目";//アイテム名
                item.item1_get();//アイテム欄のどの場所にアイテム表示させたいか？
            }
            if(collision.gameObject.name == "takara"&&storykaunnto==15)
            {
                item.name2="宝箱の鍵";//アイテム名
                item.item2_get();//アイテム欄のどの場所にアイテム表示させたいか？
            }
            if(collision.gameObject.name == "morita_kagi2"&&storykaunnto==15)
            {
                item.name2="2Fの部屋鍵2つ目";//アイテム名
                item.item2_get();//アイテム欄のどの場所にアイテム表示させたいか？
            }
             if(collision.gameObject.name == "2FKey"&&storykaunnto==15)
            {
                item.name3="2Fの部屋鍵3つ目";//アイテム名
                item.item3_get();//アイテム欄のどの場所にアイテム表示させたいか？
            }
            if(collision.gameObject.name == "KeyKey"&&storykaunnto==19)
            {
                item.name3="髙塚の部屋の鍵";//アイテム名
                item.item3_get();//アイテム欄のどの場所にアイテム表示させたいか？
            }
            if(collision.gameObject.name == "morita_kagi3"&&storykaunnto==25)
            {
                item.name3="髙塚の研究室の鍵";//アイテム名
                item.item3_get();//アイテム欄のどの場所にアイテム表示させたいか？
            }

         }

         
         if  (collision.gameObject.CompareTag("heya1"))//いつストーリー進めてセリフ出すか
        {
          if(collision.gameObject.name == "heya1"&&storykaunnto==1)
          {
            serihuokuru=1;//Qキーを押さなくても自動でセリフや文章を流したい時は付ける
            storykaunnto=2;//ストーリー進める
          }
         if(collision.gameObject.name == "nazotokitokeru"&&storykaunnto==5)
          {
            serihuokuru=1;//Qキーを押さなくても自動でセリフや文章を流したい時は付ける
            storykaunnto=6;//ストーリー進める
            syuzinnkou.transform.rotation = Quaternion.Euler(0f,-90f,0f);//オブジェクトの座標変更
          }
          if(collision.gameObject.name == "madatoorenai"&&storykaunnto==7)
           {
            susumiseigyo=1;//ストーリー進めないときに着ける
            serihuokuru=1;//Qキーを押さなくても自動でセリフや文章を流したい時は付ける
            serihu2.k=1;
            syuzinnkou.transform.position-=transform.forward;
           }

          if(collision.gameObject.name == "tobiraakanai"&&storykaunnto==7)
          {
            syuzinnkou.transform.rotation = Quaternion.Euler(0f,90f,0f);//オブジェクトの座標変更
            serihuokuru=1;//Qキーを押さなくても自動でセリフや文章を流したい時は付ける
            storykaunnto=8;//ストーリー進める
          }
           if(collision.gameObject.name == "moritakennkyuusya"&&storykaunnto==9)
           {
                syuzinnkou.transform.rotation = Quaternion.Euler(0f,-90f,0f);//オブジェクトの座標変更
                serihuokuru=1;//Qキーを押さなくても自動でセリフや文章を流したい時は付ける
                storykaunnto=10;//ストーリー進める
           }

            if(collision.gameObject.name == "akanai"&&storykaunnto==19)
          {
            serihuokuru=1;//Qキーを押さなくても自動でセリフや文章を流したい時は付ける
            storykaunnto=20;//ストーリー進める
          }
        if(collision.gameObject.name == "saigonotatakai"&&storykaunnto==21)
          {
            serihuokuru=1;//Qキーを押さなくても自動でセリフや文章を流したい時は付ける
            storykaunnto=22;//ストーリー進める
            syuzinnkou.transform.rotation = Quaternion.Euler(0f,-90f,0f);//オブジェクトの座標変更
          }
            if(collision.gameObject.name == "honntonisaigo"&&storykaunnto==25)
          {
            serihuokuru=1;//Qキーを押さなくても自動でセリフや文章を流したい時は付ける
            storykaunnto=26;//ストーリー進める
            syuzinnkou.transform.rotation = Quaternion.Euler(0f,-90f,0f);//オブジェクトの座標変更
          }
           if(collision.gameObject.name == "gamehe"&&storykaunnto==27)
          {
            gamekirikae.LaunchExternalExe();
            //UnityEditor.EditorApplication.isPlaying = false;//UNITYエディタ上でも止まるようにするため
            
            

          }

          if(collision.gameObject.name == "moritabatoru"&&storykaunnto==13)
          {
            syuzinnkou.transform.rotation = Quaternion.Euler(0f,90f,0f);//オブジェクトの座標変更
            serihuokuru=1;//Qキーを押さなくても自動でセリフや文章を流したい時は付ける
            storykaunnto=14;//ストーリー進める
          }
            if(collision.gameObject.name == "tusima"&&storykaunnto==15)
          {
            syuzinnkou.transform.rotation = Quaternion.Euler(0f,0f,0f);//オブジェクトの座標変更
            serihuokuru=1;//Qキーを押さなくても自動でセリフや文章を流したい時は付ける
            storykaunnto=16;//ストーリー進める
          }
          
          if(collision.gameObject.name == "moritagousuto_1doamae"&&storykaunnto==15)move.move_onoff[1]=1;
          if(collision.gameObject.name == "takaramae"&&storykaunnto==15)move.move_onoff[1]=2;
          if(collision.gameObject.name == "moritagousuto_2doamae"&&storykaunnto==15)move.move_onoff[1]=3;
          if(collision.gameObject.name == "2FKeymae"&&storykaunnto==15)move.move_onoff[1]=4;
          if(collision.gameObject.name == "saigoKeymae"&&storykaunnto==19)move.move_onoff[1]=5;
          collision.gameObject.CompareTag("heya1");
          //serihu2.siraberu=1;👈Qキーで調べるとき用
          //siraberu.gameObject.SetActive(!siraberu.gameObject.activeSelf);👈Qキーで調べるとき用
        }
         if(collision.gameObject.CompareTag("2_pass"))//いつストーリー進めてセリフ出すか
        {
          if(storykaunnto==3)
          {
            susumiseigyo=1;//ストーリー進めないときに着ける
            if (collision.gameObject.name == "irigutipas") serihu2.siraberu=1;//👈Qキーで調べるとき用、とオブジェクトの名前からアドレスの指定、
            if (collision.gameObject.name == "irigutipas2") serihu2.siraberu=2;//👈Qキーで調べるとき用、とオブジェクトの名前からアドレスの指定、
            if (collision.gameObject.name == "irigutipas3") serihu2.siraberu=3;//👈Qキーで調べるとき用、とオブジェクトの名前からアドレスの指定、
            collision.gameObject.CompareTag("2_pass");
            siraberu.gameObject.SetActive(!siraberu.gameObject.activeSelf);//👈Qキーで調べるとき用
          }
          if(storykaunnto==7)
          {
            susumiseigyo=1;//ストーリー進めないときに着ける
            if (collision.gameObject.name == "pas1") serihu2.siraberu=1;//👈Qキーで調べるとき用、とオブジェクトの名前からアドレスの指定、
            collision.gameObject.CompareTag("2_pass");
            siraberu.gameObject.SetActive(!siraberu.gameObject.activeSelf);//👈Qキーで調べるとき用
          }
          if(storykaunnto==21)
          {
             susumiseigyo=1;//ストーリー進めないときに着ける
             if (collision.gameObject.name == "") serihu2.siraberu=1;//👈Qキーで調べるとき用、とオブジェクトの名前からアドレスの指定、
            collision.gameObject.CompareTag("2_pass");
            siraberu.gameObject.SetActive(!siraberu.gameObject.activeSelf);//👈Qキーで調べるとき用
          }
        }
             if(collision.gameObject.name == "erebeitaa1"&&(storykaunnto==15||storykaunnto==19))
        {
            move.move_onoff[2]=1;
            move.move_onoff[4]=0;
            e.erebeita();
            move.arukanai=1;
            move.main.enabled=false;
            syuzinnkou.transform.position=move.moritaF1;
            
        }
        if(collision.gameObject.name == "erebeitaa2"&&(storykaunnto==15||storykaunnto==19))
        {
            move.move_onoff[2]=2;
             move.move_onoff[4]=0;
            e.erebeita();
            move.arukanai=1;
             move.main.enabled=false;
            syuzinnkou.transform.position=move.moritaF2;
        }
        if(collision.gameObject.name == "erebeitaa3"&&(storykaunnto==15||storykaunnto==19))
        {
            move.move_onoff[2]=3;
             move.move_onoff[4]=0;
            e.erebeita();
            move.arukanai=1;
            move.main.enabled=false;
            syuzinnkou.transform.position=move.moritaF3;
        }
        if(collision.gameObject.name == "ere_tukeru"&&(storykaunnto==15||storykaunnto==19))
        {
           
            e.erebeta1.SetActive(true);
            e.erebeta2.SetActive(true);
            e.erebeta3.SetActive(true);
            if( move.move_onoff[7]==0)
            {
                move.move_onoff[7]=1;
                sound.erebetasimaru1();
            }
            move.hiraku_1F.SetActive(true);
            move.hiraku_2F.SetActive(true);
            move.hiraku_3F.SetActive(true);
           
        }

      
        }
     private void OnCollisionExit(Collision collision)//離れたときに反応する関数
     {
           if(collision.gameObject.name == "madatoorenai"&&storykaunnto==7)
           {
            serihu2.k=0;
           }

     if (collision.gameObject.CompareTag("2_pass"))
        {
            serihu2.siraberu=0;//離れたら調べられないようにする(⚠会話中に調べている物体から離れたらバグる)
            Debug.Log("パスワードと離れました");
            siraberu.gameObject.SetActive(!siraberu.gameObject.activeSelf);
        }
 if((collision.gameObject.name == "2FKeymae"||collision.gameObject.name == "moritagousuto_2doamae"||collision.gameObject.name == "takaramae"||collision.gameObject.name == "moritagousuto_1doamae")&&(storykaunnto==15||storykaunnto==19))move.move_onoff[1]=0;

     }
     
}
