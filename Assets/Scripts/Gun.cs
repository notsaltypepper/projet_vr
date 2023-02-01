using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField] GameObject firepoint;

    public void fire()
    {
        RaycastHit hitInfo;
        bool hit = Physics.Raycast(firepoint.transform.position, firepoint.transform.forward, out hitInfo);

        if (hit && hitInfo.collider.tag == "Destructible")
        {
            hitInfo.transform.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(firepoint.transform.forward * 10, hitInfo.point, ForceMode.Impulse);
        }

        if (hit && hitInfo.transform.gameObject.tag == "Enemy")
        {
            hitInfo.transform.gameObject.GetComponent<enemyHealth>().TakeDamage();
        }
    }
}
