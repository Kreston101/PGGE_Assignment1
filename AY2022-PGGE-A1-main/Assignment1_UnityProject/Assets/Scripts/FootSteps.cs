using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    //get audio source, and all the audio clips
    public AudioSource source;
    public AudioClip[] concrete, wood, sand, metal;

    //variable to hold the clip to play
    private AudioClip playThis;

    //check what floor the player is on, the grab a random sound from the
    //corresponding array
    private void Update()
    {
        if(Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit))
        {
            switch (hit.collider.name)
            {
                case "Concrete":
                    playThis = concrete[Random.Range(0, concrete.Length - 1)];
                    break;
                case "Wood":
                    playThis = wood[Random.Range(0, concrete.Length - 1)];
                    break;
                case "Sand":
                    playThis = sand[Random.Range(0, concrete.Length - 1)];
                    break;
                case "Metal":
                    playThis = metal[Random.Range(0, concrete.Length - 1)];
                    break;
            }
        }
    }

    //animation event
    private void Step()
    {
        source.PlayOneShot(playThis);
    }
}
