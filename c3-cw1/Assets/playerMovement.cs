using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playerMovement : MonoBehaviour
{
    void OnMouseDrag(){
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 playerPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = playerPos;
    }

    void OnCollisionEnter2D(Collision2D other){
        SceneManager.LoadScene("Lvl1");
    }

    void OnTriggerEnter2D(Collider2D other){
        SceneManager.LoadScene("jumpscare");
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
