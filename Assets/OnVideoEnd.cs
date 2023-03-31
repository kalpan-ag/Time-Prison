using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnVideoEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<UnityEngine.Video.VideoPlayer>().loopPointReached += EndReached;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        Debug.Log("GameQuit");
        Application.Quit();
    }
}
