using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkButtonInfo : MonoBehaviour
{   

    // Reset all PlayerPrefs for testing
    public void resetPlayerPref()
    {
        PlayerPrefs.DeleteAll();
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    // Start is called before the first frame update
    void Start()
    {
        Button activeButton;

        if (PlayerPrefs.GetInt("caveButton") == 2) {
            activeButton = GameObject.Find("Button_Cave").GetComponent<Button>();
            activeButton.interactable = true;
        }
        if (PlayerPrefs.GetInt("industrialButton") == 2) {
            activeButton = GameObject.Find("Button_Industrial").GetComponent<Button>();
            activeButton.interactable = true;
        }
        if (PlayerPrefs.GetInt("disasterButton") == 2) {
            activeButton = GameObject.Find("Button_Disaster").GetComponent<Button>();
            activeButton.interactable = true;
        }
        if (PlayerPrefs.GetInt("hopeButton") == 2) {
            activeButton = GameObject.Find("Button_Hope").GetComponent<Button>();
            activeButton.interactable = true;
        }
        if (PlayerPrefs.GetInt("creditsButton") == 2) {
            activeButton = GameObject.Find("Button_Credits").GetComponent<Button>();
            activeButton.interactable = true;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
