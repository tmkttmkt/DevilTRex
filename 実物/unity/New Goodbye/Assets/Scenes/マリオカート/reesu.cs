using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class reesu : MonoBehaviour
{
    // Start is called before the first frame update
    public int start;
    public Text countdownText,countdownText2; // カウントダウンを表示するテキスト
    private float countdown = 3f; // カウントダウンの初期値
    private int Start_kesu;
    private sound2 sou2;
    public Text aka,ao,midori,murasaki,orennzi; 


    void Start()
    {
        start=0;
        sou2=FindObjectOfType<sound2>();
        InvokeRepeating("Countdown", 1f, 1f); // 1秒ごとにCountdownメソッドを繰り返し実行←し初め
        
        
    }


    void Countdown()
    {
        countdown -= 1f; // カウントダウンを1秒減らす
        if (countdown >= 1)
        {
            countdownText.text = "      "+countdown.ToString(); // テキストにカウントダウンの数値を表示する
            countdownText2.text=countdownText.text;
            sou2.kaunnto_sound();
        }
        else
        {
            countdownText.text = "   Start!"; // カウントダウンが終わった後に"Start!"と表示する
            countdownText2.text=countdownText.text;
            CancelInvoke("Countdown"); // カウントダウンを停止する←終わり
            InvokeRepeating("Start_delete", 1f, 1f);
            start=1;
            sou2.kaunnto_sound2();
            sou2.BGM();
        }
    }


    // Update is called once per frame
    void Start_delete()
    {
        Start_kesu+=1;
        if(Start_kesu==3)
        {
            countdownText.text="";
            countdownText2.text=countdownText.text;
            CancelInvoke("Start_delete");
        }
    }
    void Update()
    {

        if(start==0)//レース開始前
        {
            
        }
        if(start==1)//レース開始
        {
            if(ao.text=="4"||murasaki.text=="4"||midori.text=="4"||orennzi.text=="4")
            {
                SceneManager.LoadScene("OVER");//GAME開始する
            }
            if(aka.text=="4")SceneManager.LoadScene("SampleScene");//GAME開始する
        }
      
    }
}
