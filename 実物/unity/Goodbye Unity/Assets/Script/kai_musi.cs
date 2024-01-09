using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kai_musi : MonoBehaviour
{
    [SerializeField] GameObject pp;
    [SerializeField] AudioClip cl;
    AudioSource main;
    bool flg = true;
    // Start is called before the first frame update
    void Start()
    {
        main = gameObject.GetComponent<AudioSource>();
        cl = Resources.Load<AudioClip>("audio/white_noise");
    }

    // Update is called once per frame
    void Update()
    {
        if (2f>CalculateDistanceY(pp))
        {
            if (flg)
            {
                main.clip = cl;
                main.Play();
                flg = false;
                Debug.Log("nag");
            }
        }
        else
        {
            main.clip = null;
            flg = true;


        }
        
    }
    float CalculateDistanceY(GameObject obj)
    {
        float distance = Mathf.Abs(obj.transform.position.y - transform.position.y);
        return distance;
    }
}
