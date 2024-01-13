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
        // 1����16�܂ł̐�����2���z�u���邽�߂̃��X�g
        List<int> numbers = new List<int>();
        for (int i = 1; i <= 16; i++)
        {
            numbers.Add(i);
        }

        // �z��Ƀ����_���ɐ�����z�u
        System.Random rand = new System.Random();
        for (int row = 0; row < date.GetLength(0); row++)
        {
            for (int col = 0; col < date.GetLength(1); col++)
            {
                // �����_���Ȑ�����I��
                if (numbers.Count == 1)
                {
                    date[row, col] = numbers[0];
                    return;

                }
                int index = rand.Next(0, numbers.Count-1);
                int randomNum = numbers[index];

                // ������z�u
                date[row, col] = randomNum;

                // �z�񂩂�g�p�����������폜
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
