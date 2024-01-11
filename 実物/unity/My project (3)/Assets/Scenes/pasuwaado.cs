using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class pasuwado : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas serihu;
    public Material aka;
    public Material ao;
    public Material ki;
    public Material midori;
    public GameObject reba1;
    public GameObject reba2;
    public GameObject reba3;
    public GameObject reba4;
    public GameObject reba5;
    public GameObject reba6;
    public int ikkai1,ikkai2,ikkai3,ikkai4,on,itidodake,on1,on2,on3,on4,on5,on6,owari;
    public Text reba_hiku;
    private Story s;
    private sound oto;

    void Start()
    {
        s = FindObjectOfType<Story>();
        oto= FindObjectOfType<sound>();
    }

    // Update is called once per frame
    void Update()
    {      if(s.storykaunnto==3&&on1==1&&on2==3&&on3==1&&on4==3&&on5==0&&on6==0)
        {
            s.serihuokuru=1;
            s.storykaunnto=owari;
            
        }

        if(1<=on&&on<=6&&itidodake==0)//スイッチの前に立っているとき
        {
            itidodake=1;
            reba_hiku.gameObject.SetActive(!reba_hiku.gameObject.activeSelf);//Qキーでスイッチを引く、っと画面に表示するプログラム
        }
        if(s.storykaunnto==owari)reba_hiku.enabled=false;
        if(Input.GetKeyDown(KeyCode.Q)&&itidodake==1&&serihu.enabled == false)//スイッチの前に立っているときにスイッチを押したら
            {
                oto.Koukaonn3();
                if(on==1)//スイッチが1の時
                {
                    ikkai1=0;
                    reba1_on();
                    
                }
                if(on==2)//スイッチが2の時
                {
                    ikkai2=0;
                    reba2_on();
                  
                }
                if(on==3)//スイッチが3の時
                {
                    ikkai3=0;
                    reba3_on();
                   
                }
                if(on==4)//スイッチが4の時
                {
                    ikkai4=0;
                    reba4_on();
                 
                }
                
            }
        
    }
    void reba1_on()//スイッチを引いたとき
    {
        on1+=1;//1
        if (on1==4)on1=0;
        reba1.transform.Rotate(Vector3.up, 90.0f);
    }
    void reba2_on()//スイッチを引いたとき
    {
        on2+=1;//3
        if (on2==4)on2=0;
        reba2.transform.Rotate(Vector3.up, 90.0f);
    }
    void reba3_on()//スイッチを引いたとき
    {
        on3+=1;//1
        if (on3==4)on3=0;
        reba3.transform.Rotate(Vector3.up, 90.0f);
    }
    void reba4_on()//スイッチ４を引いたとき
    {
        on4+=1;//3
        if (on4==4)on4=0;
        reba4.transform.Rotate(Vector3.up, 90.0f);
    }
        void reba5_on()//スイッチ５を引いたとき
    {
        on5+=1;
        if (on4==4)on4=0;
        reba5.transform.Rotate(Vector3.up, 90.0f);
    }
        void reba6_on()//スイッチ６を引いたとき
    {
        on6+=1;
        if (on4==4)on4=0;
        reba6.transform.Rotate(Vector3.up, 90.0f);
    }
    void OnCollisionEnter(Collision collision)//スイッチでぶつかったとき
        {
            if(collision.gameObject.CompareTag("1_pass")&&s.storykaunnto==3)//ストーリー３のところのパスワードだったら
        {
            if (collision.gameObject.name == "irigutipas_reba1")on=1;
            if (collision.gameObject.name == "irigutipas_reba2")on=2;
            if (collision.gameObject.name == "irigutipas_reba3")on=3;
            if (collision.gameObject.name == "irigutipas_reba4")on=4;
        }
        }    
         private void OnCollisionExit(Collision collision)//スイッチ前から離れたときに反応する関数
     {
    if (collision.gameObject.CompareTag("1_pass"))
    {
        reba_hiku.gameObject.SetActive(!reba_hiku.gameObject.activeSelf);//スイッチの前に立った時に画面に表示される表記消す
        on=0;
        itidodake=0;
        s.susumiseigyo=0;//ストーリー進めないときに着ける
    }        
    }
}
