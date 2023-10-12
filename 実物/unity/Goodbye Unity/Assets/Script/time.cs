using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using System.Diagnostics;
using System.Windows;

public class time : MonoBehaviour
{
    [SerializeField] read read_obj;
    private float timerDuration; // タイマーの時間（秒）
    private float timerValue; // タイマーの現在の値
    private bool start = false;
    private bool Tre_eat = false;
    private float eat_time;
    private Text timerText; // タイマーを表示するテキストオブジェクト
    [SerializeField] Text rast;
    [SerializeField] Text left;
    [SerializeField] Text goal;
    private string goal_text1;
    private string goal_text2;
    private string leftext;
    private int n = 10, kierumade = 600;

    private void Start()
    {
        set_text("俺のそばに近寄るなぁああ!!");
        set_goal("学校に行こう!!");
        set_goal("借金を返そう!!");
    }

    private void Update()
    {
        if (leftext.Length > 0)
        {
            n--;
            if (n == 0)
            {
                n = 10;
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
            timerDuration = read_obj.stetting["time"];
            timerValue = timerDuration;
            timerText = GetComponent<Text>();
            start = true;
        }
        timerValue -= Time.deltaTime;
        if (Tre_eat)
        {
            if (eat_time - timerValue > 5f)
            {
                ProcessStartInfo pInfo = new ProcessStartInfo();
                pInfo.FileName = "tekitou.txt";
                Process.Start(pInfo);
                end_def();
            }
        }
        else if (timerValue > 0f)
        {
            // 経過時間を減算

            // タイマーを表示するテキストを更新
            timerText.text = FormatTime(timerValue);

        }
        else if (timerValue < -10f)
        {
            ProcessStartInfo pInfo = new ProcessStartInfo();
            pInfo.FileName = "tekitou.txt";
            Process.Start(pInfo);
            end_def();

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
    public void flg_eat()
    {
        eat_time = timerValue;
        rast.text = "RIPお前\nGAMEOVER";
        Tre_eat = true;
    }
    public void set_goal(string text, int num)
    {
        if (num==1)
        {
            goal_text1 = text;
        }
        else if (num == 2)
        {
            goal_text2 = text;
        }
        else
        {
            set_goal(text);
            return;
        }
        goal.text = goal_text1 + "\n" + goal_text2;
    }
    public void set_goal(string text)
    {
        goal_text2 = goal_text1;
        goal_text1 = text;
        goal.text = goal_text1 + "\n" + goal_text2;
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

        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

