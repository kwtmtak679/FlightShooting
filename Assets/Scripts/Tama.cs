using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tama : MonoBehaviour
{
    private void OnCollisionEnter(Collision gekitotsu)
    {
        if(gekitotsu.gameObject.tag=="Enemy2")
        {
            GetComponent<AudioSource>().Play();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
