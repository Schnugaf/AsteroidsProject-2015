using UnityEngine;
using System.Collections;

public class SceneLoader : MonoBehaviour
{

	public int SceneLevel;
	public bool _thisIsAState;

    // Use this for initialization
    void Start()
    {
		SceneLevel = SceneChecker.InstantiatedLevel.CurrentLevel();
    }

    // Update is called once per frame
    void Update()
    {
		if (Application.loadedLevelName == "winscenario");
		{
				_thisIsAState = true;
		}

    }

    public void gameStart()
    {
        Application.LoadLevel(1);
        Debug.Log("Scene Start");
    }

	public void gameContinue()
	{
		Application.LoadLevel (PlayerPrefs.GetInt ("Level"));
	}

	public void StateChange()
	{

						Application.LoadLevel (SceneLevel);
		}
	public void _backToMenu()
	{
				Application.LoadLevel (0);
	}
}
