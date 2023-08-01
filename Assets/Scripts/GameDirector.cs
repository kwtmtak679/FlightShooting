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

    //�ڕW��ݒ肷��ϐ�
    int mokuhyou;

    //���Ԃ𑪂�ϐ�
    public static float time = 0;

    //�x�X�g�^�C���𑪂�ϐ�
    public static float besttime = 0;

    //�v���C�񐔂��L�^
    public static int play = 0;

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

        //�X�^�[�g������^�C�}�[�����Z�b�g
        time = 0;

        //�|���ڕW����ݒ�
        mokuhyou = 5;
    }

    void Update()
    {
        //�|���������N���A�ڕW�ɂȂ�����
        if (kill == mokuhyou)
        {
            //�ő��^�C�����m�F����
            if (play == 0)
            {
                besttime = time;
            }
            else if(time < besttime)
            {
                besttime = time;
            }

            //���y���~�߂�
            GetComponent<AudioSource>().Stop();

            //�e�L�X�g��\��
            finish.SetActive(true);

            //�v���C�񐔂Ƀv���X�P
            play++;

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
