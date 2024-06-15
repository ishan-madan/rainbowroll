using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManaging : MonoBehaviour
{
    public void Easy(){
        SceneManager.LoadScene("Easy");
    }

    public void Normal(){
        SceneManager.LoadScene("Normal");
    }

    public void Hard(){
        SceneManager.LoadScene("Hard");
    }

    public void Impossible(){
        SceneManager.LoadScene("Impossible");
    }

    public void Controls(){
        SceneManager.LoadScene("ControlsScreen");
    }

    public void Home(){
        SceneManager.LoadScene("Home");
    }
}
