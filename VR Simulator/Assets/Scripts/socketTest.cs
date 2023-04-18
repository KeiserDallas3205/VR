using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class socketTest : XRSocketInteractor
{
    // this will be the tag we're looking for
    public string targetTag;

    // checks if the interactor can hover this object
    [System.Obsolete]
    public override bool CanHover(XRBaseInteractable interactable)
    {
        return base.CanHover(interactable);
    }

    // checks if the interactor can SELECT this object - where the tag check happens
    [System.Obsolete]
    public override bool CanSelect(XRBaseInteractable interactable)
    {
        onSelectEntered.Invoke(interactable);
        return base.CanSelect(interactable) && MatchWithTag(interactable);
    }

    private bool MatchWithTag(XRBaseInteractable interactable)
    {
        return interactable.CompareTag(targetTag);
    }
}
