using UnityEngine;
using System.Collections;

public class ScoreCounter : MonoBehaviour {
	public int _CurrentScore;
	public static ScoreCounter InstanceScore;
	public int addPoints;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject);
		InstanceScore = this;
		addPoints = Astroid.Instance.tenPoints();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int checkPoints()
	{
		_CurrentScore = _CurrentScore + addPoints;
		
			return _CurrentScore;
	}
}
