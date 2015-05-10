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

    }

    public void gameStart()
    {
        Application.LoadLevel(1);
        Debug.Log("Scene Start");
    }

	public void StateChange()
	{
				if (SceneLevel > 0 && _thisIsAState == true) {
						Application.LoadLevel (SceneLevel);
				}
		}
}
