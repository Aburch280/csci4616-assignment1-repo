using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public GameObject BulletTemplate;
    public float shootPower = 500;

    public InputActionReference trigger;

    void Start()
    {
        trigger.action.performed += Shoot;
    }

    void Shoot(InputAction.CallbackContext _)
    {
        GameObject newBullet = Instantiate(BulletTemplate, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);

        Destroy(newBullet, 5);
    }
}