using UnityEngine;
using System.Collections;

public class SceneLoader : MonoBehaviour
{

    public int SceneLevel = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		Application.LoadLevel (SceneLevel);
    }

    public void gameStart()
    {
        Application.LoadLevel(SceneLevel);
        Debug.Log("Scene Start");
    }
}
