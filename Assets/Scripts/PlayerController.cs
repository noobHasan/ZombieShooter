using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireRate = 0.5f;
    private float lastFireTime;
    public Transform bulletSpawnPos;

    private PlayerController Instance;


    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // find closest enemy
            GameObject closestEnemy = FindClosestEnemy();

            if (closestEnemy != null)
            {
                // calculate direction to closest enemy
                Vector3 direction = closestEnemy.transform.position - transform.position;

                // fire bullet in that direction
                FireBullet(direction);
            }
        }
    }

    private GameObject FindClosestEnemy()
    {
        GameObject closestEnemy = null;

        float closestDistance = float.MaxValue;

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach(GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(enemy.transform.position, transform.position);

            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestEnemy = enemy;
            }
        }


        return closestEnemy;
    }

    private void FireBullet(Vector3 direction)
    {
        if (Time.time - lastFireTime > fireRate)
        {
            MoneyManager.Instance.GetMoney();
            float rotationSpeed = 1; // adjust as needed
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed);

            lastFireTime = Time.time;

            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPos.position, Quaternion.identity);

            bullet.GetComponent<Rigidbody>().velocity = direction.normalized * 50;
        }
    }
}
