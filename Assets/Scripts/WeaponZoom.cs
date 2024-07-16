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
    FirstPersonController firstPersonController;

    void Start()
    {
        firstPersonController = GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        { 
            zoomState = !zoomState;
            if (zoomState)
            {
                playerFollowCam.m_Lens.FieldOfView = zoomedInFOV;
                firstPersonController.RotationSpeed = zoomedInSensitivity;
            }
            else
            {
                playerFollowCam.m_Lens.FieldOfView = zoomedOutFOV;
                firstPersonController.RotationSpeed = zoomedOutSensitivity;
            }
        }
    }
}
