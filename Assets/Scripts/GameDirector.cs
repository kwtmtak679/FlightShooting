using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

//UIなどを管理するスクリプト
public class GameDirector : MonoBehaviour
{
    [SerializeField]
    private GameObject finish;

    //ポイントを入れるテキスト
    GameObject killmater;
    //倒した数を入れる変数
    int kill = 0;

    public void Gekitui()
    {
        //kill変数をプラス1
        ++this.kill;
    }

    public void Clear()
    {
        SceneManager.LoadScene("ClearScene");
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

        //倒した数がクリア目標になったら
        if(kill==8)
        {
            finish.SetActive(true);

            Invoke("Clear", 3.0f);
        }
    }
}
