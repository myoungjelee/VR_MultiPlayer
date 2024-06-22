using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Photon.Pun;

public class XRGrabNetworkInteractable : XRGrabInteractable
{
    private PhotonView PhotonView;

    private void Start()
    {
        PhotonView = GetComponent<PhotonView>();
    }

    //protected override void OnSelectEntered(XRBaseInteractor interactor)
    //{
    //    PhotonView.RequestOwnership();
    //    base.OnSelectEntered(interactor);
    //}

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        PhotonView.RequestOwnership();
        base.OnSelectEntered(args);
    }
}
