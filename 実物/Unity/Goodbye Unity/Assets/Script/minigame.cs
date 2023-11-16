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

    public Random random;
    private void Start()
    {
        osutoko1.transform.localPosition = new Vector3(Random.Range(-392f,381f), 90, 0);
        osutoko2.transform.localPosition = new Vector3(Random.Range(-392f, 381f), 13, 0);
        osutoko3.transform.localPosition = new Vector3(Random.Range(-392f, 381f), -60, 0);
    }
    void Update()
    {
        // プレイヤーの近くにいるかどうかを検出
        isPlayerNear = IsPlayerNear();
        // エンターキーが押されたら白い画面を表示
        if (isPlayerNear == true && Input.GetKeyDown(KeyCode.I))
        {
            naame.text = "黒いところで止めろ!";
            ugoku_flg = true;
            osutoko1.transform.localPosition = new Vector3(Random.Range(-392f, 381f), 90, 0);
            osutoko2.transform.localPosition = new Vector3(Random.Range(-392f, 381f), 13, 0);
            osutoko3.transform.localPosition = new Vector3(Random.Range(-392f, 381f), -60, 0);
            kakeru = 1;
            clear = 0;
            start_flg = !start_flg;
            Canvas2.SetActive(start_flg);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            start_flg = false;
            Canvas2.SetActive(start_flg);

        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            osutoko1.transform.localPosition = new Vector3(-392, 90, 0);
        }
        if (start_flg)//スタートフラグ
        {
            if(nanbonme == 2 && tugi_flg == true)
            {
                tugi_flg = false;
                move_gage.transform.localPosition = new Vector3(-392, 13, 0);
            }
            if (nanbonme == 3 && tugi_flg == true)
            {
                tugi_flg = false;
                move_gage.transform.localPosition = new Vector3(-392, -60, 0);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                if (move_gage.transform.localPosition.x + 20 > osutoko1.transform.localPosition.x && move_gage.transform.localPosition.x - 20 < osutoko1.transform.localPosition.x)
                {
                    tugi_flg = true;
                    nanbonme += 1;
                    ugoku_flg = !ugoku_flg;
                    clear += 1;
                    naame.text = "いいね！";
                }
                else
                {
                    tugi_flg = true;
                    nanbonme += 1;
                    ugoku_flg = !ugoku_flg;
                    naame.text = "下手くそ!";
                }

                if (move_gage.transform.localPosition.x + 20 > osutoko2.transform.localPosition.x && move_gage.transform.localPosition.x - 20 < osutoko2.transform.localPosition.x && nanbonme == 2)//2本目
                {
                    tugi_flg = true;
                    ugoku_flg = !ugoku_flg;
                    clear += 1;
                    naame.text = "いいね！";
                }
                else
                {
                    tugi_flg = true;
                    ugoku_flg = !ugoku_flg;
                    naame.text = "下手くそ!";
                }
                if (move_gage.transform.localPosition.x + 20 > osutoko3.transform.localPosition.x && move_gage.transform.localPosition.x - 20 < osutoko3.transform.localPosition.x && nanbonme == 2)//2本目
                {
                    tugi_flg = true;
                    ugoku_flg = !ugoku_flg;
                    clear += 1;
                    naame.text = "いいね！";
                }
                else
                {
                    tugi_flg = true;
                    ugoku_flg = !ugoku_flg;
                    naame.text = "下手くそ!";
                }
            }
          if (ugoku_flg)
                {
                    move_gage.transform.localPosition += new Vector3(kakeru * 10, 0, 0);
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

}
