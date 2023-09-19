using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] ata obj;
    // Start is called before the first frame update
    [SerializeField] GameObject item;
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
            flg_item = !flg_item;
            item.gameObject.SetActive(flg_item);
        }


    }
}
