using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
public class read : MonoBehaviour
{
    public Dictionary<string, int> stetting = new Dictionary<string, int>();
    // Start is called before the first frame update
    void Start()
    {
        StreamReader fail = new StreamReader("tekitou.txt", Encoding.GetEncoding("Shift_JIS"));
        string te,key,val;
        while(true){
            te = fail.ReadLine();
            Debug.Log(te);
            if (te == null) break;
            val = te.Remove(0, te.IndexOf("=") + 1);
            key = te.Remove(te.IndexOf("="));
            stetting[key] = int.Parse(val);
            Debug.Log(key);
            Debug.Log(val);
        }
        //Debug.Log(stetting);
        fail.Close();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
