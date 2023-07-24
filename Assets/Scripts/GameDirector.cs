using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//UIなどを管理するスクリプト
public class GameDirector : MonoBehaviour
{
    //ポイントを入れるテキスト
    GameObject killmater;
    //ポイントを入れる変数
    int kill = 0;

    public void Gekitui()
    {
        //kill変数をプラス1
        ++this.kill;
    }

    void Start()
    {
        //テキストを探す
        this.killmater = GameObject.Find("Kill");
    }

    void Update()
    {
        //テキストに表示するテキストを定義
        this.killmater.GetComponent<TextMeshProUGUI>().text =
            this.kill.ToString() + "kill";
    }
}
