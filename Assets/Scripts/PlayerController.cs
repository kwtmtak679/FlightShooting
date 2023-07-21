using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //プレイヤーが何かに衝突したとき
    private void OnCollisionEnter(Collision player)
    {
        //町の建造物に当たったら
        if(player.gameObject.tag=="Mati")
        {
            //ヘリを消す
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        //進む
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, 0, 0.05f);
        }
        //左に曲がる
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -0.3f, 0);
        }
        //右に曲がる
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0.3f, 0);
        }
        //上に行く
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(0, 0.03f, 0);
        }
        //下に行く
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(0, -0.03f, 0);
        }
    }
}