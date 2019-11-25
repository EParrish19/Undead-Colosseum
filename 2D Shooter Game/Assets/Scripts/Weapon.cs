using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform[] bulletSpawn;
    
    public float fireTime = 0.5f;

    public bool isFiring = false;

    private void SetFiring()
    {
        isFiring = false;

    }

    private void Fire()
    {

        isFiring = true;

        GameObject bullet = PoolManager.current.GetPooledObject("bullet");
        for (int i = 0; i < bulletSpawn.Length; i++)
        {
            //Check if bullets not spawning
            if (bullet != null)
            {
                bullet.transform.position = bulletSpawn[i].position;
                bullet.transform.rotation = bulletSpawn[i].rotation;
                bullet.SetActive(true);
            }
        }

        if(GetComponent<AudioSource>() != null)
        {

            GetComponent<AudioSource>().Play();

        }

        Invoke("SetFiring", fireTime);

    }

    private void Update()
    {

        if (Input.GetMouseButton(0))
        {

            if (!isFiring)
            {

                Fire();

            }

        }

    }

}
