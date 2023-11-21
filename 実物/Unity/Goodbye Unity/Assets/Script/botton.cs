using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botton : MonoBehaviour
{
    [SerializeField] Text text;
    public int suuzi=0;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onClick()
    {
        Debug.Log("afshfgyauiufdafdyadwatfwdtfwtfatrdftwadfu7tf");
        suuzi += 1;
        if (suuzi == 10)
        {
            suuzi = 0;
        }
        text.text = suuzi.ToString();
    }

}
