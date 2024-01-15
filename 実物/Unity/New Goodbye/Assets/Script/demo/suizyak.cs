using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class suizyak : MonoBehaviour
{
    int[,] date = new int[2, 13];
    public List<int> hyuzi_kazu = new List<int>();
    List<card> cr_lis = new List<card>();
    Canvas canvas;
    bool flg=false;
    str_story st;
    nokori nk;
    Sprite spriteToLoad;
    int count = 26;
    // Start is called before the first frame update
    void Start()
    {
        nk= FindObjectOfType<nokori>();
        spriteToLoad = Resources.Load<Sprite>("defrt/saisyu/torannpu");
        canvas = FindObjectOfType<Canvas>();
        st = FindObjectOfType<str_story>();
    }
    public void Active_flg()
    {
        FillArray();
        PrintArray(date);
        all_image();
    }

    // Update is called once per frame
    void Update()
    {
        if(count==0 && flg)
        {
            st.fin();
            flg = false;
        }
    }
    public void add_hyou(int num,card cr)
    {
        hyuzi_kazu.Add(num);
        cr_lis.Add(cr);
        if (hyuzi_kazu.Count == 2)
        {
            if (hyuzi_kazu[0] != hyuzi_kazu[1])find(hyuzi_kazu[0], cr_lis[0], cr_lis[1]);
            Invoke("gousei", 3f);
        }
    }
    void gousei()
    {
        cr_lis[0].tozi();
        cr_lis[1].tozi();
        if (hyuzi_kazu[0] == hyuzi_kazu[1])
        {
            num_story(hyuzi_kazu[0]);
            cr_lis[0].del();
            cr_lis[1].del();
            count -= 2;
        }
        hyuzi_kazu.RemoveAt(0);
        hyuzi_kazu.RemoveAt(0);
        cr_lis.RemoveAt(0);
        cr_lis.RemoveAt(0);

    }
    void all_image()
    {
        for (int row = 0; row < date.GetLength(0); row++)
        {
            for (int col = 0; col < date.GetLength(1); col++)
            {
                GameObject imageObject = new GameObject("Image" + "-" + row + "-" + col);
                Image imageComponent = imageObject.AddComponent<Image>();
                imageObject.transform.SetParent(this.transform, false);
                imageComponent.sprite = spriteToLoad;
                RectTransform rectTransform = imageObject.GetComponent<RectTransform>();
                rectTransform.anchoredPosition =new Vector3(-600 + col * 100, 110 - row * 220, 0);
                rectTransform.sizeDelta =new Vector3(100, 170);

                card cardComponent = imageObject.AddComponent<card>();
                cardComponent.id_flg(date[row,col]);
                cardComponent.pls_img(imageComponent);

                EventTrigger eventTrigger = imageObject.AddComponent<EventTrigger>();
                EventTrigger.Entry entry = new EventTrigger.Entry();
                entry.eventID = EventTriggerType.PointerClick;
                entry.callback.AddListener((data) => {cardComponent.OnImageButtonClick((PointerEventData)data); });
                eventTrigger.triggers.Add(entry);

                cardComponent.pls_game(this);
                cardComponent.pls_sprite(spriteToLoad);
            }
        }
        flg = true;
    }
    void FillArray()
    {
        count = 26;
        // 1����16�܂ł̐�����2���z�u���邽�߂̃��X�g
        List<int> numbers = new List<int>();
        for (int i = 1; i <= date.GetLength(0)* date.GetLength(1)/2; i++)
        {
            numbers.Add(i);
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
    void find(int num,card ma_cr,card sa_cr)
    {
        int x, y;
        int soitu_x = 0, soitu_y = 0;
        int use_x = 0, use_y = 0;
        string str = ma_cr.gameObject.name;
        string[] parts = str.Split('-');
        if (int.TryParse(parts[parts.Length - 1], out x)) ;

        if (int.TryParse(parts[parts.Length - 2], out y)) ;

        str = sa_cr.gameObject.name;
         parts = str.Split('-');
        if (int.TryParse(parts[parts.Length - 1], out use_x)) ;

        if (int.TryParse(parts[parts.Length - 2], out use_y)) ;

        for (int row = 0; row < date.GetLength(0); row++)
        {
            for (int col = 0; col < date.GetLength(1); col++)
            {
                if(row==y&&col==x)
                {
                    continue;
                }
                if(date[row, col] == num)
                {
                    soitu_x = col;
                    soitu_y = row;
                }
            }
        }
        int nn = (use_x - soitu_x) * (use_x - soitu_x) + (use_y - soitu_y) * (use_y - soitu_y);
        Debug.Log(" use_x:" + x + " use_y:" + y + " soitu_x:" + soitu_x + " soitu_y:" + soitu_y + "  nn:" +nn+" num:"+num);
        if (nn<2)
        {
            nk.set_katari("�[����");
            nk.set_text("�������Ȃ��`");
        }
    }
    void num_story(int num)
    {
        if (num == 1) StartCoroutine(flg1());
        if (num == 2) StartCoroutine(flg2());
        if (num == 11) StartCoroutine(flg11());
        if (num == 12) StartCoroutine(flg12());
        if (num == 13)StartCoroutine(flg13());
    }
    IEnumerator flg1()
    {
        nk.set_katari("�[����");
        nk.set_text("���������ΐ؂���̓`����������");
        yield return new WaitForSeconds(3.0f);

        nk.set_katari("�[����");
        nk.set_text("�u�\�E���̂͂������B���܂���\n�Ȃ�񂩁H�v�ƌ����Ă���");
        yield return new WaitForSeconds(8.0f);

    }
    IEnumerator flg2()
    {
        nk.set_text("�ق�Ƃɉ����������񂾂낤�A�C�Â�\n����莝�����Ȃ��Ȃ��Ă���B\n�d�b���ł��Ȃ��B");
        nk.set_katari("�[����");
        nk.set_text("���������΍��X�؂�����Ȃ��ƌ����Ă���");
        yield return new WaitForSeconds(3.0f);

        nk.set_katari("�[����");
        nk.set_text("�u����I���̉��~����A������Ⓚ�H�i\n�̒[������▭�ɉ��܂�Â炭\n���H����o�C�g�����߂��!!�v");
        yield return new WaitForSeconds(9.0f);

    }
    IEnumerator flg3()
    {
        nk.set_katari("�[����");
        nk.set_text("�f�����Ă�����ˁB�����b�`��\n�f�r���ET-rex�ɍ~�ՂɊ֌W�������");
        yield return new WaitForSeconds(3.0f);

    }
    IEnumerator flg4()
    {
        nk.set_katari("�[����");
        nk.set_text("���ɂȂ����烏�C�͂��̃Q�[��\n����o����񂾂낤��");
        yield return new WaitForSeconds(3.0f);

    }
    IEnumerator flg5()
    {
        nk.set_katari("�[����");
        nk.set_text("�������΁A�؂͂��O�Ƌ�����\n���O�T�����炢�̊m���ŊԈႦ�Ă���");
        yield return new WaitForSeconds(3.0f);

    }
    IEnumerator flg6()
    {
        nk.set_katari("�[����");
        nk.set_text("�؂��u���񂾂�c�^���̂c�u�c\n�Ԃ��Ă���v������");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("�[����");
        nk.set_text("�c�^�����ĂȂ񂾁H������\n�����������Ȃ񂾂�");
        yield return new WaitForSeconds(3.0f);

    }
    IEnumerator flg7()
    {
        nk.set_katari("�[����");
        nk.set_text("�������΁A�؂������͊����_���X\n�ł���Ă���ƌ����Ă���");
        yield return new WaitForSeconds(3.0f);

    }
    IEnumerator flg8()
    {
        nk.set_katari("�[����");
        nk.set_text("�����������o�C�g�𐔂���o�C�g�Ȃ��\n...���邩��");
        yield return new WaitForSeconds(3.0f);

    }
    IEnumerator flg9()
    {
        nk.set_katari("�[����");
        nk.set_text("�����̍D���ȐH�ו����ĉ�����");
        yield return new WaitForSeconds(3.0f);

        nk.set_katari("�[����");
        nk.set_text("�񎟌��̂�̑O�ɒu���Ƃ���\n���_�I�ɒǂ��l�߂邱�Ƃł��邩�ȁH");
        yield return new WaitForSeconds(3.0f);

    }
    IEnumerator flg10()
    {
        nk.set_katari("�[����");
        nk.set_text("�����̖ڂ����肾�����b�����悤\n...����͌ܔN�O..");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("�[����");
        nk.set_text("����..�܂����O������...�Q�[����\n���ɂ���Ǝ��Ԃ��킩��Ȃ��Ȃ�\n�񂾂��");
        yield return new WaitForSeconds(4.0f);

    }
    IEnumerator flg13()
    {
        nk.set_katari("�[����");
        nk.set_text("���̔w�i������");
        yield return new WaitForSeconds(3.0f);

        nk.set_katari("�[����");
        nk.set_text("����͋������ڂ����肾�����炢��\n�l������DDTR0.3��action�^��\n���o�[�W������..��...");
        yield return new WaitForSeconds(5.0f);

        nk.set_katari("�[����");
        nk.set_text("�܂�͋����̓��̒��Ǝv���΂�����");
        yield return new WaitForSeconds(3.0f);

    }
    IEnumerator flg12()
    {
        nk.set_katari("�[����");
        nk.set_text("���̃��{�b�g��������͂�����...");
        yield return new WaitForSeconds(3.0f);

        nk.set_katari("�[����");
        nk.set_text("����A���ɂ������Ƃł��Ȃ���");
        yield return new WaitForSeconds(3.0f);

    }
    IEnumerator flg11()
    {
        nk.set_katari("�[����");
        nk.set_text("�X�c�S�[�X�g�̎�H�͎O�T�Ԃ��炢\n�x�b�g���\�t�@�[�̌��Ԃɋ��܂��Ă����C����");
        yield return new WaitForSeconds(5.0f);

        nk.set_katari("�[����");
        nk.set_text("����ς�������");
        yield return new WaitForSeconds(3.0f);

    }
}
