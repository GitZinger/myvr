using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gen : MonoBehaviour
{


    public GameObject cub;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //    this.gameObject.SetActive(!this.gameObject.activeSelf);
        //    this.gameObject.SetActive(false);
    }


    void OnGUI()
    {
        Event currentEvent = Event.current;

        if (currentEvent.type == EventType.MouseDown && currentEvent.button == 0)
        {
            Vector3 point = new Vector3();
            
            Vector2 mousePos = new Vector2();

            // Get the mouse position from Event.
            // Note that the y position from Event is inverted.
            mousePos.x = currentEvent.mousePosition.x;
            mousePos.y = Camera.main.pixelHeight - currentEvent.mousePosition.y;

            point = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane));
            Instantiate(cub, point, Quaternion.identity);

        }
    }

}
