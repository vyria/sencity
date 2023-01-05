using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class timelineplayer : MonoBehaviour
{
    public PlayableDirector AfterHackingTimeline;
    public PlayableDirector OpeningTimeline;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AfterHackingTimeline.Play();
        }
    }
    void OnTriggerExis(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AfterHackingTimeline.Play();
        }
    }
}