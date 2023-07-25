using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RandomMovement : MonoBehaviour
{
    private float chargeTime = 3.0f;
    private float timeCount;
    private float speed = 0.05f;
    void Update()
    {
        timeCount += Time.deltaTime;
        // �����O�i
        transform.position += transform.forward * speed;
        // �w�莞�Ԃ̌o�߁i�����j
        if (timeCount > chargeTime)
        {
            // �i�H�������_���ɕύX����
            Vector3 course = new Vector3(0, Random.Range(0, 180), 0);
            transform.localRotation = Quaternion.Euler(course);
            // �^�C���J�E���g���O�ɖ߂�
            timeCount = 0;
        }
    }
}