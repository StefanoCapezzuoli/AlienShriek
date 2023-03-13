using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proiettile : MonoBehaviour
{
    public Rigidbody2D bulletPrefab;
    public float attackSpeed = 0.5f;
    public float coolDown;
    public float bulletSpeed = 500;
    public float yValue = 1f; // Used to make it look like it's shot from the gun itself (offset)
    public float xValue = 0.2f; // Same as above

    void Start()
    {
      
    }

        void OnEnable()
        {
            GameObject[] otherObjects = GameObject.FindGameObjectsWithTag("Noise");
            GameObject[] otherObjects2 = GameObject.FindGameObjectsWithTag("BrokenWall");
             GameObject[] otherObjects3 = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject obj in otherObjects)
            {
                Physics2D.IgnoreCollision(obj.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }

        foreach (GameObject obj in otherObjects2)
        {
            Physics2D.IgnoreCollision(obj.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        foreach (GameObject obj in otherObjects3)
        {
            Physics2D.IgnoreCollision(obj.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        // rest of OnEnable
    }

    void FixedUpdate()
    {
        bulletPrefab.AddForce(transform.up * bulletSpeed);
    }
}
