using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minigame : MonoBehaviour
{
    public int zahyou = 382;
    public int kakeru = -1;
    public int nanbonme = 1;
    public bool start_flg = false;
    public bool ugoku_flg = true;
    public bool tugi_flg = false;
    public bool saido = false;
    public int clear = 0;
    public float detectionRadius = 5f; // プレイヤーを検出する半径
    public Color flashColor = Color.white; // 白い画面の色
    public float flashDuration = 1f; // 白い画面が表示される時間
    public GameObject plyerrr;
    private bool isPlayerNear = false;
    public Text naame;
    public GameObject Mini_gamen;
    public GameObject Canvas2;
    public GameObject osutoko1;
    public GameObject osutoko2;
    public GameObject osutoko3;
    public GameObject move_gage;
    ata a;
    story st;
    RectTransform gage_rect;

    public Random random;
    private void Start()
    {
        a = FindObjectOfType<ata>();
        st = FindObjectOfType<story>();
        osutoko1.transform.localPosition = new Vector3(Random.Range(-392f,381f), 90, 0);
        osutoko2.transform.localPosition = new Vector3(Random.Range(-392f, 381f), 13, 0);
        osutoko3.transform.localPosition = new Vector3(Random.Range(-392f, 381f), -60, 0);
        gage_rect = move_gage.GetComponent<RectTransform>();//ムーブゲージのレクとトランスフォームが入ってる
    }
    void Update()
    {
        // プレイヤーの近くにいるかどうかを検出
        isPlayerNear = IsPlayerNear();
        // エンターキーが押されたら白い画面を表示
        if (isPlayerNear == true && Input.GetKeyDown(KeyCode.I) && saido == false)
        {
            saido = true;
            naame.text = "Gキーで黒いところに止めろ!";
            //ugoku_flg = true;
            move_gage.transform.localPosition = new Vector3(-392, 90, 0);
            osutoko1.transform.localPosition = new Vector3(Random.Range(-392f, 381f), 90, 0);
            osutoko2.transform.localPosition = new Vector3(Random.Range(-392f, 381f), 13, 0);
            osutoko3.transform.localPosition = new Vector3(Random.Range(-392f, 381f), -60, 0);
            kakeru = 1;
            clear = 0;
            start_flg = true;
            Canvas2.SetActive(start_flg);
        }
        else if (Input.GetKeyDown(KeyCode.I) && nanbonme < 4)
        {
            naame.text = "もうやめるのか？";
            Invoke("Owari", 3.5f);

        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            osutoko1.transform.localPosition = new Vector3(-392, 90, 0);
        }
        if (start_flg)//スタートフラグ
        {
            if (nanbonme != 4)
            {
                move_gage.transform.localPosition += new Vector3(kakeru * 10, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                tugi_flg = true;
                if (nanbonme == 1)
                {
                    if (move_gage.transform.localPosition.x - 10 <= osutoko1.transform.localPosition.x + 15 && osutoko1.transform.localPosition.x - 15 <= move_gage.transform.localPosition.x + 10 && nanbonme == 1 && tugi_flg == true)
                    {
                        tugi_flg = false;
                        nanbonme = 2;
                        move_gage.transform.localPosition = new Vector3(-392, 13, 0);
                        ugoku_flg = !ugoku_flg;
                        clear += 1;
                        naame.text = "いいね！";
                        naame.text += "あと" + (2 - clear) + "回！";
                        Debug.Log("a");
                    }
                    else if (tugi_flg == true)
                    {
                        tugi_flg = false;
                        nanbonme = 2;
                        move_gage.transform.localPosition = new Vector3(-392, 13, 0);
                        ugoku_flg = !ugoku_flg;
                        naame.text = "下手くそ!";
                        Debug.Log("a");
                    }
                }
                if (nanbonme == 2)
                {
                    if (move_gage.transform.localPosition.x - 10 <= osutoko2.transform.localPosition.x + 15 && osutoko2.transform.localPosition.x - 15 <= move_gage.transform.localPosition.x + 10 && nanbonme == 2 && tugi_flg == true)//2本目
                    {
                        tugi_flg = false;
                        nanbonme = 3;
                        move_gage.transform.localPosition = new Vector3(-392, -60, 0);
                        ugoku_flg = !ugoku_flg;
                        clear += 1;
                        if(2 - clear == 0)
                        {
                            naame.text = "完璧だぜブラザー";
                        }
                        else
                        {
                            naame.text = "いいね！";
                            naame.text += "あと" + (2 - clear) + "回！";
                        }
                        Debug.Log("b");
                    }
                    else if (tugi_flg == true)
                    {
                        tugi_flg = false;
                        nanbonme = 3;
                        move_gage.transform.localPosition = new Vector3(-392, -60, 0);
                        ugoku_flg = !ugoku_flg;
                        naame.text = "下手くそ!";
                        Debug.Log("b");
                    }
                }
                if (nanbonme == 3)
                {
                    if (move_gage.transform.localPosition.x - 10 <= osutoko3.transform.localPosition.x + 15 && osutoko3.transform.localPosition.x - 15 <= move_gage.transform.localPosition.x + 10 && nanbonme == 3 && tugi_flg == true)//3本目
                    {
                        tugi_flg = false;
                        nanbonme = 4;
                        clear += 1;
                        Hantei();
                        Debug.Log("c");
                    }
                    else if (tugi_flg == true && move_gage.transform.localPosition.x - 10 > osutoko3.transform.localPosition.x + 15 && osutoko3.transform.localPosition.x - 15 > move_gage.transform.localPosition.x + 10)
                    {
                        nanbonme = 4;
                        start_flg = false;
                        tugi_flg = false;
                        Hantei();
                        Debug.Log("d");
                    }
                    
                }
                Debug.Log(nanbonme);
                Debug.Log(start_flg);
            }

            if (move_gage.transform.localPosition.x <= -382)
             {
               kakeru = 1;
            }
              if (move_gage.transform.localPosition.x >= 382)
               {
                  kakeru = -1;
             }
 
            
        }
    }
    void Hantei()
    {
        Debug.Log("e");
        if (clear >= 2)
        {
            naame.text = "おめでとう";
            Invoke("Owari", 1f);
            Invoke("aitem_add", 2f);
        }
        else
        {
            naame.text = "やり直してこい！";
            Invoke("Owari", 1f);
        }
    }
    void Owari()
    {
        saido = false;
        kakeru = -1;
        nanbonme = 1;
        tugi_flg = false;
        clear = 0;
        start_flg = false;
        Canvas2.SetActive(start_flg);
    }

    bool IsPlayerNear()
    {

        // プレイヤーオブジェクトが存在しない場合はプレイヤーは近くにいないと判定
        float disY = Mathf.Abs(plyerrr.transform.position.y - this.transform.position.y);
        if (disY <= 3F)
        {
            // プレイヤーとの距離が検出半径以内かどうかを判定
            float distanceToPlayer = Vector3.Distance(transform.position, plyerrr.transform.position);
            return distanceToPlayer <= detectionRadius;
        }
        return false;
        // "Player"タグを持つオブジェクトを検索
    }
    void aitem_add()
    {
        a.add_list(new Aitem("motit","お前はすでに脱出に成功している", Resources.Load<Sprite>("出口の持ち手")));
    }

}
