using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kabe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(var i = 0; i < 5; i++)
        {
            transform.position -= new Vector3(0, 0, 1) * Time.deltaTime;
        }
    }
}
