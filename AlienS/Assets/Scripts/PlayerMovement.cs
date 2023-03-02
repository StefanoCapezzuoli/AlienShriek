using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    [SerializeField]
    private float speed;
    public Rigidbody2D rb;
    [SerializeField]
    private float rotationSpeed;

    Vector2 movement;

    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    movement.x = Input.GetAxisRaw("Horizontal");
    movement.y = Input.GetAxisRaw("Vertical");

    rb.MovePosition(rb.position + movement* speed * Time.fixedDeltaTime);
    

    }
}
