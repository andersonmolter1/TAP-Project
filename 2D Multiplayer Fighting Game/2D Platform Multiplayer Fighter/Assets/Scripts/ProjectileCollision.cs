using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour
{
    public GameObject explosion;
    public GameObject projectile;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject explo = Instantiate(explosion, transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        Destroy(explo, 1f);
        Destroy(projectile);
    }
}
