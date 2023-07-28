using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Palmmedia.ReportGenerator.Core.Reporting.Builders;

//UIなどを管理するスクリプト
public class GameDirector : MonoBehaviour
{
    [SerializeField]
    private GameObject finish;

    //ポイントを入れるテキスト
    GameObject killmater;

    //タイマーを入れるテキスト
    GameObject timer;

    //倒した数を入れる変数
    int kill = 0;

    //時間を測る変数
    public static float time = 0;
    public void Gekitui()
    {
        //kill変数をプラス1
        ++this.kill;
    }

    //クリアシーンに移動
    public void Clear()
    {
        SceneManager.LoadScene("ClearScene");
    }

    void Start()
    {
        //テキストを探す
        this.killmater = GameObject.Find("Kill");
        this.timer = GameObject.Find("Timer");
    }

    void Update()
    {
        //倒した数がクリア目標になったら
        if (kill == 8)
        {
            //音楽を止める
            GetComponent<AudioSource>().Stop();

            //テキストを表示
            finish.SetActive(true);

            //３秒後に関数を呼び出す
            Invoke("Clear", 3.0f);
        }
        else
        {
            //時間を増やす
            time += Time.deltaTime;
        }

        //倒した数をテキストに表示
        this.killmater.GetComponent<TextMeshProUGUI>().text =
            this.kill.ToString() + "kill";

        //時間をテキストに表示
        this.timer.GetComponent<TextMeshProUGUI>().text =
            "Time:" + time.ToString("F2");
    }
}
