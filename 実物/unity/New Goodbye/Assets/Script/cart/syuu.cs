using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class syuu : MonoBehaviour
{
    // Start is called before the first frame update
    public Text syuume;
    private int nannsyuu=1;
    private int ok=0;
    private sound2 s;
    void Start()
    {
        s=FindFirstObjectByType<sound2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "goline")
        {
            if(ok==1)
            {
                s.p();
                nannsyuu+=1;
                syuume.text=nannsyuu.ToString();
                ok=0;
            }
        }
        if(collision.gameObject.name == "OK")
        {
            ok=1;
        }
    }
}
