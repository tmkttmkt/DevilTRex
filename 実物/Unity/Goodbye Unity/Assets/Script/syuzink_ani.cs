using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class syuzink_ani : MonoBehaviour
{
    private Animator anim;  //Animatorをanimという変数で定義する

    //===== 初期処理 =====
    void Start()
    {
        //変数animに、Animatorコンポーネントを設定する
        anim = gameObject.GetComponent<Animator>();
    }

    //===== 主処理 =====
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {

            anim.SetBool("TE",true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {

            anim.SetBool("TE", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {

            anim.SetBool("rl", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {

            anim.SetBool("rl", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {

            anim.SetBool("lf", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {

            anim.SetBool("lf", false);
        }
    }
}
