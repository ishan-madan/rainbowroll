using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDeleter : MonoBehaviour
{
    public GameObject currentFloor;

    

    void OnTriggerEnter(Collider col){
        if (col.tag == "Player"){
            Destroy(currentFloor);
        }
    }
}
