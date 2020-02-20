using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private float speed = 1f;

    private LineRenderer line;
    private Camera cam;

    private void Awake()
    {
        cam = Camera.main;
        line = GetComponent<LineRenderer>();
        line.enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            line.enabled = true;
            line.SetPosition(1, cam.ScreenToWorldPoint(Input.mousePosition));
        }
        if (Input.GetMouseButtonUp(0))
        {
            line.enabled = false;
            GameObject newBall = Instantiate(ball, transform.position, transform.rotation);
            Rigidbody2D newBallRB = newBall.GetComponent<Rigidbody2D>();
            Vector2 direction = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
            newBallRB.velocity = direction * speed;
        }
    }
}
