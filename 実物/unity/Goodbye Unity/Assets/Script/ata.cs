using UnityEngine;
using System;
using System.Collections.Generic;
public class Aitem
{
    public string name;
    public string exem;
    public Sprite sp;

    public Aitem(string nam, string exe,Sprite stp)
    {
        name = nam;
        exem = exe;
        sp = stp;
    }
}
public class ata : MonoBehaviour
{
    [SerializeField] private GameObject map;
    [SerializeField] private story st;
    public float detectionDistance = 10f; // レイキャストの距離
    public List<Aitem> items = new List<Aitem>();



    void Update()
    {

        // 操作するオブジェクトの前方の方向を取得
        Vector3 direction = transform.forward;

        // レイキャストを実行
        RaycastHit hit;
        Ray ray = new Ray(transform.position, direction);

        if (Physics.Raycast(ray, out hit, detectionDistance))//←このIf分の中にアイテムゲットの処理を書いてる
        {
            //Debug.DrawRay(ray.origin, hit.point, Color.red);
            // レイキャストが何かに当たった場合の処理
            GameObject hitObject = hit.collider.gameObject;
            if (hitObject == map)
            {
                Debug.Log("ここのろ地図");
                st.map_flg();
            }
            if (Input.GetKeyDown(KeyCode.Return))//アイテム取得ボタン押したとき※Returnはエンターキーを示す
            {
                Debug.Log("Hit object: " + hitObject.name);//←アイテム取得した時に実行されるプログラム
                key script = hitObject.GetComponent<key>();
                if (script != null)
                {
                    if (script.getflg())
                    {
                        Aitem ii = new Aitem(script.strname, script.exem,script.sp);
                        items.Add(ii);
                    }
                }
                inkey scr = hitObject.GetComponent<inkey>();
                if (scr != null)
                {
                    scr.open();
                }
            }
        }

    }
}

