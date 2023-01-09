using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class timelinestopper : MonoBehaviour
{
    public PlayableDirector OpeningTimeline;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OpeningTimeline.Stop();
        }
    }
}