using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class erebeitaa: MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas ere;
    private move m;
    public GameObject erebeta1,erebeta2,erebeta3;
    private Story s;
    private sound sou;
    void Start()
    {
        m=FindObjectOfType<move>();
        s=FindObjectOfType<Story>();
        sou=FindObjectOfType<sound>();
        m.move_onoff[7]=1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.D))
        {
            
            if(Input.GetKeyDown(KeyCode.A)&&m.move_onoff[2]!=1&&ere.enabled==true)
            {
                m.move_onoff[3]=1;
                erebeita_kesu();
                m.erebeta.enabled=true;
                sou.erebeta();
                m.move_onoff[7]=0;
            }
            if(Input.GetKeyDown(KeyCode.S)&&m.move_onoff[2]!=2&&ere.enabled==true)
            {
                m.move_onoff[3]=2;
                erebeita_kesu();
                m.erebeta.enabled=true;
                sou.erebeta();
                m.move_onoff[7]=0;
            }
            if(Input.GetKeyDown(KeyCode.D)&&m.move_onoff[2]!=3&&ere.enabled==true)
            {
                m.move_onoff[3]=3;
                erebeita_kesu();
                m.erebeta.enabled=true;
                sou.erebeta();
                m.move_onoff[7]=0;
            }
        }
    }
    public void erebeita()//エレベーターキャンバス付ける
    {
        ere.enabled=true;
    }
    public void erebeita_kesu()//エレベーターキャンバス付ける
    {
        ere.enabled=false;
        erebeta1.SetActive(false);
        erebeta2.SetActive(false);
        erebeta3.SetActive(false);
    }

}
