using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suizyak : MonoBehaviour
{
    int[,] date = new int[3, 10] {
                { 4, 5, 6,0,0,0,0,0,0,0 },
                { 7, 8, 9 ,0,0,0,0,0,0,0 },
                { 7, 8, 9,0,0,0,0,0,0,0  },
            };
    // Start is called before the first frame update
    void Start()
    {

    }
    public void Active_flg()
    {
        FillArray();
        PrintArray(date);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FillArray()
    {
        // 1から16までの数字を2つずつ配置するためのリスト
        List<int> numbers = new List<int>();
        for (int i = 1; i <= 16; i++)
        {
            numbers.Add(i);
        }

        // 配列にランダムに数字を配置
        System.Random rand = new System.Random();
        for (int row = 0; row < date.GetLength(0); row++)
        {
            for (int col = 0; col < date.GetLength(1); col++)
            {
                // ランダムな数字を選択
                if (numbers.Count == 1)
                {
                    date[row, col] = numbers[0];
                    return;

                }
                int index = rand.Next(0, numbers.Count-1);
                int randomNum = numbers[index];

                // 数字を配置
                date[row, col] = randomNum;

                // 配列から使用した数字を削除
                numbers.RemoveAt(index);
            }
        }
    }
    void PrintArray(int[,] array)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Debug.Log($"array[{row},{col}] = {array[row, col]}");
            }
        }
    }
}
