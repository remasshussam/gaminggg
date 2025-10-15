using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public class PlayerController: MonoBehaviour{
        public float moveSpeed;
        public float jumpHeight;
        public KeyCode Spacebar;
         public  KeyCode L;
          public   KeyCode R;
          public Transform groundCheck;
          public float groundCheckRadius;
        public LayerMask whatIsGround;
        private bool grounded;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(Spacebar)&&grounded){
            Jump();
        }
        
        if(Input.GetKey(L)){
            GetComponent<Ridgidbody2D>().velocity= new Vector(-moveSpeed,GetComponent<Ridgidbody2D>().velocity.y);
            if(GetComponent<SpriteRenderer>()!=null){
                GetComponent<SpriteRenderer>().flipX=true;
            }
        }
         if(Input.GetKey(R)){
            GetComponent<Ridgidbody2D>().velocity= new Vector(moveSpeed,GetComponent<Ridgidbody2D>().velocity.y);
            if(GetComponent<SpriteRenderer>()!=null){
                GetComponent<SpriteRenderer>().flipX=false;
            }
        }
    }
    void Jump(){
         GetComponent<Ridgidbody2D>().velocity= new Vector2( GetComponent<Ridgidbody2D>().velocity.x,jumpHeight);
    }
    void FixedUpdate(){
        grounded= Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,whatIsGround);
    }
}
