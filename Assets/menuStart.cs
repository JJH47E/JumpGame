﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class menuStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.UnloadSceneAsync("SampleScene");
        SceneManager.UnloadSceneAsync("gameOver");
        PlayerPrefs.SetInt("Hi", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
