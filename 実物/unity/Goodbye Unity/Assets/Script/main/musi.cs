using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musi : MonoBehaviour
{
    AudioSource main;
    [SerializeField] AudioClip kihonda;
    [SerializeField] AudioClip tekida;
    [SerializeField] AudioClip sotoda;
    [SerializeField] AudioClip kowai;
    int n = 0;
    bool flg = false;
    bool oso_flg = false;
    // Start is called before the first frame update
    void Start()
    {
        main = gameObject.GetComponent<AudioSource>();
        soto_flg();
    }

    // Update is called once per frame
    void Update()
    {
        if (flg)
        {
            if (main.clip=kowai)
            {
                kihon();
            }

        }
        else if (oso_flg)
        {
            if (!main.isPlaying)
            {
                kowai_flg();
            }

        }
    }
    public void kowai_flg()
    {
        main.volume = 1f;
        main.loop = true;
        main.pitch = 1;
        main.clip = kowai;
        main.Play();
        oso_flg = false;

    }
    public void teki_flg()
    {
        if (main.clip!=kowai) {
            main.volume = 0.6f;
            main.loop = false;
            main.pitch = 1;
            main.clip = tekida;
            main.Play();
            oso_flg = true;
        }

    }
    public void soto_flg()
    {
        main.volume = 0.3f;
        main.loop = true;
        main.pitch = 1;
        main.clip = sotoda;
        main.Play();

    }
    public void kihon()
    {
        main.volume = 0.3f;
        main.loop = true;
        main.pitch = -1;
        main.clip = kihonda;
        main.Play();
        flg = false;

    }
    public void start_flg()
    {
        kihon();
    }
    public void kihon_flg()
    {
        flg = true;
    }
}
