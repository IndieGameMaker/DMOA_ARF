using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MummyMove : MonoBehaviour
{
    //ARCamera의 Transform 컴포넌트를 저장할 변수
    private Transform camTr;
    //이동속도
    public float moveSpeed = 0.5f;

    void Start()
    {
        camTr = Camera.main.transform; //Camera.main.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //회전
        Vector3 lookDir = new Vector3(camTr.position.x, transform.position.y, camTr.position.z);
        transform.LookAt(lookDir);
        //이동
        transform.Translate(transform.forward * Time.deltaTime * moveSpeed);
    }
}
