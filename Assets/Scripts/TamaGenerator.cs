using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TamaGenerator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Tamanohassyabasyo")]
    private GameObject firingPoint;
    [SerializeField]
    [Tooltip("弾")]
    private GameObject bullet;
    [SerializeField]
    [Tooltip("弾の速さ")]
    private float speed = 30f;
    // Update is called once per frame
    void Update()
    {
        // 左クリックしたかを判定
        if (Input.GetMouseButtonDown(0))
        {
            // 弾を発射する
            LauncherShot();
        }
    }
    /// <summary>
	/// 弾の発射
	/// </summary>
    private void LauncherShot()
    {
        // 弾を発射する場所を取得
        Vector3 bulletPosition = firingPoint.transform.position;
        // 上で取得した場所に、"bullet"のPrefabを出現させる
        GameObject newBall = Instantiate(bullet, bulletPosition, transform.rotation);
        // 出現させたボールのforward(z軸方向)
        Vector3 direction = newBall.transform.up;
        // 弾の発射方向にnewBallのz方向(ローカル座標)を入れ、弾オブジェクトのrigidbodyに衝撃力を加える
        newBall.GetComponent<Rigidbody>().AddForce(direction * speed, ForceMode.Impulse);
        // 出現させたボールの名前を"bullet"に変更
        newBall.name = bullet.name;
        // 出現させたボールを1.5秒後に消す
        Destroy(newBall, 1.5f);
    }
}