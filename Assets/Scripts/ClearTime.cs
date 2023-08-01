using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClearTime : MonoBehaviour
{
    //クリアタイムのテキスト
    GameObject timerText;

    //ベストタイムのテキスト
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
