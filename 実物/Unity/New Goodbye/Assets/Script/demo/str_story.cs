using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    // Start is called before the first frame update
    void Start()
    {
        nk = FindObjectOfType<nokori>();
        cr_sui = gameObject.GetComponent<suizyak>();
        StartCoroutine(start_ibent());
    }

    // Update is called once per frame
    void Update()
    {
        
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
        nk.set_text("����̐l�Ԑ��������؂炢������\n�������Ⴄ���H��̃e�B���m��\n�������Ⴄ��");
        yield return new WaitForSeconds(6.0f);

        nk.set_katari("����");
        nk.set_text("����Ȃ��Ƃ͂ǂ��ł������񂾂�\n��l�̒j�̎q�����̃Q�[���̒�\n�̂ǂ��ɂ���̂������Ă���A���s��");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("�[����");
        nk.set_text("���������������̕����Ƃ����킯\n�ł͂Ȃ��������ŋ�����Ƃ���\n�킯�ɂ͂����Ȃ�");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("�[����");
        nk.set_text("�������͉ɂŉɂł��傤���Ȃ���\n���̓񎟌��̂��ƕ����D���Ȃ�\n����l���P���C���Ȃ���");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("����");
        nk.set_text("�ǂ�����΂����񂾂��������ɂ�\n��l�̖�ww���������Ă��w\n�\�͂����Ď����Ȃ���");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("�[����");
        nk.set_text("�M�����u���b...�s�����ɐg��\n�䂾�˂鋶�C�̍����قǖʔ���");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("����");
        nk.set_text("���̓��Z�̓M�����u���Ɠ��̌���\n�Ȃ񂾂���������Ă�낤�����");
        yield return new WaitForSeconds(4.0f);
        cr_sui.Active_flg();
    }
}
