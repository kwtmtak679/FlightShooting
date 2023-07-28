using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TamaGenerator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Tamanohassyabasyo")]
    private GameObject firingPoint;
    [SerializeField]
    [Tooltip("�e")]
    private GameObject bullet;
    [SerializeField]
    [Tooltip("�e�̑���")]
    private float speed = 30f;
    // Update is called once per frame
    public AudioClip fireSE;
    AudioSource aud;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();
    }
    void Update()
    {
        // ���N���b�N�������𔻒�
        if (Input.GetMouseButtonDown(0))
        {
            // �e�𔭎˂���
            LauncherShot();
        }
    }
    /// <summary>
	/// �e�̔���
	/// </summary>
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
        // �o���������{�[���̖��O��"bullet"�ɕύX
        newBall.name = bullet.name;
        this.aud.PlayOneShot(fireSE);
        // �o���������{�[����1.5�b��ɏ���
        Destroy(newBall, 1.5f);
    }
}