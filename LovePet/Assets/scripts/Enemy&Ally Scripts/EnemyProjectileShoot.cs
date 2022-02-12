using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileShoot : MonoBehaviour
{

    [SerializeField]
    private GameObject projectile;
    private int ProjectileAmount = 4;
    private bool hasFired = false;
    private List<GameObject> Projectiles;
    public float timeBetweenShoot = 3f;
    public float currentTimeBetweenShot = 0;

    private void Start()
    {
        
    }
    void Update()
    {
        if(hasFired == false)
        {
            EnemyShoot();
            hasFired = true;
        }
        ShootTimer();
    }



    void EnemyShoot()
    {
        Instantiate(projectile, this.transform.position, this.transform.rotation);
      
    }

    void ShootTimer()
    {
        if (currentTimeBetweenShot >= timeBetweenShoot)
        {
            hasFired = false;
            currentTimeBetweenShot = 0;
        }
        else
        {
            currentTimeBetweenShot += Time.deltaTime;
        }
    }


}
