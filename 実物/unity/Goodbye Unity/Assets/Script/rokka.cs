using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rokka : MonoBehaviour
{
    public GameObject[] rokas;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            foreach (GameObject roka in rokas) { 
            float dis = Vector3.Distance(this.transform.position, roka.transform.position);
            Debug.Log("距離 : " + dis);
        }
        }
    }
}
