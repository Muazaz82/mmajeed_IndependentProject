using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button nextButton;

    private void Start()
    {
        // Add a listener to the button's onClick event
        nextButton.onClick.AddListener(OnNextButtonClick);
    }

    private void OnNextButtonClick()
    {
        // Load the next scene or perform the desired action
        SceneManager.LoadScene("Howtoplay");
    }
}
