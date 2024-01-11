using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITEM2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Texture item;
    private int i=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "item")
        {
            
        }
    }
    }
