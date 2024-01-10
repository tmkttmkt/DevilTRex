using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
   ata at;
    // Start is called before the first frame update
    [SerializeField] GameObject item;
    [SerializeField] Text[] texts = new Text[3];
    [SerializeField] Image[] images = new Image[3];
    [SerializeField] Image kar;
    int m = 0;
    int mo = 0;
    float st;
    void Start()
    {
        st = kar.rectTransform.position.y + kar.rectTransform.sizeDelta.y / 2;
        at = FindObjectOfType<ata>();
        item.gameObject.SetActive(flg_item);
    }

    // Update is called once per frame
    bool flg_item = false;
    void Update()
    {
        if (mouse_chec()) hyouz();
        //Debug.Log(mo.ToString() + "口");
        kar.rectTransform.sizeDelta = new Vector2(10f, 240f / (at.items.Count <= 3 ? 1f : at.items.Count / 3f));
        kar.rectTransform.position = new Vector3(kar.rectTransform.position.x, st - kar.rectTransform.sizeDelta.y / 2- (kar.rectTransform.sizeDelta.y*m/3), kar.rectTransform.position.z);
        if (Input.GetKeyDown(KeyCode.L))
        {
            at.add_list(new Aitem("key",mo.ToString()+"出口", Resources.Load<Sprite>("出口の本体")), mo.ToString() + "出口");
            mo += 1;
            gousei_flg();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            hyouz();
            flg_item = !flg_item;
            item.gameObject.SetActive(flg_item);
        }



    }
    public void gousei_flg()
    {
        hyouz();

    }
    void hyouz()
    {
        int n;
        for (n = 0; n < 3; n++)
        {
            texts[n].text = "";
            images[n].sprite = Resources.Load<Sprite>("teki");
        }
        n = -1;
        foreach (Aitem ai in at.items)
        {
            n++;
            if (n < m) continue;
            if (n - m == 3) break;
            texts[n-m].text = ai.exem;
            images[n-m].sprite = ai.sp;
        }


    }
    bool mouse_chec()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            m--;
            if (m == -1) m = 0;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            m++;
            if (m > at.items.Count - 3) m--;
        }
        else return false;
        return true;
    }
}
