using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {
    public int SceneLevel = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gameEnd()
    {
        Application.Quit();
        Debug.Log("GameEnded");
    }
}