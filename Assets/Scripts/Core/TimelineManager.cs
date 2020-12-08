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

    public void PlayTimeline()
    {
        pd.Play();
    }

    public void PauseTimeline()
    {
        pd.Pause();
    }

    public void ResumeTimeline()
    {
        pd.Resume();
    }

    public void StopTimeline()
    {
        pd.Stop();
    }
}
