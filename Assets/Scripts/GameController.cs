using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] jam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            int position = Random.Range(-30, 30);
            int color = Random.Range(0, 5);
            Instantiate(jam[color], new Vector3(position, 10, 0), Quaternion.identity);
    }
    
}
