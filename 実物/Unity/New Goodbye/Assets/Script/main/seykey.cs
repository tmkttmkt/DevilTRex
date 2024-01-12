using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seykey : MonoBehaviour
{
    [SerializeField] public string sey = "設定されていないセリフ";
    public GameObject plyerrr;
    [SerializeField] public bool flg=false;
    float detectionRadius=3f;
    void start()
    {

    }
    void Update()
    {
        if (flg)
        {
            if (IsPlayerNear())
            {

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
