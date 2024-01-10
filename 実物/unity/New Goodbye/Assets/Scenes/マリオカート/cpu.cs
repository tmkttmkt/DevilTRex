using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpu : MonoBehaviour
{
    // Start is called before the first frame update
    private int muki=1,random;
    private reesu re;
    private Movecar m;
    private float speed=1;
    void Start()
    {
        re=FindAnyObjectByType<reesu>();
        m=FindAnyObjectByType<Movecar>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(re.start==1)transform.position-=transform.forward/speed;
    }
    void OnCollisionEnter(Collision collision)//何かと当たったらはんのうする関数、当たり判定決めるのに扱う
    {
        
        if (collision.gameObject.CompareTag("heya1"))
        {
            speed = Random.Range(0.5f, 1.5f);
            random=Random.Range(0,10);
            if(collision.gameObject.name=="carb1")transform.rotation = Quaternion.Euler(0f, -45f, 0f);
            if(collision.gameObject.name=="carb2")transform.rotation = Quaternion.Euler(0f, 5f, 0f);
            if(collision.gameObject.name=="carb3")transform.rotation = Quaternion.Euler(0f, -47f, 0f);
            if(collision.gameObject.name=="carb4")transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            if(collision.gameObject.name=="carb4_2")
            {
                if(random>=5)transform.rotation = Quaternion.Euler(0f, -40f, 0f);
                if(random<5)transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            }
            if(collision.gameObject.name=="carb4_3")transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            if(collision.gameObject.name=="carb4_4")transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            if(collision.gameObject.name=="carb4_5")transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            if(collision.gameObject.name=="carb5")transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            if(collision.gameObject.name=="carb6")transform.rotation = Quaternion.Euler(0f, 135f, 0f);
            if(collision.gameObject.name=="carb7")transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            if(collision.gameObject.name=="carb8")
            {
                if(random>=5)transform.rotation = Quaternion.Euler(0f, 135f, 0f);
                if(random<5)transform.rotation = Quaternion.Euler(0f, 225f, 0f);
            }
            if(collision.gameObject.name=="carb9")transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            if(collision.gameObject.name=="carb9_2")transform.rotation = Quaternion.Euler(0f, 135f, 0f);
            if(collision.gameObject.name=="carb10")transform.rotation = Quaternion.Euler(0f, 225f, 0f);
            if(collision.gameObject.name=="carb11")transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            if(collision.gameObject.name=="carb12")transform.rotation = Quaternion.Euler(0f, 135f, 0f);
            if(collision.gameObject.name=="carb13")transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            if(collision.gameObject.name=="carb14")transform.rotation = Quaternion.Euler(0f, 45f, 0f);
            if(collision.gameObject.name=="carb15")transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
}
