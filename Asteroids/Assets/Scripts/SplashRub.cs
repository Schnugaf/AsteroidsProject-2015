using UnityEngine;
using System.Collections;

public class SplashRub : MonoBehaviour {

    public float SplashHealth = 100;
    public float RubDamageRate = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



        foreach (Touch touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended || touch.phase != TouchPhase.Canceled)
            {

                if (touch.phase != TouchPhase.Began)
                {
                    Debug.Log("touch registered");
                    Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                    Vector2 touchPos = new Vector2(wp.x, wp.y);

                   // if (collider2D == Physics2D.OverlapPoint(touchPos) && touch.position != touch.deltaPosition)
                    if (touch.phase == TouchPhase.Moved)
                    {
                        SplashHealth -= (RubDamageRate * Time.deltaTime);
                        Debug.Log("Health Lost");

                        if (SplashHealth <= 0)
                        {
                            Destroy(this.gameObject);
                        }

                    }
                }
            }
        }

	}
}
