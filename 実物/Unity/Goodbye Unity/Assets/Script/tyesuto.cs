using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tyesuto : MonoBehaviour
{
    [SerializeField] reba reba1;
    [SerializeField] reba reba2;
    [SerializeField] reba reba3;
    [SerializeField] reba reba4;
    [SerializeField] GameObject futa;
    public GameObject plyerrr;
    public bool flg=true;
    float detectionRadius=5f;
    ata a;
    // Start is called before the first frame update
    void Start()
    {
        a = FindObjectOfType<ata>();

    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerNear() && Input.GetKeyDown(KeyCode.G))
        {
            if(reba1.flg && reba2.flg && reba3.flg && reba4.flg && flg)
            {
                flg =false;
                futa.transform.position += new Vector3(2.5f, 0.0f, 0.0f);
                futa.transform.eulerAngles += new Vector3(-50f, 0.0f, 0.0f);
                a.add_list(new Aitem("最後のカギh", "お前はすでに脱出に成功している\nhhhhh", Resources.Load<Sprite>("teki")));
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
    
}
