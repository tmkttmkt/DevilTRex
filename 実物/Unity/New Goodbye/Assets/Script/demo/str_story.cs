using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StoryText
{
    public string text;
    public string charcter;
    public float time;
}
public class str_story : MonoBehaviour
{
    nokori nk;
    suizyak cr_sui;
    bool iro_flg = false;
    int n = 0;
    // Start is called before the first frame update
    [SerializeField] Text text;
    [SerializeField] GameObject gg1;
    [SerializeField] GameObject gg2;
    void Start()
    {
        nk = FindObjectOfType<nokori>();
        cr_sui = FindObjectOfType<suizyak>();
        StartCoroutine(start_ibent());
    }

    // Update is called once per frame
    void Update()
    {
        if (iro_flg)
        {
            n++;
            if (n == 6)
            {
                text.color = new Color(Random.value, Random.value, Random.value, 1.0f);
                n = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            fin();
        }
    }
    public void fin()
    {
        iro_flg = true;
        gg1.SetActive(true);
        gg2.SetActive(true);
        StartCoroutine(fin_ibent());
    }
    IEnumerator fin_ibent()
    {

        nk.set_katari("����");
        nk.set_text("�������̂ŋ����Ă���");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("�[����");
        nk.set_text("������̖ʓ|�Ȃ̂ŘA��Ă�����");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("�[����");
        nk.set_text("��������");
        yield return new WaitForSeconds(2.0f);

        nk.flg_win();

    }
    IEnumerator start_ibent()
    {
        nk.set_text("�ق�Ƃɉ����������񂾂낤�A�C�Â�\n����莝�����Ȃ��Ȃ��Ă���B\n�d�b���ł��Ȃ��B");

        nk.set_katari("����");
        nk.set_text("�R�R�͂����������ǂ����H�Q�[����\n���Ƃ͌���ꂽ���̂�...\n���ĉ��ɂ��̊G��ww������ww");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("�H�H�H");
        nk.set_text("�N�b�N�b�N�b");
        yield return new WaitForSeconds(1.0f);

        nk.set_katari("�H�H�H");
        nk.set_text("�R�R�R�R");
        yield return new WaitForSeconds(1.0f);

        nk.set_katari("�H�H�H");
        nk.set_text("�L�L�b�L�L�b");
        yield return new WaitForSeconds(1.0f);

        nk.set_katari("�[����");
        nk.set_text("���͂��̃Q�[���̎��_��");
        yield return new WaitForSeconds(3.0f);

        nk.set_katari("����");
        nk.set_text("���H��...���������A�܂����O��\n2D�����ȁA�����؂炢���݂�����");
        yield return new WaitForSeconds(6.0f);

        nk.set_katari("�[����");
        nk.set_text("����̐l�Ԑ����؂���؂炾����\n�������Ⴄ���H��̃e�B���m��\n�������Ⴄ��");
        yield return new WaitForSeconds(6.0f);

        nk.set_katari("����");
        nk.set_text("�������邩�狃���Ȃ�\n�������l�̒j�̎q�����̃Q�[���̒�\n�̂ǂ��ɂ���̂������Ă���A���s��");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("�[����");
        nk.set_text("���������������̎x�z���Ƃ����킯\n�ł͂Ȃ���\n�����Ȃ���");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("�[����");
        nk.set_text("�����Ƃ�͉ɂŉɂł��傤���Ȃ���\n���̓񎟌��̂��ƕ��������Ȃ�\n������l���P���C���N����Ȃ���");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("����");
        nk.set_text("�m�������Ƃ��悗�������ɂ�\n��l�̖�ww���������Ă��w\n�\�͂�����ww�����Ȃ����H�I");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("�[����");
        nk.set_text("�M�����u���b...�s�����ɐg��\n�䂾�˂鋶�C�̍����قǖʔ���");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("����");
        nk.set_text("���̓��Z�̓M�����u���Ɠ��̌���\n�Ȃ񂾂���������Ă�낤�����");
        yield return new WaitForSeconds(4.0f);
        //cr_sui.Active_flg();

        nk.set_katari("�[����");
        nk.set_text("�b�N�b�N�b�N�A����͐_�o����(��Nerve Weakness And Dead��)��\n�������悤�A����ŊJ���ꂽ��N�̏�����");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("�[����");
        nk.set_text("��������������ȁB\n������߂Ȃ��悤�Ƀq���g������");
        yield return new WaitForSeconds(3.0f);

        cr_sui.Active_flg();
    }
    IEnumerator restart_ibent()
    {
        nk.set_katari("�[����");
        nk.set_text("�b�N�b�N�b�N�A����͐_�o����(��Nerve Weakness And Dead��)��\n�������悤�A����ŊJ���ꂽ��N�̏�����");
        yield return new WaitForSeconds(4.0f);
    }
}
