using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicked : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
             
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log("Input.mousePosition");
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                // whatever tag you are looking for on your game object
                if (hit.collider.tag == "Trigger")
                {
                    Debug.Log("---> Hit: ");
                }
            }
        }
    }
}