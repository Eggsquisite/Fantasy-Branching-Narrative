using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineManager : MonoBehaviour
{
    private PlayableDirector pd;

    PlayableAsset newTimelineAsset;

    // Start is called before the first frame update
    void Start()
    {
        pd = GetComponent<PlayableDirector>();
        //pd.playableAsset = newTimelineAsset;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
