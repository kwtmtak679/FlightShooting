using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneBreak : MonoBehaviour
{
    //���������������ɏ�������
    private void OnCollisionEnter(Collision atatta)
    {
        //�����h���[���ɓ��������I�u�W�F�N�g��Tag���uTama�v��������
        if (atatta.gameObject.tag == "Tama")
        {
            //�����������ƃh���[��������
            Destroy(atatta.gameObject);
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
