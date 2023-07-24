using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //�v���C���[�������ɏՓ˂����Ƃ�
    private void OnCollisionEnter(Collision player)
    {
        //���̌������ɓ���������
        if(player.gameObject.tag=="Mati")
        {
            //�w��������
            Destroy(this.gameObject);
            //�Q�[���I�[�o�[�V�[���Ɉړ�
            SceneManager.LoadScene("GameOver");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        //�i��
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, 0, 0.15f);
        }
        //���ɋȂ���
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -0.5f, 0);
        }
        //�E�ɋȂ���
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0.5f, 0);
        }
        //��ɍs��
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(0, 0.1f, 0);
        }
        //���ɍs��
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(0, -0.1f, 0);
        }
    }
}