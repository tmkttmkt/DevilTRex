using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
public class zyunni : MonoBehaviour
{
    // Start is called before the first frame update
    public int basyo,car=0,car1,car2,car3,car4,i;
     int[] naraberu=new int[5];
     public Text syu1,kyo1,syu2,kyo2,syu3,kyo3,syu4,kyo4,syu5,kyo5;
     string[] zyu=new string[5];
    void Start()
    {
        
    }

    // Update is called once per frame




    

    void Update()
    {  

    }

       
        
       /* if(car>car1&&car>car2&&car>car3&&car>car4)
        {
         Debug.Log("1位");
         }
        if(car<car1&&car>car2&&car>car3&&car>car4)
        {
         Debug.Log("2位");
         }
        if(car>car1&&car<car2&&car>car3&&car>car4)
        {
         Debug.Log("2位");
         }
        if(car>car1&&car>car2&&car<car3&&car>car4)
        {
         Debug.Log("2位");
         }
        if(car>car1&&car>car2&&car>car3&&car<car4)
        {
         Debug.Log("2位");
         }
        if(car<car1&&car<car2&&car>car3&&car>car4)
        {
         Debug.Log("3位");
         }
        if(car<car1&&car>car2&&car<car3&&car>car4)
        {
         Debug.Log("3位");
         }
        if(car<car1&&car>car2&&car>car3&&car<car4)
        {
         Debug.Log("3位");
         }
        if(car>car1&&car<car2&&car<car3&&car>car4)
        {
         Debug.Log("3位");
         }
        if(car>car1&&car<car2&&car>car3&&car<car4)
        {
         Debug.Log("3位");
         }
        if(car>car1&&car>car2&&car<car3&&car<car4)
        {
         Debug.Log("3位");
         }
        if(car<car1&&car<car2&&car<car3&&car>car4)
        {
         Debug.Log("4位");
         }
        if(car<car1&&car<car2&&car>car3&&car<car4)
        {
         Debug.Log("4位");
         }
       if(car<car1&&car>car2&&car<car3&&car<car4)
        {
         Debug.Log("4位");
         }
        if(car>car1&&car<car2&&car<car3&&car<car4)
        {
         Debug.Log("4位");
         }
        if(car<car1&&car<car2&&car<car3&&car<car4)
        {
         Debug.Log("5位");
         }*/
         
       
    

    void OnTriggerEnter(Collider collision)
    
    {
        if(this.gameObject.name == "Car1")
        {
            if (int.TryParse(collision.gameObject.name, out basyo))
            {
                // intValue は現在 int 型の数値 1 を持っています
                basyo=int.Parse(collision.gameObject.name);
                //Debug.Log("車１番 " + basyo);
                kyo2.text=collision.gameObject.name;
                car1= basyo;
          
            }
            else
            {
              //  Debug.Log("変換できませんでした。");
            }
        }
        if(this.gameObject.name == "Car2")
        {
            if (int.TryParse(collision.gameObject.name, out basyo))
            {
                // intValue は現在 int 型の数値 1 を持っています
                basyo=int.Parse(collision.gameObject.name);
                //Debug.Log("車２番 " + basyo);
                car2= basyo;
                kyo3.text=collision.gameObject.name;
            }
            else
            {
                //Debug.Log("変換できませんでした。");
            }
        }
                if(this.gameObject.name == "Car3")
        {
            if (int.TryParse(collision.gameObject.name, out basyo))
            {
                // intValue は現在 int 型の数値 1 を持っています
                basyo=int.Parse(collision.gameObject.name);
                //Debug.Log("車３番 " + basyo);
                car3= basyo;
                kyo4.text=collision.gameObject.name;
            }
            else
            {
                //Debug.Log("変換できませんでした。");
            }
        }
        if(this.gameObject.name == "Car4")
        {
            if (int.TryParse(collision.gameObject.name, out basyo))
            {
                // intValue は現在 int 型の数値 1 を持っています
                basyo=int.Parse(collision.gameObject.name);
                //Debug.Log("車４番 " + basyo);
                car4= basyo;
                kyo5.text=collision.gameObject.name;
            }
            else
            {
               // Debug.Log("変換できませんでした。");
            }
        }
                if(this.gameObject.name == "Car")
        {
            if (int.TryParse(collision.gameObject.name, out basyo))
            {
                // intValue は現在 int 型の数値 1 を持っています
                basyo=int.Parse(collision.gameObject.name);
                //Debug.Log("自分 " + basyo);
                car= basyo;
                kyo1.text=collision.gameObject.name;
            }
            else
            {
                //.Log("変換できませんでした。");
            }
        }
    }

}