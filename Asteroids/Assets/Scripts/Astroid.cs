﻿using UnityEngine;
using System.Collections;

public class Astroid : MonoBehaviour {

	private float speed = 0.005f;
	public float rotationSpeed = 3f;
    public Transform Splash;
    public int endgameTest = 4;
    public GameObject splashScreen;
    private GameObject clone;
    //public GameObject Celle;
    private bool hitcheck = false;
    public float TyngdeKraft;
	public Transform Celle;

	// Use this for initialization
	void Start () {

		GetComponent<Rigidbody2D>().AddTorque(rotationSpeed);



	}
	
	// Update is called once per frame
	void Update () {
        int fingerCount = 0;
		GetComponent<Rigidbody2D>().AddForce((Celle.position - transform.position) * speed);

        foreach (Touch touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended || touch.phase != TouchPhase.Canceled)
            {
                fingerCount++;

                if (fingerCount == 1 && touch.phase != TouchPhase.Began)
                {
                    Debug.Log("touch registered");
                    Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                    Vector2 touchPos = new Vector2(wp.x, wp.y);
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && hitcheck == false)
                    {

                      /*  if (transform.localScale.x == 1)
                        {
                            transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
                            Instantiate(this, new Vector2(this.transform.position.x + 1.3f, this.transform.position.y + 0.2f),
                                        this.transform.rotation);
                        }
                        else
                       */
                            Destroy(this.gameObject);
                            GameObject clone = Instantiate(splashScreen, new Vector3(touchPos.x, touchPos.y, 10), Quaternion.identity) as GameObject;
                            hitcheck = true;
                    }
                }
            }
            if (touch.phase == TouchPhase.Ended)
            {
                hitcheck = false;
            }
        }

	}
  /*  public void FixedUpdate()
    {
        float magsqr;
        Vector3 offset;
        offset = Celle.transform.position - transform.position;
        offset.z = 0;
        magsqr = offset.sqrMagnitude;
        if (magsqr > 0.0001f)
        {
            GetComponent<Rigidbody2D>().AddForce((TyngdeKraft * offset.normalized / magsqr));
        }
    }
   */
}
