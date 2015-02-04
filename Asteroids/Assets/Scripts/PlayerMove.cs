#region Obligatorisk meme
//#
//# ░░░░░░░░░░░░▄▐
//# ░░░░░░▄▄▄░░▄██▄
//# ░░░░░▐▀▀▀▌░░░░▀█▄
//# ░░░░░▐███▌░░░░░░▀█▄
//# ░░░░░░▀█▀░░░▄▄▄▄▄▀▀
//# ░░░░▄▄▄██▀▀▀▀
//# ░░░█▀▄▄▄█░▀▀
//# ░░░▌░▄▄▄▐▌▀▀▀
//# ▄░▐░░░▄▄░█░▀▀ U HAVE BEEN SPOOKED BY THE
//# ▀█▌░░░▄░▀█▀░▀
//# ░░░░░░░▄▄▐▌▄▄
//# ░░░░░░░▀███▀█░▄
//# ░░░░░░▐▌▀▄▀▄▀▐▄ CYBER SKILENTON FROM THE YEAR 3030
//# ░░░░░░▐▀░░░░░░▐▌
//# ░░░░░░█░░░░░░░░█
//# ░░░░░▐▌░░░░░░░░░█
//# ░░░░░█░░░░░░░░░░▐▌ SEND THIS TO 7 LIFE FORMS OR TIME TRAVELING SKELINTONS WILL BLAST YOU WITH THEIR PHASERS 
#endregion

using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    #region Variables
    public float speed = 8f;
	public float rotationSpeed = 3f;

	public int touchWidth = 150;

	public GameObject bullet;
	public Transform shotSpawn;

	public float fireRate = 0.5f;
	private float nextFire = 0.0f;
	
	private float deltaRotation = 0f;

    #endregion


    #region Start & Update
    // Use this for initialization
	void Start () {
//		TestClass mTest = new TestClass();
//
//		TestClass mTest2 = mTest;
//
//		TestClass mTest3 = new TestClass();
//
//		mTest2.mVar = 3.4f;
//		mTest3.mVar = 8.2f;
//
//		print (mTest.TestFunction());
//		print (mTest2.TestFunction());
//		print (mTest3.TestFunction());
//
//		print (mTest.Multiplisere(5));
//		print (mTest.Multiplisere(3.0f));
	}
	
	// Update is called once per frame
	void Update () {
	
		//deltaRotation = -Input.GetAxis("Horizontal");
		deltaRotation = -Input.acceleration.x;

		if (deltaRotation < -0.1 || deltaRotation > 0.1)
		{
			rigidbody2D.AddTorque(deltaRotation*rotationSpeed*Time.deltaTime);
		}

		//if (Input.GetAxis("Vertical")> 0)  
		//if (Input.GetKey(KeyCode.UpArrow))



		foreach(Touch touch in Input.touches)
		{
			if (touch.position.x < touchWidth)
			{
				rigidbody2D.AddForce(new Vector2(Mathf.Cos(Deg2Rad(transform.eulerAngles.z))*speed*Time.deltaTime,
			                                 Mathf.Sin(Deg2Rad(transform.eulerAngles.z))*speed*Time.deltaTime));
			}

			//if (Input.GetButton("Fire1") && Time.time > nextFire)
			if (touch.position.x > Screen.width-touchWidth && Time.time > nextFire)
			{
				nextFire = Time.time + fireRate;
				Instantiate(bullet, shotSpawn.position, shotSpawn.rotation);
			}
			//print("x: " + touch.position.x + "y: " + touch.position.y);
		}
	}

    #endregion

    #region Collision and Loop
    //void OnTriggerExit2D()
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.name == "TopTrigger")
			transform.position = new Vector3(transform.position.x, transform.position.y-18f, 0f);
		if (col.name == "BottomTrigger")
			transform.position = new Vector3(transform.position.x, transform.position.y+18f, 0f);
		if (col.name == "LeftTrigger")
			transform.position = new Vector3(transform.position.x+32f, transform.position.y, 0f);
		if (col.name == "RightTrigger")
			transform.position = new Vector3(transform.position.x-32f, transform.position.y, 0f);

		//Virker ikke fordi Astroid ikke er en Trigger!
		//if(col.name == "Astroid1")
		//	print ("Kollisjon");
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "Astroid")
		{
			print("Player exploded");
		}

	}
    #endregion

    float Deg2Rad(float degIn)
	{
		return ((degIn) * Mathf.PI/180);
	}
}

#region Slutt meme
//# ░▄▄▄▄▄▄
//# ▐▀▀████▌ U HAVE BEEN VISITED BY THE
//# ▀░▐██████▄ EMBARRASSED BANANA OF HILARITY
//# ░░▌▄▄▄░▄▄▐
//# ░░▌░▄▄░▄▄▄▌
//# ░▐░░▀▀▀▀▀▀░▌
//# ░▌░░░░░░░░░░▌
//# ░▐░█▀▀▀▀▀▀▀█▐
//# ░▐░░▀▄▄▄▄▄▀░▌░░░▄▄█▄
//# ░▐░░░░░░░░░▐▄▄▄▄▀▀▀▄
//# ░▐░░░░░░░░░▐░░░░░▐░░▌▄▄▄
//# ░░█░░░░░░░░▐░░░░░▐░░▐▐░░▌░░░░░░░░▄██▀▀▄▄
//# ░░▐░▌░░░░░░▐░░░░░░▌░░▐▌░▌▄░░░░░▄▄█░
//# ░░░█░▌░░░░░▐░░░░░░▐░░▐▐░░▀▄▄▀▀▀▀░
//# ░░░░█░▌░░░░▐░░░░░░░▐░░▌▐▄░░░▀▄░
//# ░░░░░█▀▄▄▄░▌░░░░░░░▐░░░▐▄▀▄░░░▀▄░
//# ░░░░░░▀████▌░░░░░░░▐░▌░░░▐▄▀▄▄░░▀▀▄▄▄▀▀▀▀
//# ░░░░░▐█▌▀▀▄▄░░░░░░░░▌░▌░░░░▌▄▄▀▀▀▀▄▄
//# ░░░░▐█▀░░░░▀▌░░░░░░░▀▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
//# ░░░▐█▌░░░░▄▄█▌░░░░░░░░░░░░░░░░░░░░░░▀
//# ░░░░▀▀▀░ Good Luck & Prosperity will come to you,
//# ░░░░░░░░ but only if you say:
//# ░░░░░░░░ i really really like this meme 
#endregion