using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public string ID;
    public string exem;
    public string strname;
    [SerializeField] public Sprite sp;
    private bool flg = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool getflg()
    {
        bool flg_box = flg;
        flg = false;
        return flg_box;
    }
}
