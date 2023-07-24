using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//�h���[�����󂷂��߂̃X�N���v�g+�󂵂��Ƃ��ɂ�����X�N���v�g
public class DroneBreak : MonoBehaviour
{
    //�Q�[���f�B���N�^�[�̒l������
    GameObject director;

    public void Hakai()
    {
        //�G��|�������Ɉ�_�v���X
        this.director.GetComponent<GameDirector>().Gekitui();


        Destroy(this.gameObject);
    }


    //���������������ɏ�������
    public void OnCollisionEnter(Collision atatta)
    {
        //�����h���[���ɓ��������I�u�W�F�N�g��Tag���uTama�v��������
        if (atatta.gameObject.tag == "Tama")
        {
            //�p�[�e�B�N����\��
            GetComponent<ParticleSystem>().Play();


            //�����������ƃh���[��������
            Destroy(atatta.gameObject);
            Invoke("Hakai", 1.0f);

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
