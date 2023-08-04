using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerShoot : NetworkBehaviour
{
    [SerializeField] private GameObject bulletObject;

    [SerializeField] private float shootSpeed;

    [SerializeField] private Transform shootPoint;

    private Rigidbody tankRB;

    void Start()
    {
        tankRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletObject, shootPoint.position, shootPoint.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(tankRB.velocity + bullet.transform.forward * shootSpeed, ForceMode.VelocityChange);
    }
}
