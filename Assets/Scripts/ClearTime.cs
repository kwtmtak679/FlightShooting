using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClearTime : MonoBehaviour
{
    //�N���A�^�C���̃e�L�X�g
    GameObject timerText;

    void Start()
    {
        this.timerText = GameObject.Find("ClearTime");
    }

    void Update()
    {
        this.timerText.GetComponent<TextMeshProUGUI>().text =
        "ClearTime:" + GameDirector.time.ToString("F2");
    }
}
