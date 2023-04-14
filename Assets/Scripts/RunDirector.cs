using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class RunDirector : MonoBehaviour
{
    public PlayableDirector director1;
    public PlayableDirector director2;

    // Start is called before the first frame update
    public void Start()
    {
        director1 = GetComponent<PlayableDirector>();
        director2 = GetComponent<PlayableDirector>();
    }

    public void Play()
    {
        if (PlayerPrefs.GetInt("Timeline-1") == 2)
        {
            director2.Play();
        }
        else
        {
            PlayerPrefs.SetInt("Timeline-1", 2);
            director1.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
