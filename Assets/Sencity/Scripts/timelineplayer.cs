using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class timelineplayer : MonoBehaviour
{
    public PlayableDirector HackingTimeline;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HackingTimeline.Play();
        }
    }
}