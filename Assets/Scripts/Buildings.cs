using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biding : MonoBehaviour
{
    public void OnCollisionEnter(Collision atatta)
    {
        //もしドローンに当たったオブジェクトのTagが「Tama」だったら
        if (atatta.gameObject.tag == "Enemy2")
        {
            //ドローンが当たった建物を消す
            Destroy(this.gameObject);

        }
    }
}
