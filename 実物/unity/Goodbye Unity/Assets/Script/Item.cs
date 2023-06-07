using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject item2;
    void Start()
    {
        item2.gameObject.SetActive(item);
    }

    // Update is called once per frame
    bool item = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))//GetKeyDownで押したときに1回動作
        {
            item = !item;
            item2.gameObject.SetActive(item);
        }

       





    }
}
