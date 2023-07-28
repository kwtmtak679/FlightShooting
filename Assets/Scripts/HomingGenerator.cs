using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingGenerator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�e�̔��ˏꏊ")]
    private GameObject firingPoint;
    [SerializeField]
    [Tooltip("�e")]
    private GameObject bullet;
    [SerializeField]
    [Tooltip("�e�̑���")]
    private float speed = 30f;

    public AudioClip fireSE;
    AudioSource aud;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();
    }
    void Update()
    {
        // �E�N���b�N�������𔻒�
        if (Input.GetMouseButtonDown(1))
        {
            // �e�𔭎˂���
            LauncherShot();
        }
    }
    private void LauncherShot()
    {
        // �e�𔭎˂���ꏊ���擾
        Vector3 bulletPosition = firingPoint.transform.position;
        // ��Ŏ擾�����ꏊ�ɁA"bullet"��Prefab���o��������
        GameObject newBall = Instantiate(bullet, bulletPosition, transform.rotation);
        // �o���������{�[����forward(z������)
        Vector3 direction = newBall.transform.up;
        // �e�̔��˕�����newBall��z����(���[�J�����W)�����A�e�I�u�W�F�N�g��rigidbody�ɏՌ��͂�������
        newBall.GetComponent<Rigidbody>().AddForce(direction * speed, ForceMode.Impulse);

        this.aud.PlayOneShot(fireSE);
        // �o���������~�T�C����3�b��ɏ���
        Destroy(newBall, 3.0f);
    }
}
