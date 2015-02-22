using UnityEngine;
using System.Collections;

public class Astroid : MonoBehaviour {

	public float speed = 15f;
	public float rotationSpeed = 3f;
    public Transform Splash;


	// Use this for initialization
	void Start () {

		rigidbody2D.AddTorque(rotationSpeed);

		rigidbody2D.AddForce(new Vector2(Random.Range(180.0F, -180.0F)*speed, Random.Range(180.0F, -180.0F)*speed));
	}
	
	// Update is called once per frame
	void Update () {
        int fingerCount = 0;


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
                    if (collider2D == Physics2D.OverlapPoint(touchPos))
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
                            GameObject go = (GameObject)Instantiate(Resources.Load("SplashPlaceHolder"));

                    }
                }
            }
        }

	}

}
