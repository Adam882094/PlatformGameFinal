using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D body;
    float cnt = 1.5f;
    float current = 0f;
    int check = 0;
   // public AudioSource audioSrc;

    private void Awake() {

       // DontDestroyOnLoad(gameObject);
        body = GetComponent<Rigidbody2D>();
        current = cnt;
        }
    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if(Input.GetKey(KeyCode.Space))
        {
            if (check == 0)
            {
                body.velocity = new Vector2(body.velocity.x, 7);
                check = 1;
            }
        }
        if (check == 1)
        {
            current -= 1 * Time.deltaTime;
            if (current <= 0)
            {
                check = 0;
                current = cnt;
            }
        }
    }
}
