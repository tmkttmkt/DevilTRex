using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame : MonoBehaviour
{
    public float detectionRadius = 10f; // プレイヤーを検出する半径
    public Color flashColor = Color.white; // 白い画面の色
    public float flashDuration = 1f; // 白い画面が表示される時間
    public GameObject plyerrr;
    private bool isPlayerNear = false;
    public Canvas canvas;
    void Update()
    {
        // プレイヤーの近くにいるかどうかを検出
        isPlayerNear = IsPlayerNear();
        Debug.Log(isPlayerNear);
        // エンターキーが押されたら白い画面を表示
        if (isPlayerNear == true)
        {
           FlashWhiteScreen();
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
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        // Image（四角形）を作成してCanvasに追加
        GameObject squareObject = new GameObject("WhiteSquare");
        squareObject.transform.SetParent(canvasObject.transform);
        RectTransform rectTransform = squareObject.AddComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(200, 200); // 四角形のサイズを設定

        Image image = squareObject.AddComponent<Image>();
        image.color = Color.white; // 白い色を設定
    }
}
