using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jam : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Jam_blue")
        {
            Debug.Log("touch_blue");
        }
        if (other.gameObject.name == "Jam_red")
        {
            Debug.Log("touch_red");
        }
        if (other.gameObject.name == "Jam_green")
        {
            Debug.Log("touch_green");
        }
        if (other.gameObject.name == "Jam_yellow")
        {
            Debug.Log("touch_yellow");
        }
    }
}
