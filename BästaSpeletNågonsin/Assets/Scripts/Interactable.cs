using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Template Method Pattern

// Template for all interactable objects such as doors, guns, health packs and so on.
// All interactable objects inherit this class
public abstract class Interactable : MonoBehaviour
{
    public bool useEvents;

    public string promptMessage;

    // BaseInteract() is to be called from the Player-script
    public void BaseInteract()
    {
        if (useEvents)
        {
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        }
        Interact();
    }

    protected virtual void Interact()
    {
        // No code here, protected virtual is to be overridden by subclasses
    }
}
