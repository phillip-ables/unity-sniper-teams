using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

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

    }
}
