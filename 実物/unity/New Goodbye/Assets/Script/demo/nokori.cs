using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using UnityEngine.SceneManagement;
using System.Windows;
public class nokori : MonoBehaviour
{
    private bool start = false;
    private Text timerText; // タイマーを表示するテキストオブジェクト
    [SerializeField] Text left;
    [SerializeField] AudioSource moziutu;
    [SerializeField] Text katari;
    [SerializeField] Image img;
    string leftext = "";
    int n = 10;
    float kierumade = 10;
    [SerializeField] Sprite taka;
    [SerializeField] Sprite zero;
    idou_mause pp;
    private void Start()
    {
        moziutu = gameObject.GetComponent<AudioSource>();
        pp = FindObjectOfType<idou_mause>();
    }

    private void Update()
    {
        if (leftext.Length > 0)
        {
            n--;
            if (n == 0)
            {
                n = 5;
                moziutu.Play();
                left.text += leftext[0];
                leftext = leftext.Substring(1);
                kierumade = 10f;
                
            }
        }
        else
        {
            kierumade -= 1;
            if (kierumade == 0)
            {
                left.text = "";
                //set_text("");

            }
            
        }
        if (left.text.Length > 0)
        {
            if (!img.gameObject.activeSelf) img.gameObject.SetActive(true);
        }
        else
        {
            if (img.gameObject.activeSelf) img.gameObject.SetActive(false);
        }
        kierumade -= Time.deltaTime; 

    }
    public void set_text(string text)
    {
        leftext = text;
        left.text = "";
    }
    public void set_katari(string text)
    {
        if (text == "高橋")
        {
            img.sprite = taka;
        }
        else if (text == "ゼロ号"||text == "？？？")
        {
            img.sprite = zero;
        }
        katari.text = "- -["+text+"]- - - - - - -  \r\n\r\n\r\n- - - - - - - - - - - ";
    }
    private void end_def()
    {
        //exeじゃなくても閉じるため
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
    public void flg_win()
    {
        SceneManager.LoadScene("hello");
    }
}


