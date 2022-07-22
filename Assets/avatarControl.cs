using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avatarControl : MonoBehaviour
{


    Vector3 mousePos; //to record mouse position
    Vector3 charcAng; //to record avatar orientation

    // Start is called before the first frame update
    void Start()
    {
        charcAng = transform.eulerAngles;
        //top level self avatar must have rigidbody and a proper collider!!
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up") || Input.GetKey("w")) // go forward!
        { transform.position = Vector3.Lerp(transform.position, transform.position + transform.forward * 0.1f, 0.9f); }

        if (Input.GetKeyDown("space")) //jump
        {
  
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x  , transform.position.y +0.8f,
                transform.position.z), 1f);
        }

        if ((Input.mousePosition.y - mousePos.y) > 1) //1 or -1 is the sensitivity you can re define
        {
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3((transform.eulerAngles.x + 0.2f), transform.eulerAngles.y, transform.eulerAngles.z),
            0.5f); // look up or lean forward
        }
        else if ((Input.mousePosition.y - mousePos.y) < -1)
        {
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3((transform.eulerAngles.x - 0.2f), transform.eulerAngles.y, transform.eulerAngles.z),
            0.5f); // look up or lean forward
        }
        if ((Input.mousePosition.x - mousePos.x) > 1)
        {
            transform.eulerAngles = Vector3.Lerp(charcAng, new Vector3(charcAng.x, (charcAng.y + 1.5f), charcAng.z),
            0.5f); // look left and right
        }
        else if ((Input.mousePosition.x - mousePos.x) < -1)
        {
            transform.eulerAngles = Vector3.Lerp(charcAng, new Vector3(charcAng.x, (charcAng.y - 1.5f), charcAng.z),
              0.5f); // look left and right

        }
        charcAng = transform.eulerAngles;
        mousePos = Input.mousePosition;
    }
}
