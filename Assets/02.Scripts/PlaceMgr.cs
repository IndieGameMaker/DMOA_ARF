using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMgr : MonoBehaviour
{
    public GameObject mummy;

    void Start()
    {
        mummy = Resources.Load<GameObject>("Mummy");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
