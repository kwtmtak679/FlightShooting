using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//ドローンを壊すためのスクリプト
public class DroneBreak : MonoBehaviour
{
    //ゲームディレクターの値を入れる
    GameObject director;

    //球が当たった時に消す操作
    public void OnCollisionEnter(Collision atatta)
    {
        //もしドローンに当たったオブジェクトのTagが「Tama」だったら
        if (atatta.gameObject.tag == "Tama")
        {
            //当たった球とドローンを消す
            Destroy(atatta.gameObject);
            Destroy(this.gameObject);

            //敵を倒した数に一点プラス
            this.director.GetComponent<GameDirector>().Gekitui();
        }
    }

    void Start()
    {
        //ゲームディレクターを探して値をとる
        this.director = GameObject.Find("GameDirector");
    }

    void Update()
    {
        
    }
}
