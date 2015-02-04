using UnityEngine;
using System.Collections;

public class ScreenLoop : MonoBehaviour {

    private Camera gameCamera = null;

    private Rect rectCamLocal;
    private Vector3 camRecBottomLeft;
    private Vector3 camRecTopRight;

    // Use this for initialization
    void Start()
    {

        gameCamera = Camera.main;

    }

    // Update is called once per frame

    void Update()
    {

    }

    void LateUpdate()
    {

        Vector3 pos = transform.position;

        //Lager ett rektangel som bestemmer skjermens grenser basert på Main Camera.
        rectCamLocal = gameCamera.pixelRect;
        camRecBottomLeft = gameCamera.ScreenToWorldPoint(new Vector3(rectCamLocal.x, rectCamLocal.y, gameCamera.nearClipPlane));
        camRecTopRight = gameCamera.ScreenToWorldPoint(new Vector3(rectCamLocal.x + rectCamLocal.width, rectCamLocal.y + rectCamLocal.height, gameCamera.nearClipPlane));

        #region If Statements for Object Position
        //If setninger som ser etter hvilken vegg objektet treffer

        if (transform.position.x > camRecTopRight.x)
        {
            pos.x = camRecBottomLeft.x + 0.1f;
        }


        if (transform.position.x < camRecBottomLeft.x)
        {
            pos.x = camRecTopRight.x - 0.1f;
        }

        if (transform.position.y > camRecTopRight.y)
        {
            pos.y = camRecBottomLeft.y + 0.1f;
        }


        if (transform.position.y < camRecBottomLeft.y)
        {
            pos.y = camRecTopRight.y - 0.1f;
        }
#endregion 
        transform.position = pos;
    }
}
