using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storysyuuryou : MonoBehaviour
{
    public Vector3 newPosition; // 移動先の座標
    private Story s;
    public int story;
    void Start()
    {s= FindObjectOfType<Story>();}
    void Update()
    {
       if(s.storykaunnto==story)transform.position = newPosition;   // オブジェクトの位置を新しい座標に変更する
    }
}
