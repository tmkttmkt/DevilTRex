using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kennkyuusya : MonoBehaviour
{
    // Start is called before the first frame update
    private Story s;
    public int story;
    public Vector3 newPosition; // 移動先の座標
    private serihu2 serihu;
    public int dannraku;
    void Start()
    {
        s=FindAnyObjectByType<Story>();
        serihu=FindAnyObjectByType<serihu2>();
    }

    // Update is called once per frame
    void Update()
    { 
        if((s.storykaunnto==story&&serihu.dannraku==dannraku)||s.storykaunnto==(story+1))
        {
            transform.position = newPosition;
        }
    }
}
