using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame : MonoBehaviour
{
    public float detectionRadius = 10f; // プレイヤーを検出する半径
    public Color flashColor = Color.white; // 白い画面の色
    public float flashDuration = 1f; // 白い画面が表示される時間

    private bool isPlayerNear = false;

    void Update()
    {
        // プレイヤーの近くにいるかどうかを検出
        isPlayerNear = IsPlayerNear();

        // エンターキーが押されたら白い画面を表示
        if (isPlayerNear && Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(FlashWhiteScreen());
        }
    }

    bool IsPlayerNear()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        // プレイヤーオブジェクトが存在しない場合はプレイヤーは近くにいないと判定
        if (player == null)
        {
            //ちなみにtagは使ってないから多分一生このif文起動しない。変数に入れたオブジェで判定してる。
            //これで黄色出せるんだー
            Debug.LogWarning("プレイヤーオブジェクトが見つかりませんでした。");
            return false;
        }

        // プレイヤーとの距離が検出半径以内かどうかを判定
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        return distanceToPlayer <= detectionRadius;
        // "Player"タグを持つオブジェクトを検索
    }

    System.Collections.IEnumerator FlashWhiteScreen()
    {
        // 白い画面を表示
        Camera.main.backgroundColor = flashColor;

        // 一定時間待ってから元の色に戻す
        yield return new WaitForSeconds(flashDuration);

        // 元の色に戻す
        Camera.main.backgroundColor = Color.black; // または適切な背景色に変更
    }
}
