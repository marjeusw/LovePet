using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileGoo : MonoBehaviour
{

    public float lifetime = 3f;
    public float currentLifetime = 0f;
    public float speed = 0.2f;
    public bool PlayerShot = false;
    void Start()
    {
        
    }


    void Update()
    {
        LifeTimer();
        Move();
    }


    void LifeTimer()
    {
        if (currentLifetime >= lifetime)
        {
            Destroy(this.gameObject);
            currentLifetime = 0;
        }
        else
        {
            currentLifetime += Time.deltaTime;
        }

    }



    void Move()
    {
        this.transform.position += this.transform.forward.normalized * speed * Time.deltaTime;
    }



    private void OnTriggerEnter(Collider other)
    {
        if (PlayerShot)
        {
            if ( other.CompareTag("Enemy"))
            {
                Destroy(this.gameObject);
                currentLifetime = 0;
                Debug.Log("EnemyHit");
            }
        }else if (!PlayerShot)
        {
            if (other.CompareTag("Player"))
            {
                Destroy(this.gameObject);
                currentLifetime = 0;
                Debug.Log("PlayerHit");
            }
        }
        
    }

}
