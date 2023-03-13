using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAttack : MonoBehaviour
{
    public Rigidbody2D rb;
    public int attackSpeed;


    void FixedUpdate()
    {
        rb.AddForce(transform.right * attackSpeed);
    }

}
