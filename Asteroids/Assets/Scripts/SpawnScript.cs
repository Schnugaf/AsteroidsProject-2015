using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
    public int antallBakterier = 0;
    public int totalBakterier = 10;
    public int spawnRate = 10;
    public GameObject[] bakterier;
    private int startCount = 0;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        startBakterie();
        bakterieSpawn();
	}

  /*  private GameObject getBakterie()
    {
        return bakterier[Random.Range(0, bakterier.Length - 1)];
    }
   */

    int RandomNumber()
    {
        System.Random rand = new System.Random();
        return rand.Next(0, bakterier.Length);
    }
    
    int SpawnRate()
    {
        System.Random rand = new System.Random();
        return rand.Next(0, spawnRate);
    }

    private void startBakterie()
    {
        if (startCount < 4)
        {
            startCount++;
            GameObject clone = Instantiate(bakterier[RandomNumber()]) as GameObject;
            antallBakterier++;

        }
    }

    private void bakterieSpawn()
    {
        if (SpawnRate() == spawnRate && antallBakterier < totalBakterier)
        {
            GameObject clone = Instantiate(bakterier[RandomNumber()]) as GameObject;
            antallBakterier++;
        }

    }

}
