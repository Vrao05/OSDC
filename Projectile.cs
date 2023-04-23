using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float speed = 10f;
    public float fireRate = 0.5f;

    private float lastFireTime = 0f;

    private void Update()
    {
        
        InvokeRepeating("StartFire", 3, 1);
        
    }
    public void StartFire()
    {
        if (Time.time - lastFireTime >= fireRate)
        {
           
            GameObject newProjectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            newProjectile.GetComponent<Rigidbody2D>().velocity = transform.right * speed;

           
            lastFireTime = Time.time;
        }
    }
}
