using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botton : MonoBehaviour
{
    [SerializeField] Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick()
    {
        int suzi = int.Parse(text.text);

        suzi += 1;
        if (suzi == 10)
        {
            suzi = 0;
        }
        text.text = suzi.ToString();
    }

}
