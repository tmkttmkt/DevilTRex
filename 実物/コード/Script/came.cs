using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class came : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject target;

    void Start()
    {
        transform.position = target.gameObject.transform.position + new Vector3(0, 2, 0) - transform.forward;
        transform.SetParent(target.gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
