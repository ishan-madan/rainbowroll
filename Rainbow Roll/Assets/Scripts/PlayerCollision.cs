using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement PlayerMovement;
    public GameObject particleSystem;
    public ParticleSystem[] explode;
    public GameObject playerTrail;
    public AudioSource deathSound;


    void Awake()
    {
        foreach (var particleSys in explode)
        {
            particleSys.Pause();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Obstacle")
        {
            PlayerMovement.rb.velocity = col.rigidbody.velocity;
            PlayerMovement.rb.rotation = col.rigidbody.rotation;
            PlayerMovement.rb.constraints = RigidbodyConstraints.FreezePosition;
            PlayerMovement.rb.constraints = RigidbodyConstraints.FreezeRotation;
            PlayerMovement.enabled = false;
            gameObject.SetActive(false);
            playerTrail.transform.position = new Vector3(0, 100, 0);

            particleSystem.transform.position = PlayerMovement.rb.transform.position;

            foreach (var particleSys in explode)
            {
                particleSys.Play();
            }

            deathSound.Play();
            FindObjectOfType<GameManager>().EndGame();

        }
    }

    void FixedUpdate()
    {
        if (PlayerMovement.rb.position.y < -5)
        {
            PlayerMovement.rb.velocity = new Vector3(0, 0, 0);;
            PlayerMovement.rb.rotation = playerTrail.transform.rotation;
            PlayerMovement.rb.constraints = RigidbodyConstraints.FreezePosition;
            PlayerMovement.rb.constraints = RigidbodyConstraints.FreezeRotation;
            PlayerMovement.enabled = false;
            gameObject.SetActive(false);
            playerTrail.transform.position = new Vector3(0, 100, 0);

            particleSystem.transform.position = PlayerMovement.rb.transform.position;

            foreach (var particleSys in explode)
            {
                particleSys.Play();
            }


            deathSound.Play();
            FindObjectOfType<GameManager>().EndGame();
        }
    }



}
