using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//�h���[�����󂷂��߂̃X�N���v�g
public class DroneBreak : MonoBehaviour
{
    //�Q�[���f�B���N�^�[�̒l������
    GameObject director;

    //���������������ɏ�������
    public void OnCollisionEnter(Collision atatta)
    {
        //�����h���[���ɓ��������I�u�W�F�N�g��Tag���uTama�v��������
        if (atatta.gameObject.tag == "Tama")
        {
            //�����������ƃh���[��������
            Destroy(atatta.gameObject);
            Destroy(this.gameObject);

            //�G��|�������Ɉ�_�v���X
            this.director.GetComponent<GameDirector>().Gekitui();
        }
    }

    void Start()
    {
        //�Q�[���f�B���N�^�[��T���Ēl���Ƃ�
        this.director = GameObject.Find("GameDirector");
    }

    void Update()
    {
        
    }
}
