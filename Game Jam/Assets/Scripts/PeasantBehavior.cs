using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeasantBehavior : MonoBehaviour
{
    public float speed;
    public int health;
    Vector3 target;
    public CircleCollider2D humanCollision;
    public GameObject badGuyParent;
    public float deathDelay;
    public GameObject zombiePrefab;
    Collider2D zombieHitBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (humanCollision.IsTouching(zombieHitBox))
            this.health -= 1;
        if(health <= 0)
        {
            Destroy(this, deathDelay);
            Instantiate(zombiePrefab);
        }
    }
}
