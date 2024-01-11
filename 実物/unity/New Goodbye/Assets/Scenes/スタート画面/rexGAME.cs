using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;
public class rexGAME : MonoBehaviour,IPointerClickHandler
{
    // Start is called before the first frame update
    private gamekirikae g;
  
   
 
    public GameObject a;
    private Story s;
    
    void Start()
    {
  
        g=FindObjectOfType<gamekirikae>();
        s=FindObjectOfType<Story>();
  
    }

    // Update is called once per frame
    public void OnPointerClick(PointerEventData eventData)//ボタンが押されたらゲーム開始
    {
         string fileContent = File.ReadAllText(s.text);
        if(fileContent=="OK")
        {
            g.LaunchExternalExe();//devile・T・REX起動
            a.SetActive(false);
        }
    }
}
