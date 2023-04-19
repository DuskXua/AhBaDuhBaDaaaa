using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : Interactable
{
    public GameObject platform;
    bool active = false;
    protected override void Interact()
    {
        active = !active;
        platform.gameObject.SetActive(active);
    }
}
