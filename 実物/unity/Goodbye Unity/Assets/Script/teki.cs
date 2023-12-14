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
    public musi mus;
    [SerializeField] Vector3[] vectors;
    int num = 0;
    bool mus_flg = true;

    // Start is called before the first frame update
    void Start()
    {
        nav = gameObject.GetComponent<NavMeshAgent>();
        mus = FindObjectOfType<musi>();

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
                    Debug.Log("a1");
                    nav.SetDestination(target.transform.position);
                    
                }
                if (mus_flg)
                {
                    mus.teki_flg();
                    mus_flg = false;
                }

            }
            else
            {
                if(!mus_flg)mus.kihon_flg();
                mus_flg = true;
                Debug.Log("a2");
                //Debug.Log(nav.SetDestination(vectors[num]));
                nav.SetDestination(vectors[num]);
                if (!nav.pathPending && nav.remainingDistance <= nav.stoppingDistance)
                {
                    Debug.Log("a3");
                    num++;
                    if (num == vectors.Length) num = 0;
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