using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butukaru : MonoBehaviour
{
    private sound2 sou2;
    // Start is called before the first frame update
    void Start()
    {
        sou2=FindObjectOfType<sound2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Car"||collision.gameObject.name == "Car1"||collision.gameObject.name == "Car2"||collision.gameObject.name == "Car3"||collision.gameObject.name == "Car4")
        {
            sou2.butukaru_car();
        }
    }
}
