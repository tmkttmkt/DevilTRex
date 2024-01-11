using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveeeee : MonoBehaviour
{
    // Start is called before the first frame update




    float movementDistance = 5.0f; // 移動距離
    float timer = 0.0f; // タイマー
    private int i=0;

    void Update()
    {
        timer += Time.deltaTime; // 経過時間をタイマーに加算
        // 3秒ごとに左右に移動させる
        if (timer >= 1.0f)
        {
            // 左右に移動
            if(i==10)i=1;
            if(i<=5)transform.Translate(Vector3.left * movementDistance); // 左に移動
            timer = 0.0f; // タイマーをリセット
            i+=1;
            if(i>5)transform.Translate(Vector3.right * movementDistance); // 右に移動


        }
    }
}

