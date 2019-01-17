using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform shootPoint;
    public float weaponRange = 100;
    public int bulletsPerMag = 30;
    public int bulletsLeft;

    public float fireRate = 0.1f;  // 100 millisec

    float fireTimer;

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Fire();
        }

        if (fireTimer < fireRate)
            fireTimer += Time.deltaTime;
    }

    private void Fire()
    {
        if (fireTimer < fireRate)
            return;

        RaycastHit hit;

        if(Physics.Raycast(shootPoint.position, shootPoint.transform.forward, out hit, weaponRange))
        {
            Debug.Log(hit.transform.name + "found!");
        }

        fireTimer = 0.0f;
    }
}
