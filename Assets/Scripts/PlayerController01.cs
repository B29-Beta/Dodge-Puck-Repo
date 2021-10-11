using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController01 : MonoBehaviour 

{
    public float speed;
    public float xRange;
    public float yRange;
    public GameObject Puck;

    // Start is called before the first frame update
    void Start()
    {
      
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

        //Instantiate(Enemy, new Vector3(Random.Range(-2.0F, 2.0F), Random.Range(-2.0F, 2.0F), 0), Quaternion.identity);

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
}
