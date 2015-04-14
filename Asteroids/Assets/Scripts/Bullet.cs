using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 170f;
	public float lifespan = 10f;

	// Use this for initialization
	void Start () {
		//rigidbody2D.velocity = transform.forward*speed;
		//new Vector2(Mathf.Cos(Deg2Rad(transform.eulerAngles.z))*speed,
		//                                 Mathf.Sin(Deg2Rad(transform.eulerAngles.z))*speed);
		GetComponent<Rigidbody2D>().AddForce(new Vector2(Mathf.Cos(Deg2Rad(transform.eulerAngles.z))*speed,
		                                   Mathf.Sin(Deg2Rad(transform.eulerAngles.z))*speed));
	}

	// Update is called once per frame
	void Update () {

		lifespan -= Time.deltaTime;

		if(lifespan < 0)
			Destroy(this.gameObject);
	}

	void OnTriggerEnter2D(Collider2D colIn)
	{
		if (colIn.name == "TopTrigger")
			transform.position = new Vector3(transform.position.x, transform.position.y-18f, 0f);
		if (colIn.name == "BottomTrigger")
			transform.position = new Vector3(transform.position.x, transform.position.y+18f, 0f);
		if (colIn.name == "LeftTrigger")
			transform.position = new Vector3(transform.position.x+32f, transform.position.y, 0f);
		if (colIn.name == "RightTrigger")
			transform.position = new Vector3(transform.position.x-32f, transform.position.y, 0f);
	}

	float Deg2Rad(float degIn)
	{
		return ((degIn) * Mathf.PI/180);
	}
}
