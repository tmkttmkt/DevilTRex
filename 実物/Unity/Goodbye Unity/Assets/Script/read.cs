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
        StreamReader fail = new StreamReader("test2.txt", Encoding.GetEncoding("Shift_JIS"));
        string te,key,val;
        stetting["time"] = 20;
        Debug.Log("F0");
        while (true){
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

        using (StreamWriter writer = new StreamWriter("dbg.txt", true))
        {
            writer.WriteLine(stetting["time"]);
            writer.WriteLine("スタート実行");
        }
        stetting["time"] = 600;
        Debug.Log("F0");
    }
    // Update is called once per frame
    void Update()
    {
        //stetting["time"] = 20;
        //Debug.Log("F0");

    }
}
