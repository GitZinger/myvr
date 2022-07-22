using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reloading : MonoBehaviour
{
    public GameObject that;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            print("waht");
            GameObject t = Instantiate(that, Vector3.zero,Quaternion.identity);
            t.GetComponent<Rigidbody>().AddForce(transform.forward);

        }

        if (Input.GetKeyDown("k"))
        {
            SceneManager.LoadScene("SampleScene"); //restart everything during runtime
        }
    }
}
