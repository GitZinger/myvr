using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miceclick : MonoBehaviour
{

    public Material blue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if( Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hit) &&  Input.GetMouseButtonDown(0))
        {

            hit.transform.gameObject.GetComponent<Renderer>().material = blue;
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();
        }

        
    }
}
