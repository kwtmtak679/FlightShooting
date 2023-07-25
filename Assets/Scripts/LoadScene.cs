using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("StageScene");
    }

    public void Title()
    {
        SceneManager.LoadScene("GameTitle");
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
