using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idou_mause : MonoBehaviour
{
    public rokka tai;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("aaaa");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    float speed = 3.0f;
    bool flg_e = true;//押せる状態のときに信
    public bool flg_rok = true;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
//exeじゃなくても閉じるため
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
        bool input_E = Input.GetKey(KeyCode.E);
        if (input_E && flg_e)
        {
            flg_e = false;
            if (Cursor.visible)
            {
                //Debug.Log("kes");
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                //Debug.Log("hyouzi");
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
        else if (!input_E && !flg_e) { flg_e = true; }
        // Wキー（前方移動）

        if (!Cursor.visible)
        {
            //マウス移動
            float mouseX = Input.GetAxis("Mouse X");
            transform.Rotate(Vector3.up, mouseX * 500f * Time.deltaTime);

        }
        if (!Cursor.visible && !tai.flg)
        {
            flg_rok = true;
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += speed * transform.forward * Time.deltaTime;
            }

            // Sキー（後方移動）
            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= speed * transform.forward * Time.deltaTime;
            }

            // Dキー（右移動）
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += speed * transform.right * Time.deltaTime;
            }

            // Aキー（左移動）
            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= speed * transform.right * Time.deltaTime;
            }

        }
        else if(tai.flg && flg_rok)
        {
            float interpolatedValue = (Time.time - tai.startTime) / tai.distance;
            //球面線形移動
            transform.position = Vector3.Slerp(transform.position, tai.move_rok.transform.position, interpolatedValue);

        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == tai.move_rok)
        {
            flg_rok = false;
        }
    }
}
