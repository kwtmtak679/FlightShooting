using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClearTime : MonoBehaviour
{
    //�N���A�^�C���̃e�L�X�g
    GameObject timerText;

    //�x�X�g�^�C���̃e�L�X�g
    GameObject bestText;

    void Start()
    {
        this.timerText = GameObject.Find("ClearTime");
        this.bestText = GameObject.Find("BestTime");
    }

    void Update()
    {
        this.timerText.GetComponent<TextMeshProUGUI>().text =
        "ClearTime:" + GameDirector.time.ToString("F2");

        this.bestText.GetComponent<TextMeshProUGUI>().text =
        "Besttime:" + GameDirector.besttime.ToString("F2");
    }
}
