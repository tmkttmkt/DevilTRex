using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inkey : MonoBehaviour
{
    [SerializeField] Vector3 startPosition = new Vector3(28, 19, -46);
    [SerializeField] Vector3 iventPosition = new Vector3(24, 19, -46);
    Vector3 targetPosition;
    public string name;
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime);

    }
    public void open()
    {
        targetPosition = iventPosition;
        Debug.Log("aa");
    }
}
