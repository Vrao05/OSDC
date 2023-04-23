using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float speed = 10f;
    public float fireRate = 0.5f;
    public float counter = 0;
    private float lastFireTime = 0f;

    private void Update()
    {
        
        counter = Time.timeSinceLevelLoad;
        StartFire();
        
    }
    void FixedUpdate()
    {
    }
    public void StartFire()
    {   
        if(counter>3)
        {
        if (Time.time - lastFireTime >= fireRate)
        {
           
            GameObject newProjectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            newProjectile.GetComponent<Rigidbody2D>().velocity = transform.right * speed;

           
            lastFireTime = Time.time;
        }
        }
    }
}
