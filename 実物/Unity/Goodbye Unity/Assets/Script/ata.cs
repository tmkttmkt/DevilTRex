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
    [SerializeField] private key nandakke;
    [SerializeField] private story st;
    [SerializeField] private time ti;
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
                    if(script== nandakke)st.denngonn_flg();
                    if (script.getflg())
                    {
                        Aitem ii = new Aitem(script.ID, script.exem,script.sp);
                        items.Add(ii);
                        ti.set_text(script.strname + "を手に入れた");
                        if (kensaku("mm", "hon")) st.key_flg();
                    }
                }
                inkey scr = hitObject.GetComponent<inkey>();
                if (scr != null)
                {
                    if (st.iventID == 6)
                    {
                        scr.open();
                        st.syeruta_flg();
                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.G))gousei();

    }
    void gousei()
    {
        List<String> it = new List<String>();

        foreach(Aitem ai in items)
        {
            it.Add(ai.name);
        }
        bool moti_flg = it.Contains("mm");
        bool hon_flg = it.Contains("hon");
        if (moti_flg&& hon_flg)
        {
            Aitem a=null;
            Aitem b = null;
            foreach (Aitem ai in items)
            {
                if (ai.name == "mm") a = ai;
                if (ai.name == "hon") b = ai;
            }
            if(a!=null)items.Remove(a);
            if (b != null)items.Remove(b);
            Aitem ii = new Aitem("kan","生きてます", Resources.Load<Sprite>("シェルターのカギ"));
            items.Add(ii);
        }
    }
    bool kensaku(string txt2, string txt1)
    {
        List<String> it = new List<String>();

        foreach (Aitem ai in items)
        {
            it.Add(ai.name);
        }
        bool moti_flg = it.Contains(txt2);
        bool hon_flg = it.Contains(txt1);
        return moti_flg && hon_flg;
    }
}

