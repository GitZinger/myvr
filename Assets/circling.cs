using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circling : MonoBehaviour
{
    public GameObject center;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(center.transform.position, Vector3.up, 20 * Time.deltaTime);
    }
}
