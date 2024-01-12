using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sitenn : MonoBehaviour
{
    

    public float sensitivity = 5.0f; // 回転の感度
    public serihu2 s;
    private ITEM item;
    private tatakai t;
    

    // Start is called before the first frame update
    void Start()
    {
        s=FindObjectOfType<serihu2>();
        item=FindObjectOfType<ITEM>();
        t=FindObjectOfType<tatakai>();
        //  Cursor.lockState = CursorLockMode.Locked; // カーソルを画面内にロック
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;


    }

    // Update is called once per frame
    void Update()
    {
        if(s.pasCanvas.enabled==false&&!s.serihucanvas.isActiveAndEnabled&&!item.Itemcanvas.isActiveAndEnabled&&!t.gamegamenn.isActiveAndEnabled)
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            transform.Rotate(Vector3.up, mouseX, Space.World);
        }
        if(s.pasCanvas.enabled==true)
        {
            s.canvas.enabled=false;
            Cursor.visible = true; // マウスカーソルを表示する
        }
        if(s.pasCanvas.enabled==false)
        {
            Cursor.visible = false; // マウスカーソルを非表示する
        }
    } 
}

