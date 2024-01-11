using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class Movecar : MonoBehaviour
{
    private reesu re;
    // Start is called before the first frame update
    public float i=0.0f,ii=0.5f;
    void Start()
    {
        re=FindObjectOfType<reesu>();
    }

    // Update is called once per frame
    void Update()
    {
            if(Input.GetKey(KeyCode.W)&&re.start==1)//スタートしてから走れるように
            {
                transform.position-=transform.forward;
            }
            if(Input.GetKey(KeyCode.A)&&re.start==1)
            {
                i-=2f;
                transform.rotation = Quaternion.Euler(0f, i, 0f);
            }
            if(Input.GetKey(KeyCode.D)&&re.start==1)
            {
                i+=2f;
                transform.rotation = Quaternion.Euler(0f, i, 0f);
            }
            if(Input.GetKey(KeyCode.S)&&re.start==1)//スタートしてから走れるように
            {
                transform.position+=transform.forward/12;
            }
    }
}
