using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seykey : MonoBehaviour
{
    [SerializeField] public string sey = "�ݒ肳��Ă��Ȃ��Z���t";
    public GameObject plyerrr;
    bool flg=true;
    float detectionRadius=2f;
    time ti;
    void start()
    {
        
    }
    void Update()
    {
        if (flg)
        {
            if (IsPlayerNear())
            {
                ti = FindObjectOfType<time>();
                ti.set_text(sey);
                flg = false;
            }
        }
    }

    bool IsPlayerNear()
    {

        // �v���C���[�I�u�W�F�N�g�����݂��Ȃ��ꍇ�̓v���C���[�͋߂��ɂ��Ȃ��Ɣ���
        float disY = Mathf.Abs(plyerrr.transform.position.y - this.transform.position.y);
        if (disY <= 3F)
        {
            // �v���C���[�Ƃ̋��������o���a�ȓ����ǂ����𔻒�
            float distanceToPlayer = Vector3.Distance(transform.position, plyerrr.transform.position);
            return distanceToPlayer <= detectionRadius;
        }
        return false;
        // "Player"�^�O�����I�u�W�F�N�g������
    }
}
