using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public static bool shotPossible;
    public Transform firePoint;
    public GameObject bulletPrefab;

    void Start()
    {
        shotPossible = true;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2") && shotPossible == true)
        {
            Shot();
        }
    }

    void Shot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        StartCoroutine("shotTimer");
    }
    IEnumerator shotTimer()
    {
        shotPossible = false;
        yield return new WaitForSeconds(1);
        shotPossible = true;
    }
}
