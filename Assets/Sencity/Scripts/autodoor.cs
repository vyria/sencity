using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autodoor: MonoBehaviour
{
    public Animator RoomDoorAnim;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RoomDoorAnim.ResetTrigger("close");
            RoomDoorAnim.SetTrigger("open");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RoomDoorAnim.ResetTrigger("open");
            RoomDoorAnim.SetTrigger("close");
        }
    }
}