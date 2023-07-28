using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Palmmedia.ReportGenerator.Core.Reporting.Builders;

//UI�Ȃǂ��Ǘ�����X�N���v�g
public class GameDirector : MonoBehaviour
{
    [SerializeField]
    private GameObject finish;

    //�|�C���g������e�L�X�g
    GameObject killmater;

    //�^�C�}�[������e�L�X�g
    GameObject timer;

    //�|������������ϐ�
    int kill = 0;

    //���Ԃ𑪂�ϐ�
    public static float time = 0;
    public void Gekitui()
    {
        //kill�ϐ����v���X1
        ++this.kill;
    }

    //�N���A�V�[���Ɉړ�
    public void Clear()
    {
        SceneManager.LoadScene("ClearScene");
    }

    void Start()
    {
        //�e�L�X�g��T��
        this.killmater = GameObject.Find("Kill");
        this.timer = GameObject.Find("Timer");
    }

    void Update()
    {
        //�|���������N���A�ڕW�ɂȂ�����
        if (kill == 8)
        {
            //���y���~�߂�
            GetComponent<AudioSource>().Stop();

            //�e�L�X�g��\��
            finish.SetActive(true);

            //�R�b��Ɋ֐����Ăяo��
            Invoke("Clear", 3.0f);
        }
        else
        {
            //���Ԃ𑝂₷
            time += Time.deltaTime;
        }

        //�|���������e�L�X�g�ɕ\��
        this.killmater.GetComponent<TextMeshProUGUI>().text =
            this.kill.ToString() + "kill";

        //���Ԃ��e�L�X�g�ɕ\��
        this.timer.GetComponent<TextMeshProUGUI>().text =
            "Time:" + time.ToString("F2");
    }
}
