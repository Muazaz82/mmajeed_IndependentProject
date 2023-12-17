using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCode playKey = KeyCode.Space; // Set the desired play key in the Unity Inspector

    void Update()
    {
        // Check if the play key is pressed
        if (Input.GetKeyDown(playKey))
        {
            // Call your play function or trigger play action here
            Play();
        }
    }

    void Play()
    {
        // Replace this with your actual play logic
        Debug.Log("Start playing!");
        // Add your play logic, such as starting animations, playing audio, etc.
    }
}