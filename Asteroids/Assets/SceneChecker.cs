using UnityEngine;
using System.Collections;

public class SceneChecker : MonoBehaviour {
	public int CurrLvl;
	public static SceneChecker InstantiatedLevel;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject);
		InstantiatedLevel = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int CurrentLevel()
	{
		 if (SpawnScript.InstantiatedTicker.yay == true);
		{
						CurrLvl = CurrLvl + 1;
						return CurrLvl;
				}

	}
}
