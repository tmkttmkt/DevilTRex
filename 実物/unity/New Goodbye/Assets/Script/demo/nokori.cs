using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using UnityEngine.SceneManagement;
using System.Windows;
public class nokori : MonoBehaviour
{
    private float timerDuration; // タイマーの時間（秒）
    private float timerValue; // タイマーの現在の値
    private bool start = false;
    private Text timerText; // タイマーを表示するテキストオブジェクト
    [SerializeField] Text rast;
    [SerializeField] Text left;
    [SerializeField] AudioSource moziutu;
    private string goal_text1;
    private string goal_text2;
    private string leftext;
    private int n = 10, kierumade = 600;
    idou_mause pp;
    private void Start()
    {
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
                kierumade = 360;
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


        if (!start)
        {
            timerDuration = 600;
            timerValue = timerDuration;
            timerText = GetComponent<Text>();
            start = true;
        }
        timerValue -= Time.deltaTime;

        if (timerValue > 0f)
        {
            // 経過時間を減算

            // タイマーを表示するテキストを更新
            timerText.text = FormatTime(timerValue);

        }
        else if (timerValue < -10f)
        {
            flg_fin();

        }
        else
        {
            timerText.text = "お前はすでに死んでいるはず";
            rast.text = "ドロー\nGAMEOVER";
            // タイマーが0になった場合の処理
            // タイマーが0以下にならないようにする場合は、条件を変更してください
        }
    }
    public void set_text(string text)
    {
        leftext = text;
        left.text = "";
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
    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);

        return string.Format("残り:{0:00}:{1:00}", minutes, seconds);
    }
    public void flg_fin()
    {
        ProcessStartInfo pInfo = new ProcessStartInfo();
        pInfo.FileName = "hikiwake.exe";
        Process.Start(pInfo);
        end_def();
    }
    public void flg_win()
    {
        SceneManager.LoadScene("hello");
    }
    public void flg_eat()
    {
        ProcessStartInfo pInfo = new ProcessStartInfo();
        pInfo.FileName = "Game Over.exe";
        Process.Start(pInfo);
        end_def();
    }
}


