using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [SerializeField] ata obj;
    // Start is called before the first frame update
    [SerializeField] GameObject item;
    [SerializeField] Text[] texts = new Text[3];
    [SerializeField] Image[] images = new Image[3];
    void Start()
    {
        item.gameObject.SetActive(flg_item);
    }

    // Update is called once per frame
    bool flg_item = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))//GetKeyDownで押したときに1回動作
        {
            int n;
            for (n = 0; n < 3; n++)
            {
                texts[n].text = "";
                images[n].sprite = Resources.Load<Sprite>("teki");
            }
            n = 0;
            foreach (Aitem ai in obj.items)
            {
                texts[n].text = ai.exem;
                //images[n].sprite= ai.image;
                n++;
            }

            flg_item = !flg_item;
            item.gameObject.SetActive(flg_item);
        }


    }
}
