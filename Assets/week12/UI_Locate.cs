using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Locate : MonoBehaviour
{
    public Transform PosReference;

    Camera TargetCamera;


    // Start is called before the first frame update
    void Start()
    {
        TargetCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayAtPoint();
    }

    void DisplayAtPoint()
    {
        Vector3 WorldPos = PosReference.position+Vector3.up; //큐브의 좌표값 가져옴 1유닛 위로
        Vector2 ScreenPos = TargetCamera.WorldToScreenPoint(WorldPos); //3d좌표 -> 2d
        transform.position = ScreenPos;
    }
}
