using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using System.IO;
using System.Text;
public class teki : MonoBehaviour
{
    [SerializeField]time rast;
    public NavMeshAgent nav;
    [SerializeField]idou_mause target;
    public AudioSource mus;
    [SerializeField] Vector3[] vectors;
    int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        nav = gameObject.GetComponent<NavMeshAgent>();
        mus = gameObject.GetComponent<AudioSource>();

        using (StreamWriter writer = new StreamWriter("dbg.txt", true))
        {
            writer.WriteLine("てきスタート");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            float dis = Vector3.Distance(this.transform.position, target.transform.position);
            RaycastHit hit;
            Physics.Raycast(this.transform.position, target.transform.position - this.transform.position, out hit);
            GameObject hitObject = hit.collider.gameObject;
            //Debug.Log("距離 : " + dis +"__"+ hitObject);
            if (target.name == hitObject.name && dis <= 30f) {
                if (!target.tai.flg) {
                    nav.SetDestination(target.transform.position);
                    mus.Play();
                }

            }
            else
            {
                //Debug.Log(nav.SetDestination(vectors[num]));
                if (!nav.pathPending && nav.remainingDistance <= nav.stoppingDistance)
                {
                    num++;
                    if (num == 4) num = 0;
                }
            }
        }
        else Debug.Log("ngo");
        //Debug.Log(nav.destination);
    }
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject);
        if (collision.gameObject.name == target.name)
        {
            Debug.Log("Hit");// ログを表示する
            rast.flg_eat();//;
        }

    }
}