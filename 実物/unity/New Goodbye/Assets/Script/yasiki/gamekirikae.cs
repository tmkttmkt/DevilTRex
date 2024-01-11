
using UnityEngine;

using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;


public class gamekirikae : MonoBehaviour
{
    private Story s;
    

    void Start()
    {
        s=FindObjectOfType<Story>();
    }

    
    public void LaunchExternalExe()
    {
        //UnityEditor.EditorApplication.isPlaying = false;//UNITYエディタ上でも止まるようにするため
        Process.Start(s.devele);
        SceneManager.LoadScene("hello");
        Application.Quit();
    }

}
