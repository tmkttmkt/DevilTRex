using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public string strname;
    public string exem;
    [SerializeField] public Sprite sp;
    private bool flg = true;
    // Start is called before the first frame update
    void Start()
    {
        sprite = Resources.Load<Sprite>("bag2");
        image = this.GetComponent<Image>();
        image.sprite = sprite;
    https://uni.gas.mixh.jp/unity/canvas-text-image.html
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
