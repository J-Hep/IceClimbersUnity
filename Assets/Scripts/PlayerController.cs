using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Never using 2D in Unity again.

    public GameObject player, weaponHitbox, ice;
    public Vector2 playerMove;
    public Vector2 gravity;
   

    void movement()
    {

        gravity.y += 1;

        if (Input.GetKeyDown(KeyCode.W))
        {

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
        
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            playerMove += new Vector2(-1f, 0);
            Debug.Log("PRESSING A");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            playerMove += new Vector2(1f, 0);
            Debug.Log("PRESSING D");
        }

        player.transform.position = playerMove;
  
    }

    void attacking()
    {
        if (weaponHitbox.GetComponent<BoxCollider2D>().IsTouching(ice.GetComponent<BoxCollider2D>())){
            print("Touch");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playerMove = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        attacking();
    }
}
