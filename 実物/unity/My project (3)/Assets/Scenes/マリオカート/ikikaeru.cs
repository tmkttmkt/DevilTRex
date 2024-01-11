using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ikikaeru : MonoBehaviour
{
    public Transform targetObject_1,targetObject_2,targetObject_3,targetObject_4,targetObject_5,targetObject_6,targetObject_7; // 同じ座標に移動させる対象のオブジェクト
    void OnCollisionEnter(Collision butukaru)
    {
        if(butukaru.gameObject.name=="yuka1")
        {
             Vector3 targetPosition = targetObject_1.position; // ターゲットオブジェクトの座標を取得
            transform.position = targetPosition; // キューブを同じ座標に移動させる
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
         if(butukaru.gameObject.name=="yuka2")
        {
             Vector3 targetPosition = targetObject_2.position; // ターゲットオブジェクトの座標を取得
            transform.position = targetPosition; // キューブを同じ座標に移動させる
            transform.rotation = Quaternion.Euler(0f, 5f, 0f);
        }
        if(butukaru.gameObject.name=="yuka3")
        {
             Vector3 targetPosition = targetObject_3.position; // ターゲットオブジェクトの座標を取得
            transform.position = targetPosition; // キューブを同じ座標に移動させる
            transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }
         if(butukaru.gameObject.name=="yuka4")
        {
             Vector3 targetPosition = targetObject_4.position; // ターゲットオブジェクトの座標を取得
            transform.position = targetPosition; // キューブを同じ座標に移動させる
            transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }
        if(butukaru.gameObject.name=="yuka5")
        {
             Vector3 targetPosition = targetObject_5.position; // ターゲットオブジェクトの座標を取得
            transform.position = targetPosition; // キューブを同じ座標に移動させる
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
         if(butukaru.gameObject.name=="yuka6")
        {
             Vector3 targetPosition = targetObject_6.position; // ターゲットオブジェクトの座標を取得
            transform.position = targetPosition; // キューブを同じ座標に移動させる
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        if(butukaru.gameObject.name=="yuka7")
        {
             Vector3 targetPosition = targetObject_7.position; // ターゲットオブジェクトの座標を取得
            transform.position = targetPosition; // キューブを同じ座標に移動させる
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
    }
    void Update()
    {
        
    }
}
