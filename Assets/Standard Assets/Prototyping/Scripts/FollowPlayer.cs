using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject target;  // �^�[�Q�b�g�ւ̎Q��
    private Vector3 offset;  // ���΍��W
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        //�������g��target�Ƃ̑��΋��������߂�
        offset = GetComponent<Transform>().position - target.transform.position;
    }
    void Update()
    {
        // �������g�̍��W�ɁAtarget�̍��W�ɑ��΍��W�𑫂����l��ݒ肷��
        GetComponent<Transform>().position = target.transform.position + offset;
    }
}
