﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointsGUI : MonoBehaviour {
	public int _Score;
	Text Pointstring;

	// Use this for initialization
	void Start () {
		 Pointstring = GetComponent<Text> ();
		_Score = ScoreCounter.InstanceScore.checkPoints();

	}
	
	// Update is called once per frame
	void Update () {
		Pointstring.text = "" + _Score;
	}


}
