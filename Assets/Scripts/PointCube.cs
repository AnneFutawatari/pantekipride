using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCube : MonoBehaviour
{
    GameObject scoreManagerObject;

    // Start is called before the first frame update
    void Start()
    {
        scoreManagerObject = GameObject.Find("ScoreManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            scoreManagerObject.GetComponent<ScoreManager>().ScorePlus();
            Destroy(gameObject);
        }
    }
}