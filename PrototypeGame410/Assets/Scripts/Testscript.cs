using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testscript : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    private float time = 0.0f;
    public float interpolationPeriod = 10.0f;


    // Start is called before the first frame update
    public void Start()
    {
        time += Time.deltaTime;
        GameObject theEnemy = GameObject.Find("Enemy");
        EnemyHealth enemy = theEnemy.GetComponent<EnemyHealth>();

        if (enemy.alive == true)
        {
            InvokeRepeating("Shoot", 0.3f, 0.3f);
        }
    }

    public void Shoot()
    {
        GameObject thePlayer = GameObject.Find("Enemy");
        EnemyHealth enemyHealth = thePlayer.GetComponent<EnemyHealth>();

        GameObject theTurret = GameObject.Find("Tank_Location");
        Tank_Location_Script turret = theTurret.GetComponent<Tank_Location_Script>();


        GameObject theTurret2 = GameObject.Find("Tank_Location_2");
        Tank_Location_Script turret2 = theTurret2.GetComponent<Tank_Location_Script>();


        GameObject theTurret3 = GameObject.Find("TurretTower");
        Tank_Location_Script turret3 = theTurret3.GetComponent<Tank_Location_Script>();


        if (enemyHealth.alive == true && turret.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret.transform.position.x, turret.transform.position.y + 3, turret.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret2.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret2.transform.position.x, turret2.transform.position.y + 3, turret2.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret3.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret3.transform.position.x, turret3.transform.position.y + 3, turret3.transform.position.z), gameObject.transform.rotation);
        }
    }
}
