using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGroud : MonoBehaviour
{
    public static bool isGrounded;
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(gameObject.transform.parent.gameObject.GetComponent<Rigidbody2D>().velocity.y);
        if (gameObject.transform.parent.gameObject.GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            isGrounded = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
    }
            
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }
}
