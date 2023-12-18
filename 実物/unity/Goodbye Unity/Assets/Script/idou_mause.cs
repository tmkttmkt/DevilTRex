using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idou_mause : MonoBehaviour
{
    public rokka tai;
    private read read_obj;
    bool vis_flg = false;
    // Start is called before the first frame update
    void Start()
    {
        read_obj = FindObjectOfType<read>();
        //Debug.Log("aaaa");
        Cursor.visible = vis_flg;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    float speed = 10.0f;
    public bool flg_rok = true;
    private bool start = true;

    void Update()
    {
        if (start)
        {
            speed=read_obj.stetting["speed"];
            start = false;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
//exeじゃなくても閉じるため
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (vis_flg)
            {
                //Debug.Log("kes");
                vis_flg =!vis_flg;
                Cursor.visible = vis_flg;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                //Debug.Log("hyouzi");
                vis_flg = !vis_flg;
                Cursor.visible = vis_flg;
                Cursor.lockState = CursorLockMode.None;
            }
        }

        // Wキー（前方移動）

        if (!vis_flg)
        {
            //マウス移動
            float mouseX = Input.GetAxis("Mouse X");
            transform.Rotate(Vector3.up, mouseX * 500f * Time.deltaTime);

        }
        if (!vis_flg && !tai.flg)
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
        /*
        if (Input.GetKeyDown(KeyCode.R)){
            if (transform.eulerAngles.x >= 80 || transform.eulerAngles.z >= 80)
            {
                transform.eulerAngles = new Vector3(0f, transform.rotation.y, 0f);
                transform.position += new Vector3(0, 0.1f, 0);
            }
        }*/

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        Debug.Log(tai.move_rok);
        //OnCollisionEnter
        if (tai!=null && other.gameObject!=null ) {
            if (other.gameObject.name == tai.move_rok.name && flg_rok)
            {
                tai.move_rok.set(false);
                Debug.Log("wad");
                flg_rok = false;
            }
        }
    }

}
