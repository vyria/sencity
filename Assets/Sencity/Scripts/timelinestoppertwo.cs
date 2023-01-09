using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class timelinestoppertwo : MonoBehaviour
{
    public PlayableDirector HackingTimeline;

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HackingTimeline.Stop();
        }
    }
}