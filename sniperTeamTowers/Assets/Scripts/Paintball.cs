using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintball : MonoBehaviour {
    public float speed = 10.0f;
    public int damage = 1;

    private void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Player_Info player = other.GetComponent<Player_Info>();

        if(player != null)
        {
            player.Hurt(damage);
        }
        Destroy(this.gameObject);
    }
}
