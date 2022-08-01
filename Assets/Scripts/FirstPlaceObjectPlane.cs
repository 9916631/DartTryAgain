using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class FirstPlaceObjectPlane : MonoBehaviour
{
    ARRaycastManager m_ARRaycastManager;

    List<ARRaycastHit> raycast_hit = new List<ARRaycastHit>();
    public GameObject portalPrefab;

    private GameObject spawnPortal;

    private void Awake()
    {
        m_ARRaycastManager = GetComponent<ARRaycastManager>();
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (m_ARRaycastManager.Raycast(touch.position, raycast_hit, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
            {
                Pose pose = raycast_hit[0].pose;

                //could maybe do a switch statement to see if it changes whith other gaemonbejct 
                if (spawnPortal == null)
                {
                    spawnPortal = Instantiate(portalPrefab, pose.position, Quaternion.Euler(0, 0, 0));
                }
                else
                {
                    spawnPortal.transform.position = pose.position;
                }
            }
        }
    }
}
