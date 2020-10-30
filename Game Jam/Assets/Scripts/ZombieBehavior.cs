using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ZombieBehavior : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;
    public int health;
    public Vector2 position;
    public Vector2 target;
    public Vector2 mousePosition;
    Event currentEvent = Event.current;
    // Start is called before the first frame update
    void Start()
    {
        position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPosition = Mouse.current.position.ReadValue();
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        target = worldPosition;
        //this.transform.LookAt(target);
        transform.position = Vector2.MoveTowards(gameObject.transform.position, target, speed * Time.deltaTime);
        transform.up = -(target * rotateSpeed * Time.deltaTime);
        //transform.rotation = Quaternion.LookRotation(Vector2.up, Vector2.MoveTowards(gameObject.transform.position, target, rotateSpeed * Time.deltaTime));
    }
}
