using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraCinemachine : MonoBehaviour
{

    public CinemachineFreeLook[] cameras;

    public CinemachineFreeLook camera1;
    public CinemachineFreeLook camera2;
    public CinemachineFreeLook camera3;

    public CinemachineFreeLook startCamera;
    public CinemachineFreeLook currentCam;
    // Start is called before the first frame update
    void Start()
    {
        currentCam = startCamera;

        for (int i = 0; i < cameras.Length; i++)
        {
            if (cameras[i] == currentCam)
            {
                cameras[i].Priority = 20;
            }
            else
            {
                cameras[i].Priority = 10;
            }
        }
    }

    public void SwitchCamera(CinemachineFreeLook newCam)
    {
        currentCam = newCam;

        currentCam.Priority = 20;

        for (int i = 0; i < cameras.Length; i++)
        {
            if (cameras[i] != currentCam)
            {
                cameras[i].Priority = 10;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
