using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoFrame : MonoBehaviour
{
    VideoPlayer vp;

    // Start is called before the first frame update
    void Start()
    {
        vp = GetComponent<VideoPlayer>();
        vp.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckVideoFrame(bool checker)
    {
        if (checker)
        {
            if(!vp.isPlaying)
            {
                vp.Play();
            }
            else
            {
                vp.Stop();
            }
        }
    }
}
