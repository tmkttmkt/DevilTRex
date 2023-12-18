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
    NavMeshAgent nav;
    ata target;
    idou_mause player;
    public musi mus;
    [SerializeField] Vector3[] vectors;
    int num = 0;
    bool mus_flg = true;

    // Start is called before the first frame update
    void Start()
    {
        nav = gameObject.GetComponent<NavMeshAgent>();
        player= FindObjectOfType<idou_mause>();
        mus = FindObjectOfType<musi>();
        target = FindObjectOfType<ata>();

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
            if (target.name == hitObject.name && dis <= 30f)
            {
                if (!player.tai.flg)
                {
                    if (mus_flg)
                    {
                        mus.teki_flg();
                        mus_flg = false;
                    }
                    //Debug.Log("a1");
                    nav.SetDestination(target.transform.position);

                }
                else return;
                return;

            }
            if(!mus_flg)mus.kihon_flg();
            mus_flg = true;
            //Debug.Log("a2");
            //Debug.Log(nav.SetDestination(vectors[num]));
            nav.SetDestination(vectors[num]);
            if (!nav.pathPending && nav.remainingDistance <= nav.stoppingDistance)
            {
                //Debug.Log("a3");
                num++;
                if (num == vectors.Length) num = 0;
            }
        }
        else Debug.Log("ngo");
    }
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject);
        if (collision.gameObject.name == player.name)
        {
            Debug.Log("Hit");// ログを表示する
            rast.flg_eat();//;
        }

    }
}