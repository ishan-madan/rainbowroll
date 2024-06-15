using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool ended = false;
    public void EndGame(){
        if (ended == false){
            ended = true;
            Invoke("Restart", 2.2f);
        }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
