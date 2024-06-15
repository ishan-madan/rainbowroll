using UnityEngine;
using UnityEngine.UI;

public class MusicControls : MonoBehaviour
{
    public AudioSource music;
    private int[] song = new int[10] {0, 242, 496, 716, 928, 1191, 1530, 1723, 1925, 2143};
    public Sprite playImage;
    public Button button;
    bool playing = true;
    GameObject myEventSystem;

    void Awake(){
        myEventSystem = GameObject.Find("EventSystem");
        music.time = song[(int)(Random.Range(0, 8.99f))];
    }



    public void nextSong()
    {

        if (music.time < song[1])
        {
            music.time = song[1];
        }
        else if (music.time < song[2])
        {
            music.time = song[2];
        }
        else if (music.time < song[3])
        {
            music.time = song[3];
        }
        else if (music.time < song[4])
        {
            music.time = song[4];
        }
        else if (music.time < song[5])
        {
            music.time = song[5];
        }
        else if (music.time < song[6])
        {
            music.time = song[6];
        }
        else if (music.time < song[7])
        {
            music.time = song[7];
        }
        else if (music.time < song[8])
        {
            music.time = song[8];
        }
        else if (music.time < song[9])
        {
            music.time = song[0];
        }
        myEventSystem .GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
    }

    public void previousSong()
    {
        if (song[0] < music.time && music.time < song[1])
        {
            music.time = song[8];
        }
        else if (song[1] < music.time && music.time < song[2])
        {
            music.time = song[0];
        }
        else if (song[2] < music.time && music.time < song[3])
        {
            music.time = song[1];
        }
        else if (song[3] < music.time && music.time < song[4])
        {
            music.time = song[2];
        }
        else if (song[4] < music.time && music.time < song[5])
        {
            music.time = song[3];
        }
        else if (song[5] < music.time && music.time < song[6])
        {
            music.time = song[4];
        }
        else if (song[6] < music.time && music.time < song[7])
        {
            music.time = song[5];
        }
        else if (song[7] < music.time && music.time < song[8])
        {
            music.time = song[6];
        }
        else if (song[8] < music.time && music.time < song[9])
        {
            music.time = song[7];
        }
        myEventSystem .GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);

    }

    public void playPauseSong()
    {
        if (playing)
        {
            playing = false;
            music.Pause();
            button.image.overrideSprite = playImage;
            myEventSystem .GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
        }
        else{
            playing = true;
            music.Play();
            button.image.overrideSprite = null;
            myEventSystem .GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
        }

    }
}
