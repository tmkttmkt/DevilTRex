using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class teki : MonoBehaviour
{
    public NavMeshAgent nav;
    [SerializeField]idou_mause target;
    // Start is called before the first frame update
    void Start()
    {
        nav = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null )
        {
            if(!target.tai.flg)
            nav.destination = target.transform.position;
        }
        else Debug.Log("ngo");
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject ==target)
        {
            Debug.Log("Hit"); // ログを表示する
        }

    }
}