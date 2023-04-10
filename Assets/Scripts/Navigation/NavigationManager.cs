using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationManager : MonoBehaviour
{

    public void SceneLoader(int sceneNumber) {

        switch(sceneNumber)
        {
            case 1:
                PlayerPrefs.SetInt("caveButton", 2);
                break;
            case 2:
                PlayerPrefs.SetInt("industrialButton", 2);
                break;
            case 3:
                PlayerPrefs.SetInt("disasterButton", 2);
                break;
            case 4:
                PlayerPrefs.SetInt("hopeButton", 2);
                break;
            case 5:
                PlayerPrefs.SetInt("creditsButton", 2);
                break;
            default:
                break;
        }

        SceneManager.LoadScene(sceneNumber);

    }

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
