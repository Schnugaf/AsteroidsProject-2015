using UnityEngine;
using System.Collections;

public class TouchCheck : MonoBehaviour {
    public int Snr;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        


        if(Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("Level2");
        }

        if (Input.GetKeyDown("e"))
        {
            Application.LoadLevel("Level2");
        }
        }
	
	}
