using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class syuzink_ani : MonoBehaviour
{
    private Animator mae_anim;
    private Animator yoko_anim;  //Animatorをanimという変数で定義する
    [SerializeField] GameObject mae;
    [SerializeField] GameObject yoko;

    //===== 初期処理 =====
    void Start()
    {
        //変数animに、Animatorコンポーネントを設定する
        mae_anim = mae.GetComponent<Animator>();
        yoko_anim = yoko.GetComponent<Animator>();
    }

    //===== 主処理 =====
    void Update()
    {
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) )&& !Input.GetKey(KeyCode.W))
        {
            mae.SetActive(false);
            yoko.SetActive(true);
        }
        else if ((!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))|| Input.GetKey(KeyCode.W))
        {
            mae.SetActive(true);
            yoko.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            mae_anim.SetBool("TE", true);

        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            mae_anim.SetBool("TE", false);

        }
    }
}
