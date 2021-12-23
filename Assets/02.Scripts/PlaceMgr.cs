using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceMgr : MonoBehaviour
{
    public GameObject mummy;

    //ARFoundation의 Raycast를 관리하는 컴포넌트
    private ARRaycastManager raycastManager;
    //Raycasting 결과를 저장할 리스트
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Start()
    {
        mummy = Resources.Load<GameObject>("Mummy");
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        //스크린 터치여부를 확인
        if (Input.touchCount == 0) return;

        //첫번째 손가락 터치 정보를 저장
        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began)
        {
            //Raycasting : 2D 좌푯값 -> 3D Raycasting
            if (raycastManager.Raycast(touch.position, hits, TrackableType.All))
            {
                Instantiate(mummy, hits[0].pose.position, hits[0].pose.rotation);
            }
        }
    }
}
