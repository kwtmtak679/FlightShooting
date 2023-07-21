using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneBreak : MonoBehaviour
{
    //球が当たった時に消す操作
    private void OnCollisionEnter(Collision atatta)
    {
        //もしドローンに当たったオブジェクトのTagが「Tama」だったら
        if (atatta.gameObject.tag == "Tama")
        {
            //当たった球とドローンを消す
            Destroy(atatta.gameObject);
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
