using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunComponent : MonoBehaviour
{
	public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float chargeSpeed = 10f;
    private float chargeTime = 0.5f;

    void Update()
    {
		if (Input.GetButtonDown("Fire1") | Input.GetKey(KeyCode.Mouse0))
		{
			chargeTime += Time.deltaTime;
		}
        else if (Input.GetButtonUp("Fire1"))
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
			BulletComponent bulletComp = bullet.GetComponent<BulletComponent>();
			bulletComp.bulletSpeed = chargeSpeed * chargeTime;
			chargeTime = 0.5f;
        }

    }
}
