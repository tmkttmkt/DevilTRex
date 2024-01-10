using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound2 : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource kaunnto,kaunnto1,kaunnto2,BGM1,butukaru1,enn;
    void Start()
    {
        kaunnto1.Stop();
        BGM1.Stop();
        kaunnto.Stop();
        butukaru1.Stop();
        kaunnto2.Stop();
        //enn.Stop();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void kaunnto_sound()
    {
        kaunnto.Play();
    }
    public void kaunnto_sound2()
    {
        kaunnto1.Play();
    
    }
    public void BGM()
    {
        BGM1.Play();
    
    }
    public void butukaru_car()
    {
        butukaru1.Play();
    
    }
    public void ennzinn()
    {
        //enn.Play();
    }
     public void p()
    {
        kaunnto2.Play();
    
    }
}
