using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController01 : MonoBehaviour 

{
    public float speed;
    public float xRange;
    public float yRange;
    public GameObject Puck;
    public GameObject Blocky;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Blocky, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);
    }

    private void LateUpdate()
    {
        //Keep Player within xRange(left and Right sides);
        if (transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }

        if (transform.position.y > yRange)
        {
            transform.position = new Vector2(transform.position.x, yRange);
        }
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector2(transform.position.x, -yRange);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(Puck,new Vector2 (Random.Range(-xRange,xRange), Random.Range(-yRange,yRange)), Quaternion.identity);

        //Instantiate(Puck, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);

        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");
        Debug.Log(moveHorizontal);

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");
        
        //Use the two store to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        transform.Translate(movement * speed * Time.deltaTime);

        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    Debug.Log(Input.GetAxis("Horizontal"));
        //    transform.Translate(Vector2.right * speed * Time.deltaTime);
        //}
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Blocky"));

        {
            Destroy(other.gameObject);
            Debug.Log("Hit Blocky!");
        }
    }
}
