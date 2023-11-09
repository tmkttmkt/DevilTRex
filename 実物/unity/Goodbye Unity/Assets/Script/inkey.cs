using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inkey : MonoBehaviour
{
    [SerializeField] Vector3 startPosition = new Vector3(28, 19, -46);
    [SerializeField] Vector3 targetPosition = new Vector3(28, 19, -46);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, startPosition, Time.deltaTime);

    }
    public void open()
    {
        startPosition = targetPosition;
        Debug.Log("aa");
    }
}
