using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemkieru : MonoBehaviour
{
    public Vector3 dokohekieruka;
   // public string item_name;

    // Start is called before the first frame update
    private ITEM item;
    void Start()
    {
     //    item=FindObjectOfType<ITEM>();   
    }

    // Update is called once per frame
    void Update()
    {
    
        
        
       
        
    }
     void OnCollisionEnter(Collision collision)
     {

        transform.position = dokohekieruka;
     }
    
}
