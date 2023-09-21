using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inkey : MonoBehaviour
{
    Vector3 targetPosition = new Vector3(28, 19, -46);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime);

    }
    public void open()
    {
        targetPosition = new Vector3(24, 19, -46);
        Debug.Log("aa");
    }
}
