using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rokka : MonoBehaviour
{
    public GameObject[] rokas;
    internal GameObject move_rok;
    // Start is called before the first frame update
    internal bool flg = false;
    internal float startTime, distance;
    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!flg)
            {
                foreach (GameObject roka in rokas)
                {
                    float dis = Vector3.Distance(this.transform.position, roka.transform.position);
                    Debug.Log("距離 : " + dis + roka.name);
                    RaycastHit hit;
                    Physics.Raycast(this.transform.position, roka.transform.position - this.transform.position, out hit);

                    GameObject hitObject = hit.collider.gameObject;
                    float hitdis = Vector3.Distance(this.transform.position, hitObject.transform.position);
                    Debug.Log("一番近いやつ : " + hitObject.name);
                    if ((roka == hitObject && dis <= 10f) || (roka!=hitObject && dis<=hitdis &&  dis <= 10f))
                    {
                        Debug.Log("起動!");
                        flg = true;
                        move_rok = roka;
                        startTime = Time.time;
                        distance = Vector3.Distance(transform.position, move_rok.transform.position);
                    }
                    // 追加の処理を行います
                }
            }
            else
            {
                flg = false;
            }
        }
    }
}
