using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Next : MonoBehaviour
{
    [SerializeField] VideoClip[] videoClips;
    int currentClip = 0;

    VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void NextButton()
    {
        if (currentClip >= videoClips.Length - 1)
        {
            currentClip = 0;
        }
        else
        {
            currentClip++;
        }
        videoPlayer.clip = videoClips[currentClip];
        videoPlayer.Play();
     
    }
}
