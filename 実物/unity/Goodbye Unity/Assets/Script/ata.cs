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
    public float detectionDistance = 10f; // レイキャストの距離
    [SerializeField] public List<Aitem> items = new List<Aitem>();
    [SerializeField] int name = 110;



    private story st;
    private time ti;
    private Item it;
    private void Start()
    {
        it = FindObjectOfType<Item>();
        ti = FindObjectOfType<time>();
        st = FindObjectOfType<story>();
    }

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
                        if (kensaku("mo", "hon")) st.key_flg();
                    }
                }
                inkey scr = hitObject.GetComponent<inkey>();
                if (scr != null)
                {
                    if (scr.name == "kan")
                    {
                        List<String> it = mozilis();
                        if (it.Contains("kan"))
                        {
                            scr.open();
                            st.syeruta_flg();
                            del_list("kan");
                        }
                    }
                    else if (scr.name == "ras")
                    {
                        List<String> it = mozilis();
                        if (it.Contains("ras_kan"))
                        {
                            scr.open();
                            st.deguti_flg();
                            del_list("ras_kan");
                        }

                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            syeru_key_gousei();
            saisyu_key_gousei();
            it.gousei_flg();
        }

    }
    List<String>  mozilis()
    {
        List<String> it = new List<String>();
        foreach (Aitem ai in items)
        {
            it.Add(ai.name);
            Debug.Log(ai.name);
        }
        return it;
    }
    void syeru_key_gousei()
    {
        List<String> it = mozilis();


        bool moti_flg = it.Contains("mo");
        bool hon_flg = it.Contains("hon");
        if (moti_flg&& hon_flg)
        {
            Aitem a = null;
            Aitem b = null;
            foreach (Aitem ai in items)
            {
                if (ai.name == "mo") a = ai;
                if (ai.name == "hon") b = ai;
            }
            if(a!=null)items.Remove(a);
            if (b != null)items.Remove(b);
            Aitem ii = new Aitem("kan","この鍵を使えばシェルターを開けることができそうだ", Resources.Load<Sprite>("シェルターのカギ"));
            items.Add(ii);
            ti.set_text("鍵を手に入れた");
        }
    }
    void saisyu_key_gousei()
    {
        List<String> it = mozilis();


        bool key_flg = it.Contains("key");
        bool aron_flg = it.Contains("aron");
        bool motit_flg = it.Contains("motit");
        if (aron_flg && key_flg &&　motit_flg)
        {
            Aitem a = null;
            Aitem b = null;
            Aitem c = null;
            foreach (Aitem ai in items)
            {
                if (ai.name == "key") a = ai;
                if (ai.name == "aron") b = ai;
                if (ai.name == "motit") c = ai;
            }
            if (a != null) items.Remove(a);
            if (b != null) items.Remove(b);
            if (c != null) items.Remove(c);
            Aitem ii = new Aitem("ras_kan", "この鍵を持って、急いで出口に向かおう", Resources.Load<Sprite>("出口の鍵"));
            items.Add(ii);
            st.saigousei_flg();
            ti.set_text("鍵を手に入れた");
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
    bool kensaku(string txt2, string txt1, string txt3)
    {
        List<String> it = new List<String>();

        foreach (Aitem ai in items)
        {
            it.Add(ai.name);
        }
        bool flg1 = it.Contains(txt2);
        bool flg2 = it.Contains(txt1);
        bool flg3 = it.Contains(txt3);
        return flg2 && flg1 & flg3;
    }
    public void add_list(Aitem a)
    {
        items.Add(a);
        ti.set_text(a.name + "を手に入れた");
    }
    public void del_list(string nam)
    {
        Aitem a = null;
        foreach (Aitem ai in items)
        {
            if (ai.name == nam) a = ai;
        }
        if (a != null) items.Remove(a);

    }
}

