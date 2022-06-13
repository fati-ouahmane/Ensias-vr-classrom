using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class play : MonoBehaviour
{
    // Start is called before the first frame update
    
    public VideoPlayer video;
        
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)&& video.isPlaying){
            video.Pause();
        }
        else if (Input.GetKeyDown(KeyCode.P)&& !video.isPlaying){
            video.Play();
        }
    }
}
