using UnityEngine;
using System.Collections;

public class CelleHealth : MonoBehaviour {

	public GameObject[] CelleAnimState;
	private GameObject clone;
	public int Health;
	private int LastHealth;

	// Use this for initialization
	void Start () {
		Health = 3;
		LastHealth = Health;
		CheckHealth();
	
	}
	
	// Update is called once per frame
	void Update () {
		HjerteSpawn ();

	}



	void CheckHealth (){
				if (Health == 3) {
						GameObject clone = Instantiate (CelleAnimState [0]);
				}
				if (Health == 2) {
						
						GameObject clone = Instantiate (CelleAnimState [1]);
				}
				if (Health == 1) {
						GameObject clone = Instantiate (CelleAnimState [2]);
				}
				if (Health <= 0) {
						GameObject clone = Instantiate (CelleAnimState [3]);
					if(Input.GetMouseButtonDown(0))
						Application.LoadLevel ("losescenario");
				}
				
		}

	void OnTriggerEnter2D(Collider2D Astroid) 
	{
		Health --;
		Destroy(GameObject.FindWithTag("Astroid"));
		if (Health != 0) 
		{
			Destroy (GameObject.FindWithTag ("Hjerte"));
		}
	}


	void HjerteSpawn() {
				if (Health != LastHealth) {
						CheckHealth ();
						LastHealth = Health;
				}
		}

}