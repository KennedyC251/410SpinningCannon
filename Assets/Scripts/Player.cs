using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    private float rotation;
    public float rotationSpeed;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rotation += Time.deltaTime * rotationSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotation += -Time.deltaTime * rotationSpeed;
        }
        transform.rotation = Quaternion.Euler(0, 0, rotation);
    }
}
