using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerMovement : MonoBehaviour
{
    [Header("Reference")]
    public Camera mainCam;
    public Animator palyerAnimator;

    [Header("Change Values")]
    public float speed = 0.25f;
    public float swipeSpeed = 10f;
    public float dragSpeed = 5f;

    //private
    private Transform localTransform;
    private Vector3 lastMousePos;
    private Vector3 mousePos;
    private Vector3 newMousePos;

    void Start()
    {
        localTransform = GetComponent<Transform>();
    }
    void Update()
    {
        // if(Input.GetMouseButtonDown(0))
        // {
        // }
        // else
        if(Input.GetMouseButton(0))
        {
            mousePos = mainCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,dragSpeed));

            float xDifference = mousePos.x - lastMousePos.x;
            newMousePos.x = localTransform.position.x + xDifference*swipeSpeed*Time.deltaTime;
            newMousePos.y = localTransform.position.y;
            newMousePos.z = localTransform.position.z;
        
            localTransform.position = newMousePos + localTransform.forward * speed * Time.deltaTime;
            lastMousePos = mousePos;
        }
        else
        {
            localTransform.position += Vector3.forward * Time.deltaTime * speed;
        }
    }

}
