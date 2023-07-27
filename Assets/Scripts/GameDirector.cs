using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

//UI�Ȃǂ��Ǘ�����X�N���v�g
public class GameDirector : MonoBehaviour
{
    [SerializeField]
    private GameObject finish;

    //�|�C���g������e�L�X�g
    GameObject killmater;
    //�|������������ϐ�
    int kill = 0;

    public void Gekitui()
    {
        //kill�ϐ����v���X1
        ++this.kill;
    }

    public void Clear()
    {
        SceneManager.LoadScene("ClearScene");
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

        //�|���������N���A�ڕW�ɂȂ�����
        if(kill==8)
        {
            finish.SetActive(true);

            Invoke("Clear", 3.0f);
        }
    }
}
