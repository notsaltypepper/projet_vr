using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField] GameObject firepoint;

    [SerializeField] float pistoldamage = 10;
    [SerializeField] GameObject hitFxPrefab;

    [SerializeField] int bulletMax = 30;
    int currentBullet;

    private void Start()
    {
        currentBullet = bulletMax;
    }
    // Start is called before the first frame update
    public void Fire()
    {

        //NO BULLET NO SHOT
        //if (currentBullet <= 0)
        //{
        //    return;
        //}

        //currentBullet--;
        RaycastHit hitInfo;

        bool hit = Physics.Raycast(firepoint.transform.position, firepoint.transform.forward, out hitInfo);

        //if (hit)
        //{
        //    GameObject fx = Instantiate(hitFxPrefab, hitInfo.point, Quaternion.Euler(firepoint.transform.forward));
        //    Destroy(fx, 5f);
        //}

        if (hit && hitInfo.collider.tag == "Destructible")
        {
            hitInfo.transform.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(firepoint.transform.forward * 10, hitInfo.point, ForceMode.Impulse);
        }

        if (hit && hitInfo.transform.gameObject.tag == "Enemy")
        {
            hitInfo.transform.gameObject.GetComponent<EnemyHealth>().TakeDamage();
        }
    }
    public void Reload()
    {
        currentBullet = bulletMax;
    }
}