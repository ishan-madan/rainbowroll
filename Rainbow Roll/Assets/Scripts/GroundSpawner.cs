using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    
    public GameObject currentFloor;
    public GameObject floor;
    private Vector3 position;

    void Awake() {
        position = currentFloor.transform.position + new Vector3(0, 0, 300);
    }

    void OnTriggerEnter(Collider col){
        if (col.tag == "Player"){
            Instantiate(floor, position, transform.rotation);
        }
    }



}
