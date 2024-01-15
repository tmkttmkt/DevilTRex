using System.Collections;
using System.Collections.Generic;
//using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class tatakai : MonoBehaviour
{
    public Text displayedText,good,MYHP; // UI Textコンポーネント（表示されるテキスト）///////////////
    private string targetText = "GO!"; // タイプする目標のテキスト
    
    private int currentIndex = 0; // 現在の入力位置____________________________________________
    public Canvas gamegamenn,main;
    public RectTransform imageRectTransform; // Canvas上のイメージのRectTransform
    public float moveSpeed = 100f; // 移動速度
    private sound s;
    private Story st;
    public float bpm = 150f; // BPM（1分間の拍数）
    
    private float beatInterval; // 1拍あたりの時間間隔

    private float timer; // 時間計測用のタイマー
    public int beatCount = 0,start=0; // 現在の小節カウント
    public int i=1,ii=0,OK=0,reberu,HP=1,iii=1;
    public Image image1; // Canvas内のImage1
    public Image image2; // Canvas内のImage2
    public RawImage batorukyara;
    public Text ute;
    public Texture tatakaikyara1,tatakaikyara2;
    private serihu2 serihu2;

    // Start is called before the first frame update
    void Start()
    { 
        beatInterval = 60f / bpm;
        s=FindAnyObjectByType<sound>();
        st=FindAnyObjectByType<Story>();
        serihu2=FindAnyObjectByType<serihu2>();
        UpdateDisplayedText(); // 表示されるテキストを更新
       
      
    }

    // Update is called once per frame
    public void tatakai1()
    {
            if(start==0)
            {
              start=1;
              if(st.storykaunnto==11)reberu=0;
              if(st.storykaunnto==17)reberu=21;
              if(st.storykaunnto==23)reberu=41;
            }
    }
    public void tusimaba()
    {
        batorukyara.texture=tatakaikyara1;
    }
    public void takatu()
    {
        batorukyara.texture=tatakaikyara2;
    }
    void Update()
    {
        if(start==1)
        {
            if(st.storykaunnto==11)s.BGM_morita();
            if(st.storykaunnto==17)
            {
                s.BGM_tusima();
                start=0;
                beatCount=0;
                i=1;
                ii=0;
                serihu2.MoveImage(serihu2.targetPosition);
            }
            if(st.storykaunnto==23)
            {
                s.BGM_takatuka();
                start=0;
                beatCount=0;
                i=1;
                ii=0;
                serihu2.MoveImage(serihu2.targetPosition);
            }
            HP=6;
            start=2;
            gamegamenn.enabled=true;
            main.enabled=false;
        }
        if(start==2)
        {
        timer += Time.deltaTime;

        if (timer >= beatInterval)
        {
            timer -= beatInterval;
            beatCount++;
        
            // 4小節ごとに条件を発動する
            if ((beatCount-iii) % 16 == 0) // 4小節分のカウント（16拍）が経過した時
            {
                // ここに条件を発動させるコードを記述する
                 Debug.Log("aaaaa");
                 reberu+=1;
                 currentIndex = 0;
                 UpdateDisplayedText();
                 ute.text="以下のスペルを\n　入力しろ！　\n　　 ↓";
                 

                 if(OK!=2)
                 {
                    HP-=1;
                    MYHP.text=HP.ToString();
                 }
                 if(HP==0)
                 {
                    gamegamenn.enabled=false;
                    main.enabled=true;
                    st.serihuokuru=1;
                    if(st.storykaunnto==11)
                    {
                      st.storykaunnto=1000;
                      reberu=0;
                    }
                    if(st.storykaunnto==17)
                    {
                      st.storykaunnto=1500;
                      reberu=21;
                    }
                    if(st.storykaunnto==23)
                    {
                      st.storykaunnto=2000;
                      reberu=41;
                    }
                    HP=6;

                    
              
                 }
                 OK=0;
                 good.enabled = false;
                 if(reberu==1)
                    {
                      targetText = "kit";
                      displayedText.text="kit";
                    }
                    if(reberu==2)
                    {
                      targetText = "run";
                      displayedText.text="run";
                    }
                    if(reberu==3)
                    {
                      targetText = "out";
                      displayedText.text="out";
                    }
                   if(reberu==4)
                    {
                      targetText = "red";
                      displayedText.text="red";
                    }
                    if(reberu==5)
                    {
                      targetText = "top";
                      displayedText.text="top";
                    }
                    if(reberu==6)
                    {
                      targetText = "sad";
                      displayedText.text="sad";
                    }
                    if(reberu==7)
                    {
                      targetText = "put";
                      displayedText.text="put";
                    }
                    if(reberu==8)
                    {
                      targetText = "him";
                      displayedText.text="him";
                    }

                    if(reberu==9)
                    {
                      targetText = "abc";
                      displayedText.text="abc";
                    }
                    if(reberu==10)
                    {
                      targetText = "sos";
                      displayedText.text="sos";
                    }
                    if(reberu==11)
                    {
                      targetText = "def";
                      displayedText.text="def";
                    }
                    if(reberu==12)
                    {
                      targetText = "win";
                      displayedText.text="win";
                    }
                    if(reberu==13)
                    {
                      targetText = "jun";
                      displayedText.text="jun";
                    }

                    if(reberu==14)
                    {
                      targetText = "fly";
                      displayedText.text="fly";
                    }
                    if(reberu==15)
                    {
                      targetText = "end";
                      displayedText.text="end";
                    }
                    if(reberu==16)
                    {
                      targetText = "yet";
                      displayedText.text="yet";
                    }
                    if(reberu==17)
                    {
                      targetText = "cat";
                      displayedText.text="cat";
                    }
                    if(reberu==18)
                    {
                      targetText = "dog";
                      displayedText.text="dog";
                    }

                    if(reberu==19)
                    {
                      targetText = "fin";
                      displayedText.text="fin";
                    }
                    if(reberu==20)
                    {
                      targetText = "not";
                      displayedText.text="not";
                    }
                    if(reberu==21)
                    {
                    gamegamenn.enabled=false;
                    main.enabled=true;
                    st.serihuokuru=1;
                    ute.text="以下のスペルを\n　入力しろ！　\n　　 ↓";
                    if(st.storykaunnto==11)st.storykaunnto=12;
                    start=0;
                   
                 
                    }
                      if(reberu==22)
                    {
                      targetText = "break";
                      displayedText.text="break";
                    }
                    if(reberu==23)
                    {
                      targetText = "amber";
                      displayedText.text="amber";
                    }
                    if(reberu==24)
                    {
                      targetText = "apple";
                      displayedText.text="apple";
                    }
                   if(reberu==25)
                    {
                      targetText = "brave";
                      displayedText.text="brave";
                    }
                    if(reberu==26)
                    {
                      targetText = "cloud";
                      displayedText.text="cloud";
                    }
                    if(reberu==27)
                    {
                      targetText = "dance";
                      displayedText.text="dance";
                    }
                    if(reberu==28)
                    {
                      targetText = "error";
                      displayedText.text="error";
                    }
                    if(reberu==29)
                    {
                      targetText = "faith";
                      displayedText.text="faith";
                    }

                    if(reberu==30)
                    {
                      targetText = "ghost";
                      displayedText.text="ghost";
                    }
                    if(reberu==31)
                    {
                      targetText = "house";
                      displayedText.text="house";
                    }
                    if(reberu==32)
                    {
                      targetText = "issue";
                      displayedText.text="issue";
                    }
                    if(reberu==33)
                    {
                      targetText = "joint";
                      displayedText.text="joint";
                    }
                    if(reberu==34)
                    {
                      targetText = "knife";
                      displayedText.text="knife";
                    }

                    if(reberu==35)
                    {
                      targetText = "limit";
                      displayedText.text="limit";
                    }
                    if(reberu==36)
                    {
                      targetText = "money";
                      displayedText.text="money";
                    }
                    if(reberu==37)
                    {
                      targetText = "nurse";
                      displayedText.text="nurse";
                    }
                    if(reberu==38)
                    {
                      targetText = "ocean";
                      displayedText.text="ocean";
                    }
                    if(reberu==39)
                    {
                      targetText = "paper";
                      displayedText.text="paper";
                    }
                    
                   if(reberu==40)
                    {
                    gamegamenn.enabled=false;
                    main.enabled=true;
                    st.serihuokuru=1;
                    ute.text="以下のスペルを\n　入力しろ！　\n　　 ↓";
                    if(st.storykaunnto==17)st.storykaunnto=18;
                        start=0;
                  
                    }
                    if(reberu==42)
                    {
                      targetText = "banana";
                      displayedText.text="banana";
                    }
                    if(reberu==43)
                    {
                      targetText = "cherry";
                      displayedText.text="cherry";
                    }
                    if(reberu==44)
                    {
                      targetText = "doctor";
                      displayedText.text="doctor";
                    }
                   if(reberu==45)
                    {
                      targetText = "delete";
                      displayedText.text="delete";
                    }
                    if(reberu==46)
                    {
                      targetText = "garden";
                      displayedText.text="garden";
                    }
                    if(reberu==47)
                    {
                      targetText = "mother";
                      displayedText.text="mother";
                    }
                    if(reberu==48)
                    {
                      targetText = "pepper";
                      displayedText.text="pepper";
                    }
                    if(reberu==49)
                    {
                      targetText = "rocket";
                      displayedText.text="rocket";
                    }

                    if(reberu==50)
                    {
                      targetText = "silver";
                      displayedText.text="silver";
                    }
                    if(reberu==51)
                    {
                      targetText = "tomato";
                      displayedText.text="tomato";
                    }
                    if(reberu==52)
                    {
                      targetText = "camera";
                      displayedText.text="camera";
                    }
                    if(reberu==53)
                    {
                      targetText = "dragon";
                      displayedText.text="dragon";
                    }
                    if(reberu==54)
                    {
                      targetText = "fabric";
                      displayedText.text="fabric";
                    }

                    if(reberu==55)
                    {
                      targetText = "school";
                      displayedText.text="school";
                    }
                    if(reberu==56)
                    {
                      targetText = "guitar";
                      displayedText.text="guitar";
                    }
                    if(reberu==57)
                    {
                      targetText = "hammer";
                      displayedText.text="hammer";
                    }
                    if(reberu==58)
                    {
                      targetText = "laptop";
                      displayedText.text="laptop";
                    }
                    if(reberu==59)
                    {
                      targetText = "monday";
                      displayedText.text="monday";
                    }

                    if(reberu==60)
                    {
                      targetText = "please";
                      displayedText.text="please";
                    }
                    if(reberu==61)
                    {
                      targetText = "orange";
                      displayedText.text="orange";
                    }
                    if(reberu==62)
                    {
                    gamegamenn.enabled=false;
                    main.enabled=true;
                    st.serihuokuru=1;
                    ute.text="以下のスペルを\n　入力しろ！　\n　　 ↓";
                    if(st.storykaunnto==23)st.storykaunnto=24;
                    start=0;
                    }
        
                 i=i*-1;
            }
        }
        if(st.storykaunnto!=1000)
        {float moveX = i * moveSpeed * Time.deltaTime;
        
        // 現在の位置に移動量を加えて新しい位置を設定
        Vector3 newPosition = imageRectTransform.anchoredPosition;
        

        newPosition.x += moveX;
        imageRectTransform.anchoredPosition = newPosition;
        }
                 if (ImagesOverlap(image1, image2))
                {
        if ((Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))&&OK==1)
             {
               good.enabled = true;
                OK=2;
             
                
                }           
             }
        if ((Input.anyKeyDown)&&((currentIndex<3&&st.storykaunnto==11)||(currentIndex<5&&st.storykaunnto==17)||(currentIndex<6&&st.storykaunnto==23)))
            {
                if (Input.inputString.Length == 0)
                {
                    return;
                }
                char inputCharacter = Input.inputString[0]; // 入力された文字を取得

            // 入力文字が目標の文字と一致するかをチェック
            if (inputCharacter == targetText[currentIndex])
            {
                currentIndex++; // 入力位置を進める
                UpdateDisplayedText(); // 表示されるテキストを更新

                // ゲームクリア条件のチェック（ここでは最後の文字までタイプしたらゲームクリア）
                if (currentIndex >= targetText.Length)
                {
                    Debug.Log("Game Cleared!"); // ゲームクリアの処理を追加
                    OK=1;
                    // ここにゲームクリア時の処理を追加
                    ute.text="赤ラインでエンターキーを押せ";
                }
            }
        }
    }}
    void UpdateDisplayedText()
    {
        displayedText.text = targetText.Substring(currentIndex); // 入力対象の残りのテキストを表示
    }
    bool ImagesOverlap(Image img1, Image img2)
    {
        // RectTransformの取得
        RectTransform rectTransform1 = img1.rectTransform;
        RectTransform rectTransform2 = img2.rectTransform;

        // Imageの範囲を取得
        Rect rect1 = new Rect(rectTransform1.position.x, rectTransform1.position.y, rectTransform1.rect.width, rectTransform1.rect.height);
        Rect rect2 = new Rect(rectTransform2.position.x, rectTransform2.position.y, rectTransform2.rect.width, rectTransform2.rect.height);

        // 2つのImageの範囲が重なっているか判定
        return rect1.Overlaps(rect2);
    }
    }

