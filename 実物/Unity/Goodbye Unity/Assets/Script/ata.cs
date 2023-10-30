using UnityEngine;
using System;
using System.Collections.Generic;
public class Aitem
{
    public string name;
    public string exem;
    public Sprite image;

    public Aitem(string nam, string exe, Sprite ima)
    {
        name = nam;
        exem = exe;
        image = ima;
    }
}
public class kagi:Aitem
{
    public kagi(string nam, string exe,Sprite ima) : base(nam,exe,ima)
    {
        name = nam;
        exem = exe;
        image = ima;
    }
}
public class ata : MonoBehaviour
{
    public float detectionDistance = 10f; // レイキャストの距離
    public List<Aitem> items = new List<Aitem>();



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))//アイテム取得ボタン押したとき※Returnはエンターキーを示す
        {
            // 操作するオブジェクトの前方の方向を取得
            Vector3 direction = transform.forward;

            // レイキャストを実行
            RaycastHit hit;
            Debug.Log(items.Count);
            Ray ray = new Ray(transform.position, direction);

            if (Physics.Raycast(ray, out hit, detectionDistance))//←このIf分の中にアイテムゲットの処理を書いてる
            {
                //Debug.DrawRay(ray.origin, hit.point, Color.red);
                // レイキャストが何かに当たった場合の処理
                GameObject hitObject = hit.collider.gameObject;
                Debug.Log("Hit object: " + hitObject.name);//←アイテム取得した時に実行されるプログラム

                key script = hitObject.GetComponent<key>();
                if (script != null)
                {
                    if (items.Count <= 3)
                    {
                        if (script.getflg())
                        {
                            Aitem ii = new Aitem(script.strname, script.exem,script.sp);
                            items.Add(ii);
                        }
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

