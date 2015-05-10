using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
    public int antallBakterier = 0;
    public int totalBakterier = 10;
    public int spawnRate = 10;
    public GameObject[] bakterier;
    private int startCount = 0;
    private GameObject clone;
    private int bakterieCount;
    public GameObject VinnScenario;
    public GameObject[] BakterieDelete;
    private bool CheckWin;
	public Transform[] SpawnTransformArray;
	// Use this for initialization
	void Start () {
		startBakterie ();
	}
	
	// Update is called once per frame
	void Update () {
        startBakterie();
        bakterieSpawn();
        bakterieCount = GameObject.FindGameObjectsWithTag("Astroid").Length;
        //Debug.Log(bakterieCount);

        if(bakterieCount > 4)
        {
            //Debug.Log("Sweeeeeet!");
            CheckWin = true;
        }

        if(Input.GetKeyDown ("w"))
        {
            BakterieDelete = GameObject.FindGameObjectsWithTag("Astroid");
            for (int i = 0; i < BakterieDelete.Length; i++)
                Destroy(BakterieDelete[i]);
			VinnFunksjon();
        }
        
        if(CheckWin == true)
        {
            VinnFunksjon();
        }

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

	int RandomTransform()
	{
			System.Random rand = new System.Random ();
			return rand.Next (0, SpawnTransformArray.Length);
	}
    
    int SpawnRate()
    {
        System.Random rand = new System.Random();
        return rand.Next(0, spawnRate + 1);
    }

    /*int SpawnTransformX()
    {
        System.Random rand = new System.Random();
        return rand.Next(1, Screen.width);
    }
    int SpawnTransformY()
    {
        System.Random rand = new System.Random();
        return rand.Next(1, Screen.height);
    }*/

    private void startBakterie()
    {
		Transform location = SpawnTransformArray [RandomTransform ()];
        if (startCount < 4)
        {
            startCount++;
			GameObject clone = Instantiate(bakterier[RandomNumber()], location.position, Quaternion.identity) as GameObject;
            antallBakterier++;

        }
    }

    private void bakterieSpawn()
	{	Transform location = SpawnTransformArray [RandomTransform ()];
        if (SpawnRate() == spawnRate && antallBakterier < totalBakterier)
        {
			GameObject clone = Instantiate(bakterier[RandomNumber()], location.position, Quaternion.identity) as GameObject;
            antallBakterier++;
        }

    }

    private void VinnFunksjon()
    {
        if (bakterieCount == 0)
        {
            GameObject clone = Instantiate(VinnScenario) as GameObject;
        }
    }

}
