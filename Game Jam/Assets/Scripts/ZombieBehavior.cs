using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBehavior : MonoBehaviour
{
    public float speed;
    public int health;
    Vector3 target;
    public CircleCollider2D detectionRadius;
    public Animation attack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowMouse();
    }
    void FollowMouse()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10f);
        transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.up, speed * Time.deltaTime);
        transform.up = -(target - transform.position);
    }
    void Attack(GameObject victim)
    {
        while(Vector2.Distance(this.transform.position,victim.transform.position) > 10)
        {
            target = victim.transform.position;
            if (Vector2.Distance(this.transform.position, victim.transform.position) > 50)
                return;
        }
        attack.Play();
    }
}

