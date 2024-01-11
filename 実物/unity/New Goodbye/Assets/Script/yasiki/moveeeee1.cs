using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveeeee1 : MonoBehaviour
{
    // Start is called before the first frame update


private int i; 
    void Update()
    {
        i+=1;
        if(i>3000)i=0;
        if(i>1500)transform.position+=transform.right/50;
        if(i<=1500)transform.position-=transform.right/50;
        
        }
    
}
