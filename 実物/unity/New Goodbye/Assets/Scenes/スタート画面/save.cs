using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.IO.Compression;

public class save : MonoBehaviour
{
    // Start is called before the first frame update
      //string fileContent = File.ReadAllText(Application.dataPath+"data");
      //Application.dataPathは今あるexeファイルのパス
     //dataというtextファイルの中身をfileContentに入れている
     private Story s;
     void Start()
     {
        s=FindObjectOfType<Story>();
     }
        
    public void kirikae()
    {
        File.WriteAllText(s.text, "OK"); // ファイルの内容をOKに変更する
    }

    // Update is called once per frame

}
