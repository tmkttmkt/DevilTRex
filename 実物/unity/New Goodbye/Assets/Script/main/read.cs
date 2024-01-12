using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
public class read : MonoBehaviour
{
    public Dictionary<string, int> stetting = new Dictionary<string, int>();
    [SerializeField]public GameObject[] tekitati;
    // Start is called before the first frame update
    void Start()
    {
        int n = 0;
        string pa = "test2.txt";
        if (File.Exists(pa))
        {
            using (StreamReader fail = new StreamReader(pa))
            {
                string te, key, val;
                stetting["time"] = 20;
                while (true)
                {
                    te = fail.ReadLine();
                    Debug.Log(te);
                    if (te == null) break;
                    val = te.Remove(0, te.IndexOf("=") + 1);
                    key = te.Remove(te.IndexOf("="));
                    stetting[key] = int.Parse(val);
                    Debug.Log(key+val);
                }
                //Debug.Log(stetting);
                fail.Close();
            }
            while (n < stetting["teki"]) {
                tekitati[n].SetActive(true);
                n++;
            }
            using (StreamWriter writer = new StreamWriter("dbg.txt", true))
            {
                //writer.WriteLine(stetting["time"]);
                writer.WriteLine("ファイルある");
            }
        }
        else
        {
            using (StreamWriter writer = new StreamWriter("dbg.txt", true))
            {
                //writer.WriteLine(stetting["time"]);
                writer.WriteLine("ファイルなし");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        //stetting["time"] = 20;
        //Debug.Log("F0");

    }
}
