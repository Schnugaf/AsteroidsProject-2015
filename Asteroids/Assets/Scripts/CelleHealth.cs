using UnityEngine;
using System.Collections;

public class CelleHealth : MonoBehaviour {

	public GameObject[] CelleAnimState; //Array for animasjoner
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

	IEnumerator WaitForEnd()
	{
				yield return new WaitForSeconds (4f);
		}
	#region Sjekk health, instansier ny hjerte animasjon.

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
						StartCoroutine ("WaitForEnd");
						Application.LoadLevel ("losescenario");
				}
		}
	#endregion
	#region Kolliderer med Bakterier? Ødelegg hjerte.
	void OnTriggerEnter2D(Collider2D Astroid) 
	{
		Health --;
		Destroy(GameObject.FindWithTag("Astroid"));
		if (Health != 0) 
		{
			Destroy (GameObject.FindWithTag ("Hjerte"));
		}
	}
	#endregion


	void HjerteSpawn() {
				if (Health != LastHealth) {
						CheckHealth ();
						LastHealth = Health; //Sjekk helse når det er forandring i helse.
				}
		}

}