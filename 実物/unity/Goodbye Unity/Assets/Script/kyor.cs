using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kyor : MonoBehaviour
{
    public GameObject[] objectToHide=new GameObject[8];
    public GameObject ou;
    int n = 0;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<8;i++)
        objectToHide[i].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        n+=1;
        if (n % 8 == 0)
        {
            if (n == 64) n = 0;
            objectToHide[n/8].SetActive(false);
            objectToHide[((n/8)+1)%8].SetActive(true);
        }
        if (ou != null)
        {
            this.transform.position = ou.transform.position+new Vector3(0,2.5f,0);
            this.transform.rotation = ou.transform.rotation * Quaternion.Euler(new Vector3(-70, 0, 0));

        }
    }
}
