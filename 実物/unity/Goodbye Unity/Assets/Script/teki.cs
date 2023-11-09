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
    public AudioSource musi;
    // Start is called before the first frame update
    void Start()
    {
        nav = gameObject.GetComponent<NavMeshAgent>();

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
// musi.isPlaying;
            //musi.Play();
            float dis = Vector3.Distance(this.transform.position, target.transform.position);
            RaycastHit hit;
            Physics.Raycast(this.transform.position, target.transform.position - this.transform.position, out hit);
            GameObject hitObject = hit.collider.gameObject;
            //Debug.Log("距離 : " + dis +"__"+ hitObject);
            if (target.name == hitObject.name && dis <= 30f) {
                if (!target.tai.flg) nav.SetDestination(target.transform.position);
            }
        }
        else Debug.Log("ngo");
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