using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reba : MonoBehaviour
{
    public bool flg = true;
    public float detectionRadius=5f;
    [SerializeField] GameObject plyerrr;
    [SerializeField] Vector3 vv;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerNear() && Input.GetKeyDown(KeyCode.I))
        {
            flg = !flg;

            if (flg)
            {
                transform.eulerAngles += vv;
            }
            else
            {
                transform.eulerAngles -= vv;
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
