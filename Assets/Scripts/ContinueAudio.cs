using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueAudio : MonoBehaviour
{
    public AudioSource levelMusic;
    public AudioSource lossMusic; 

    void Awake(){
        DontDestroyOnLoad(transform.gameObject);
    }

    

    
}
