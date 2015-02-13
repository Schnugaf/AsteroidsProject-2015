using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

    public float spawnRate = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (spawnRate >= 10)
        {
            transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
            Instantiate(Astroid1, new Vector3(x, y, 0), Quaternion.identity);
            spawnRate = 0;
        }
	
	}
}
