using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movecar : MonoBehaviour
{
    private reesu re;
    // Start is called before the first frame update
    public float i=0.0f,ii=0.5f;
    Rigidbody rb;
    float speed_mal = 1f;
    float speed = 0f;
    float a = 0.01f;// 移動速度の入力に対する追従度
    private float speed_tei = 0.2f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        re =FindObjectOfType<reesu>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (re.start == 1)
        {

            float mouseX = Input.GetAxis("Mouse X");
            transform.Rotate(Vector3.up, mouseX * 100f * Time.deltaTime);

            transform.position -= transform.forward * speed_tei * speed;
            rb.AddForce(transform.forward*speed_tei);
            if (Input.GetKey(KeyCode.W))//スタートしてから走れるように
            {
                if(speed<speed_mal) speed += a;
            }
            if (Input.GetKey(KeyCode.A))
            {
                i -= 2f;
                transform.rotation = Quaternion.Euler(0f, i, 0f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                i += 2f;
                transform.rotation = Quaternion.Euler(0f, i, 0f);
            }
            if (Input.GetKey(KeyCode.S))//スタートしてから走れるように
            {
                if (speed > -speed_mal/2) speed -= a/2;
            }
            if (speed > 0) speed -= a/6;
            if (speed < 0) speed += a/6;
        }
    }
}
