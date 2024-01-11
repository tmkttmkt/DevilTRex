using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starta: MonoBehaviour
{
    public Canvas main4;
    public Canvas item4;
    public Canvas serihu4;
    // Start is called before the first frame update
    public int width; // 解像度の幅
    public int height; // 解像度の高さ
    void Start()
    {
        Screen.SetResolution(width, height, true);
        main4.enabled = true;
        item4.enabled = false;
        serihu4.enabled = false;
    }

    // Update is called once per frame

}
