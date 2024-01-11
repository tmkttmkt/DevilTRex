using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pasCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button1; // ボタン1
    public Button button2; // ボタン2
    public Button button3; // ボタン3
    public Button button4; // ボタン4
    public Button modoru,go1; // 戻るボタン
    public Text keta1,keta2,keta3,keta4;
    private int pas1,pas2,pas3,pas4;
    public Canvas pas;
    private sound sou;
    private serihu2 s;
    public GameObject pasdoa,owari;
    public Vector3 newPosition;
    public Text no;
    private int i;
    public int l;

    void Start()//「ボタン変数.onClick.AddListener(起動関数);」をスタートメソッドに書くことで、押されたら、関数が動くプログラムを作れる
    {
        // ボタンごとにクリック時の動作を追加
        button1.onClick.AddListener(TaskOnClick1);
        button2.onClick.AddListener(TaskOnClick2);
        button3.onClick.AddListener(TaskOnClick3);
        button4.onClick.AddListener(TaskOnClick4);
        modoru.onClick.AddListener(modaruClick);
        go1.onClick.AddListener(go);
        sou=FindObjectOfType<sound>();
        s=FindObjectOfType<serihu2>();
        i=0;
    }
    void TaskOnClick1()
    {
        // ボタン1がクリックされた時の処理をここに記述
        Debug.Log("ボタン1がクリックされました");
        // ボタン1が押された時の処理を追加する
        pas1=int.Parse(keta1.text);
        pas1+=1;
        keta1.text=pas1.ToString();
        sou.Koukaonn3();
        if(keta1.text=="10")
        {
            keta1.text="0";
        }
        
    }

    void TaskOnClick2()
    {
        // ボタン2がクリックされた時の処理をここに記述
        Debug.Log("ボタン2がクリックされました");
        // ボタン2が押された時の処理を追加する
        pas2=int.Parse(keta2.text);
        pas2+=1;
        keta2.text=pas2.ToString();
        sou.Koukaonn3();
        if(keta2.text=="10")
        {
            keta2.text="0";
        }
        
    }

    void TaskOnClick3()
    {
        // ボタン3がクリックされた時の処理をここに記述
        Debug.Log("ボタン3がクリックされました");
        // ボタン3が押された時の処理を追加する
        pas3=int.Parse(keta3.text);
        pas3+=1;
        keta3.text=pas3.ToString();
        sou.Koukaonn3();
        if(keta3.text=="10")
        {
            keta3.text="0";
        }
    }

    void TaskOnClick4()
    {
        // ボタン4がクリックされた時の処理をここに記述
        Debug.Log("ボタン4がクリックされました");
        // ボタン4が押された時の処理を追加する
        pas4=int.Parse(keta4.text);
        pas4+=1;
        keta4.text=pas4.ToString();
        sou.Koukaonn3();
        if(keta4.text=="10")
        {
            keta4.text="0";
        }
    }
    void modaruClick()//ゲームに戻る
    {
        pas.enabled=false;
        sou.Koukaonn3();
        s.canvas.enabled=true;
        owari.transform.position+=transform.up/2;
    }
    void go()
    {
        if(keta1.text=="7"&&keta2.text=="5"&&keta3.text=="6"&&keta4.text=="4")
        {
            if(l==0)sou.erebetahiraku1();
            l=1;
            pasdoa.transform.position=newPosition;
            sou.Koukaonn3();
           
        }
        else
        {
            sou.Koukaonn3();
            no.enabled=true;
        }
    }
    void Update()
    {
        if(no.enabled==true)i+=1;
        if(i>100)
        {
            no.enabled=false;
            i=0;
        }
    }
}
