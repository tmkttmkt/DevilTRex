using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musi : MonoBehaviour
{
    [SerializeField] AudioSource main;
    [SerializeField] AudioClip kihonda;
    [SerializeField] AudioClip tekida;
    [SerializeField] AudioClip sotoda;
    int n = 0;
    // Start is called before the first frame update
    void Start()
    {
        soto_flg();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void teki_flg()
    {
        main.loop = false;
        main.pitch = 1;
        main.clip = tekida;
        main.Play();

    }
    public void soto_flg()
    {
        main.loop = true;
        main.pitch = 1;
        main.clip = sotoda;
        main.Play();

    }
    public void kihon_flg()
    {
        main.loop = true;
        main.pitch = -1;
        main.clip = kihonda;
        main.Play();
    }
}
