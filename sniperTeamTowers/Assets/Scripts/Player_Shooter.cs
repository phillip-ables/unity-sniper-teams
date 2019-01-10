using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shooter : MonoBehaviour {
    private Camera playerCam;

    private void Start()
    {
        playerCam = GetComponent<Camera>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        // left mouse button
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(playerCam.pixelWidth / playerCam.pixelHeight / 2, 0);

            Ray ray = playerCam.ScreenPointToRay(point);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                //launch a coroutine in response to a hit
            }
        }
    }
}
