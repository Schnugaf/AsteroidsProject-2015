using UnityEngine;
using System.Collections;

public class Astroid : MonoBehaviour {

	public float speed = 15f;
	public float rotationSpeed = 3f;


	// Use this for initialization
	void Start () {
		rigidbody2D.AddTorque(rotationSpeed);

		rigidbody2D.AddForce(new Vector2(3f*speed, -5f*speed));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
    //void SpaceInfinityLoop()
    //{

    //    if (transform.position.x >= Screen.width/2)
    //        transform.position = new Vector3( Screen.width/2 * -1 + 1, transform.position.y, 0f);
    //    if (transform.position.y > Screen.height/2)
    //        transform.position = new Vector3(transform.position.x, Screen.height/2 *-1 + 1, 0f);
    //    if (transform.position.x < Screen.width/2 * -1)
    //        transform.position = new Vector3(Screen.width/2 - 1, transform.position.y, 0f);
    //    if (transform.position.y < Screen.height/2 * -1)
    //        transform.position = new Vector3(Screen.height/2 - 1, Screen.height - 1, 0f);
    //}

    #region Bullet Collision
    /*void OnCollisionEnter2D (Collision2D col){

        if(col.gameObject.tag == "Bullet")
        {
            Destroy(col.gameObject);

            if (transform.localScale.x == 1)
            {
                transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
                Instantiate(this, new Vector2(this.transform.position.x+1.3f, this.transform.position.y+0.2f), 
                            this.transform.rotation);
            }
            else
                Destroy(this.gameObject);
        }
    
    }
 */
    #endregion

    void TouchCollide(Collision2D col)
    {
        if (Input.touchCount == 1)
            {
            Debug.Log ("Touch registered");
                Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                Vector2 touchPos = new Vector2(wp.x, wp.y);
                if (collider.gameObject == Physics2D.OverlapPoint(touchPos))
                    {
                        Destroy(col.gameObject);
                    }
            }
    }

}
