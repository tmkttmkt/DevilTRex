using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class time : MonoBehaviour
{
    [SerializeField]read read_obj;
    private float timerDuration; // タイマーの時間（秒）
    private float timerValue; // タイマーの現在の値
    private bool start = false;
    private Text timerText; // タイマーを表示するテキストオブジェクト

    private void Start()
    {

    }

    private void Update()
    {
        if (!start)
        {
            timerDuration = read_obj.stetting["time"];
            timerValue = timerDuration;
            timerText = GetComponent<Text>();
            start = true;
        }
        if (timerValue > 0f)
        {
            timerValue -= Time.deltaTime; // 経過時間を減算

            // タイマーを表示するテキストを更新
            timerText.text = FormatTime(timerValue);
        }
        else
        {
            // タイマーが0になった場合の処理
            // タイマーが0以下にならないようにする場合は、条件を変更してください
        }
    }

    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);

        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

