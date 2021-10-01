using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arraypractice : MonoBehaviour
{
    public int[] lottoNumbers = { 1, 2, 3, 4, 5, 6 };
    public int myNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myNumber = lottoNumbers[Random.Range(0,5)];
        Debug.Log("My Lotto is: " + myNumber);
    }
}
