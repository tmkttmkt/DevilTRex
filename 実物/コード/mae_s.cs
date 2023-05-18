using UnityEngine;

public class ObjectDetection : MonoBehaviour
{
    public float detectionDistance = 10f; // ���C�L���X�g�̋���

    void Update()
    {
        // ���삷��I�u�W�F�N�g�̑O���̕������擾
        Vector3 direction = transform.forward;

        // ���C�L���X�g�����s
        RaycastHit hit;
        if (Physics.Raycast(transform.position, direction, out hit, detectionDistance))
        {
            // ���C�L���X�g�������ɓ��������ꍇ�̏���
            GameObject hitObject = hit.collider.gameObject;
            Debug.Log("Hit object: " + hitObject.name);
            // �K�v�ȏ�����ǉ����܂�
        }
    }
}
