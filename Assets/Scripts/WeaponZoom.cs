using Cinemachine;
using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera playerFollowCam;
    [SerializeField] float zoomedOutFOV = 40f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomedOutSensitivity = 1f;
    [SerializeField] float zoomedInSensitivity = 0.25f;

    bool zoomState = false;
    public bool ZoomState { set { zoomState = value; } }
    FirstPersonController firstPersonController;

    void Start()
    {
        firstPersonController = GetComponent<FirstPersonController>();
    }

    private void OnDisable()
    {
        ZoomOut();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        { 
            if (zoomState == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    private void ZoomIn()
    {
        zoomState = true;
        playerFollowCam.m_Lens.FieldOfView = zoomedInFOV;
        firstPersonController.RotationSpeed = zoomedInSensitivity;
    }

    private void ZoomOut()
    {
        zoomState = false;
        playerFollowCam.m_Lens.FieldOfView = zoomedOutFOV;
        firstPersonController.RotationSpeed = zoomedOutSensitivity;
    }

}
