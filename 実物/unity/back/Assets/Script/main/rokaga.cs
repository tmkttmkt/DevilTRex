using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rokaga : MonoBehaviour
{
    public GameObject sima;
    public GameObject hira;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
     public void set(bool flg)
    {
        sima.SetActive(!flg);
        hira.SetActive(flg);
       }
}
