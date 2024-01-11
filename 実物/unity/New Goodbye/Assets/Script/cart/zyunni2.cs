using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private zyunni z;
    void Start()
    {
        z=FindAnyObjectByType<zyunni>();
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(z.car1);
       // Debug.Log(z.car2);
       // Debug.Log(z.car3);
        //Debug.Log(z.car4);
       // Debug.Log(z.car);
    }
}
