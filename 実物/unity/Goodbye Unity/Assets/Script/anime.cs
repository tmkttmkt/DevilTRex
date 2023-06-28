using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anime : MonoBehaviour
{
    private Animator anim;  //Animatorをanimという変数で定義する

    //===== 初期処理 =====
    void Start()
    {
        //変数animに、Animatorコンポーネントを設定する
        anim = gameObject.GetComponent<Animator>();
        Debug.Log(anim);
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
    }
}
