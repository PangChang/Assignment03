using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pinPrefab;
    private AudioSource audioSource;


    void Start(){
    audioSource = GetComponent<AudioSource>();
        }


    void Update()
    {
        if (!PauseMenu.isPaused)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                SpawnPin();
            }
        }

    void SpawnPin()
        {
            Instantiate(pinPrefab, transform.position, transform.rotation);
            audioSource.Play();
        }

    }

}
