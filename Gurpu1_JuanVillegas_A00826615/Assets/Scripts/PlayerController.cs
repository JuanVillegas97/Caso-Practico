using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 temp;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Rock"){
            Destroy(other.gameObject);
        }
        if(other.tag == "Power"){
            temp = transform.localScale;
            temp.x *= 2f;
            transform.localScale=temp;
            Destroy(other.gameObject);
        }
        
    }
    public Rigidbody rb;
    public float speed;
    public float maxX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        if(x<0){
            MoveLeft();
        }
        if(x>0){
            MoveRight();
        }


        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x,-maxX,maxX);
        transform.position=pos;
    }

    void MoveRight(){
        rb.velocity = new Vector2(speed,0);
    }

    void MoveLeft(){
        rb.velocity = new Vector2(-speed,0);
    }

    
}
