using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointController : MonoBehaviour
{
    [SerializeField]
    private float hp = 5;

    private void OnTriggerEnter(Collider collition)
    {
        if (collition.gameObject.tag == "PointCube")
        {
            hp += collition.gameObject.GetComponent<PointCubeManager>().PointCube;
            Debug.Log("hit Player");
        }
    }
}
