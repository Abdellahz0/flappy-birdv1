using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigibody;
    public float flapstrenght;
    public logicscript logic;
    public bool birdisalive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()    // direction for the bird to travel by a 2d vector
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdisalive)
        {
            myRigibody.velocity = Vector2.up * flapstrenght;  // (0,1) straight up  *10 to more power
        }
        if (transform.position.y < -14 || transform.position.y > 14)
        {
            logic.gameover();
            birdisalive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        birdisalive = false;
    }
}
