using UnityEngine;



public class PlaySoundOnTrigger : MonoBehaviour

{

    public AudioSource audioSource;



    private void OnTriggerEnter(Collider other)

    {

        // Check if the object entering the trigger is the Player 

        if (other.CompareTag("Ball"))

        {

            if (audioSource != null && !audioSource.isPlaying)

            {

                audioSource.Play();

            }

        }

    }

}