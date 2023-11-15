using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minigame : MonoBehaviour
{
    public float detectionRadius = 5f; // プレイヤーを検出する半径
    public Color flashColor = Color.white; // 白い画面の色
    public float flashDuration = 1f; // 白い画面が表示される時間
    public GameObject plyerrr;
    private bool isPlayerNear = false;
    public Canvas canvas;
    public Text naame;
    public GameObject Mini_gamen;
    public GameObject Canvas2;
    public GameObject osutoko;
    void Update()
    {
        // プレイヤーの近くにいるかどうかを検出
        isPlayerNear = IsPlayerNear();
        Debug.Log(isPlayerNear);
        // エンターキーが押されたら白い画面を表示
        if (isPlayerNear == true && Input.GetKeyDown(KeyCode.I))
        {
            FlashWhiteScreen();
            Canvas2.SetActive(true);

        }
        if (Input.GetKeyDown(KeyCode.P))
        {

            osutoko.transform.localPosition = new Vector3(-392, 90, 0);
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

    void FlashWhiteScreen()
    {
        // 白い画面を表示
        Canvas2.SetActive(true);
    }
}
