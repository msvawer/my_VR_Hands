using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandHider : MonoBehaviour  
{
    public GameObject handObject = null;
    private HandPhysics handPhysics = null;
    private XRDirectInteractor Interactor = null;

    private void Awake()
    {

        handPhysics = handObject.GetComponent<HandPhysics>();
    }
}
