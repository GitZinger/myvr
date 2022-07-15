using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.left;
        //rb.transform.Translate()
    }
}
