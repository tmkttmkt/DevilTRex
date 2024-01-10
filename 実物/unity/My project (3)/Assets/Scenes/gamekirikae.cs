
using UnityEngine;

using System.Diagnostics;
using Unity.VisualScripting;


public class gamekirikae : MonoBehaviour
{
    private Story s;
    private save ss;
    

    void Start()
    {
        s=FindObjectOfType<Story>();
        ss=FindObjectOfType<save>();
    }

    
    public void LaunchExternalExe()
    {
        ss.kirikae();
        //UnityEditor.EditorApplication.isPlaying = false;//UNITYエディタ上でも止まるようにするため
        Process.Start(s.devele);
        Application.Quit();
    }

}
