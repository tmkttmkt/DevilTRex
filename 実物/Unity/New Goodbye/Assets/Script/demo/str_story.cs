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
    [SerializeField] public StoryText[] st;
    nokori nk;
    // Start is called before the first frame update
    void Start()
    {
        nk=FindObjectOfType<nokori>();
        StartCoroutine(start_ibent());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator start_ibent()
    {
        foreach (StoryText tex in st){
            nk.set_text(tex.text);
            nk.set_katari(tex.charcter);
            yield return new WaitForSeconds(tex.time);
        }
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
        yield return new WaitForSeconds(1.0f);

        nk.set_katari("����");
        nk.set_text("���H��...���������A�܂����O��\n2D�����ȁA�����؂炢���݂�����");
        yield return new WaitForSeconds(6.0f);

        nk.set_katari("����");
        nk.set_text("����̐l�Ԑ��������؂炢������");
        yield return new WaitForSeconds(6.0f);

        nk.set_katari("T-rex");
        nk.set_text("�ǂ����ɒn�}�̂悤�Ȃ��̂͂Ȃ���\n�낤���}���˂΁E�E�E�E�E�E");
        yield return new WaitForSeconds(4.0f);
    }
}
