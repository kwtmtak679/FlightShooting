using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Homing : MonoBehaviour
{
    Vector2 A, C, AB, AC;

    Transform target; // �ǂ�������Ώ�

    public float speed; // �ړ��X�s�[�h
    public float maxRot; // �Ȃ���ő�p�x

    // Use this for initialization
    void Start()
    {
        target = GameObject.Find("Enemy2").transform;
        transform.eulerAngles += new Vector3(0, 0, Sita()); // �^�[�Q�b�g�̕���������
        GetComponent<Rigidbody>().velocity = transform.up.normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
        Move(Sita()); // �ړ�����
    }

    float Sita()
    {
        A = transform.position; // ���g�̍��W
        C = target.position; // �^�[�Q�b�g�̍��W

        AB = transform.up; // ���g�̏�����x�N�g��
        AC = C - A; // �^�[�Q�b�g�̕����x�N�g��

        float dot = Vector3.Dot(AB, AC); // ����
        float rot = Acosf(dot / (Length(AB) * Length(AC))); // �A�[�N�R�T�C������Ƃ����߂�

        // �O�ς����]���������߂�
        if (AB.x * AC.y - AB.y * AC.x < 0)
        {
            rot = -rot;
        }
        return rot * 180f / Mathf.PI; // ���W�A������f�O���[�ɕϊ����Ċp�x��Ԃ�
    }
    // �ړ�����
    void Move(float rot)
    {
        // ���߂��p�x���Ȃ���ő�p�x���傫�������ꍇ�ɖ߂�����
        if (rot > maxRot)

        {
            rot = maxRot;
        }
        else if (rot < -maxRot)
        {
            rot = -maxRot;
        }

        transform.eulerAngles += new Vector3(0, 0, rot); // ��]
        GetComponent<Rigidbody>().velocity = AB * speed; // ��Ɉړ�
    }

    float Length(Vector2 vec)
    {
        return Mathf.Sqrt(vec.x * vec.x + vec.y * vec.y);
    }

    float Acosf(float a)
    {
        if (a < -1) a = -1;
        if (a > 1) a = 1;

        return (float)Mathf.Acos(a);
    }
}