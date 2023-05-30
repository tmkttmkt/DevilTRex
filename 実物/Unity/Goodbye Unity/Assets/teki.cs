using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class teki : MonoBehaviour
{
    public NavMeshAgent player;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            player.destination = target.transform.position;
        }
        else Debug.Log("ngo");
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            Debug.Log("Hit"); // ログを表示する
        }

    }
}