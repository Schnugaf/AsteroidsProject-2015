using UnityEngine;
using System.Collections;

public class CellDamage : MonoBehaviour {

    public float CellHealth = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        HealthCheck();
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
            coll.gameObject.SendMessage("ApplyDamage", 10);
            CellHealth -= 100;
    }

    void HealthCheck()
    {
        if (CellHealth <= 0)
        {

        }
    }
}
