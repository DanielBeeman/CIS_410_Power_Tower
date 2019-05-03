using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int healthPoints = 100;
    public Bullet bullet;

    private int currentHealthPoints;
    public bool alive;

    private int count = 0;
    public GameObject pre_enemy;

    // Start is called before the first frame update
    void Start()
    {
        currentHealthPoints = healthPoints;
        alive = true;
        if (count < 3)
        {
            InvokeRepeating("spawnEnemy", 5.0f, 8.0f);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loseHp(Bullet b)
    {
        currentHealthPoints = currentHealthPoints - b.damage;
        if (currentHealthPoints <= 0)
        {
            alive = false;
            gameObject.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            loseHp(bullet);
        }
    }

    public void spawnEnemy()
    {
        Instantiate(pre_enemy, new Vector3(-.5f,.5f,-6.1f), pre_enemy.transform.rotation);
        count++;
    }
}
