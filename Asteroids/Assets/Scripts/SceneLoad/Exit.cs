using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class Exit : MonoBehaviour {



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

	public void backToMenu()
	{
		PlayerPrefs.SetInt ("Level", SceneChecker.InstantiatedLevel.CurrLvl); //Lagre nåværende level som int i seperat fil for å kunne kalles opp.
		PlayerPrefs.Save ();
		Application.LoadLevel (0);
		}
}