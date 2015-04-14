using UnityEngine;
using System.Collections;

public class CreditsLoader : MonoBehaviour {

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
        Application.LoadLevel("CreditsScene");
        Debug.Log("Scene Start");
    }
}