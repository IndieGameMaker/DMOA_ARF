using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceMgr : MonoBehaviour
{
    public GameObject mummy;

    private ARRaycastManager raycastManager;

    void Start()
    {
        mummy = Resources.Load<GameObject>("Mummy");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
