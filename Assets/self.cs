using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class self : MonoBehaviour
{
    float end;
    // Start is called before the first frame update
    void Start()
    {
        
        end = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
        if((Time.time - end ) > 3)
        {
            print(Time.time);
            GameObject.Destroy(this.gameObject);
        }    
    }
}
