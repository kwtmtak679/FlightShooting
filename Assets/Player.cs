using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0, 1, 0);
        }
    }
}
