using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject nextObstacle;
    public GameObject thisObstacle;
    private Vector3 nextObstaclePosition;
    public Score scoreScript;
    void Awake()
    {
        nextObstaclePosition = new Vector3(Random.Range(-6.5f, 6.5f), 1.375f, thisObstacle.transform.position.z + 210);
    }

    void OnTriggerEnter(Collider col){
        if (col.tag == "Player"){
            scoreScript.score += 1;
            Destroy(thisObstacle);
            Instantiate(nextObstacle, nextObstaclePosition, thisObstacle.transform.rotation);
        }
    }
}
