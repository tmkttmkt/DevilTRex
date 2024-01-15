using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class syujinnkou: MonoBehaviour
{

    Rigidbody rb;
    public int i=1,kanntuuseigyo=0;
    private serihu2 s;
    private ITEM item;
   private erebeitaa e;
   private move m;
   private Story st;
   private sound sou;
   private tatakai t;
    float msp = 0.9f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        s = FindObjectOfType<serihu2>();
        item =FindObjectOfType<ITEM>();
        t =FindObjectOfType<tatakai>();
        e =FindObjectOfType<erebeitaa>();
        m=FindObjectOfType<move>();
        st=FindObjectOfType<Story>();
        sou=FindObjectOfType<sound>();

       

    }
    void Update()
    {
        
        /*f(kanntuuseigyo==1)transform.position-=transform.right/10;
        if(kanntuuseigyo==2)transform.position+=transform.right/10;
        if (kanntuuseigyo==3)transform.position-=transform.forward/10;
        if (kanntuuseigyo==4)transform.position+=transform.forward/10;  
        if (kanntuuseigyo==5)transform.position+=transform.right/10;//右
        if (kanntuuseigyo==6)transform.position-=transform.right/10;//左
        if (kanntuuseigyo==7)transform.position+=transform.right/10;//右
        if (kanntuuseigyo==8)transform.position-=transform.right/10;//左
        */
        if(kanntuuseigyo==10)transform.position-=transform.forward/10; 
     
        if(i==0)//キーを押して移動する際のif文
        { 
            if (!t.gamegamenn.isActiveAndEnabled&&!s.serihucanvas.isActiveAndEnabled&&!item.Itemcanvas.isActiveAndEnabled&&!s.pasCanvas.isActiveAndEnabled&&m.arukanai==0)
            {
                if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
                {
                    transform.position += (transform.forward / 7) * Time.deltaTime * 80f;
                    //rb.AddForce(msp * ((transform.forward * rb.mass * 200 * rb.drag) - rb.velocity));
                }
                //rb.AddForce(-transform.up * 9.8f * 30 * rb.mass);
                //Debug.Log(msp * ((transform.forward * rb.mass * 30 * rb.drag) - rb.velocity));
            }
            else
            {
                sou.BGM_arukuoto2();
            }
            if((Input.GetKeyDown(KeyCode.LeftShift)||Input.GetKeyDown(KeyCode.RightShift))&&!t.gamegamenn.isActiveAndEnabled&&!s.serihucanvas.isActiveAndEnabled&&!item.Itemcanvas.isActiveAndEnabled&&!s.pasCanvas.isActiveAndEnabled&&m.arukanai==0)sou.BGM_arukuoto();
            /*    if (Input.GetKey(KeyCode.D)&&!Input.GetKey(KeyCode.A)&&!Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.W))transform.position+=transform.right/10;
                else if (Input.GetKey(KeyCode.A)&&!Input.GetKey(KeyCode.D)&&!Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.W))transform.position-=transform.right/10;
                else if (Input.GetKey(KeyCode.W)&&!Input.GetKey(KeyCode.A)&&!Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.D))transform.position+=transform.forward/10;
                else if (Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.A)&&!Input.GetKey(KeyCode.D)&&!Input.GetKey(KeyCode.W))transform.position-=transform.forward/10;  
                else if (Input.GetKey(KeyCode.W)&&Input.GetKey(KeyCode.A)&&!Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.D))transform.position-=transform.right/10;//左
                else if (!Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.A)&&Input.GetKey(KeyCode.D)&&Input.GetKey(KeyCode.W))transform.position+=transform.right/10;//右  
                else if (!Input.GetKey(KeyCode.W)&&Input.GetKey(KeyCode.A)&&Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.D))transform.position-=transform.right/10;//左
                else if (Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.A)&&Input.GetKey(KeyCode.D)&&!Input.GetKey(KeyCode.W))transform.position+=transform.right/10;//右 */
        }
      } 
    void OnCollisionEnter(Collision collision)//何かと当たったらはんのうする関数、当たり判定決めるのに扱う
    {
        /*if (!collision.gameObject.CompareTag("yuka"))
        {
            if (Input.GetKey(KeyCode.D)&&!Input.GetKey(KeyCode.A)&&!Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.W))kanntuuseigyo=1;//右に進んでぶつかった場合
            else if (Input.GetKey(KeyCode.A)&&!Input.GetKey(KeyCode.D)&&!Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.W))kanntuuseigyo=2;//左に進んでぶつかった場合
            else if (Input.GetKey(KeyCode.W)&&!Input.GetKey(KeyCode.A)&&!Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.D))kanntuuseigyo=3;//前に進んでぶつかった場合
            else if (Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.A)&&!Input.GetKey(KeyCode.D)&&!Input.GetKey(KeyCode.W))kanntuuseigyo=4;//後ろに進んでぶつかった場合
            else if (Input.GetKey(KeyCode.W)&&Input.GetKey(KeyCode.A)&&!Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.D))kanntuuseigyo=5;//左前に進んでぶつかった場合
            else if (!Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.A)&&Input.GetKey(KeyCode.D)&&Input.GetKey(KeyCode.W))kanntuuseigyo=6;//右前に進んでぶつかった場合
            else if (!Input.GetKey(KeyCode.W)&&Input.GetKey(KeyCode.A)&&Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.D))kanntuuseigyo=7;//左後ろに進んでぶつかった場合
            else if (Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.A)&&Input.GetKey(KeyCode.D)&&!Input.GetKey(KeyCode.W))kanntuuseigyo=8;//右後ろに進んでぶつかった場合
        }*/
               //if  (collision.gameObject.CompareTag("yuka"))ぶつかったら○○
             //   {
            //i=0;
        //}
    }
    private void OnCollisionExit(Collision collision)//離れたときに反応する関数
    {
        kanntuuseigyo=0;

    }


}
