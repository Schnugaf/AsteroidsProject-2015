using UnityEngine;
using System.Collections;

public class ResumeGameLoader : MonoBehaviour {

    public int SceneLevel = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gameStart()
    {
        Application.LoadLevel("Level1");
        Debug.Log("Scene Start");
    }

    public void resumeScene()
    {
        Application.LoadLevel("Level" + SceneLevel);
    }
}