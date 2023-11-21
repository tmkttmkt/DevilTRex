using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pasward : MonoBehaviour
{
    [SerializeField] GameObject pass1;
    public GameObject plyerrr;
    float detectionRadius = 5f;
    bool pass_flg=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (IsPlayerNear() && Input.GetKeyDown(KeyCode.G))
        {
            pass_flg = true;
            pass1.SetActive(pass_flg);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
           
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
