using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//UI�Ȃǂ��Ǘ�����X�N���v�g
public class GameDirector : MonoBehaviour
{
    //�|�C���g������e�L�X�g
    GameObject killmater;
    //�|�C���g������ϐ�
    int kill = 0;

    public void Gekitui()
    {
        //kill�ϐ����v���X1
        ++this.kill;
    }

    void Start()
    {
        //�e�L�X�g��T��
        this.killmater = GameObject.Find("Kill");
    }

    void Update()
    {
        //�e�L�X�g�ɕ\������e�L�X�g���`
        this.killmater.GetComponent<TextMeshProUGUI>().text =
            this.kill.ToString() + "kill";
    }
}
