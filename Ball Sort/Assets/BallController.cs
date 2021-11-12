using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    //Red ball = 1 //Black ball = 2 // Blue ball = 3// Green 
    
   // Start is called before the first frame update
    public static int Redball = 1;
    public static int Blackball = 2;
    public static int Blueball = 3;
    public static int Greenball = 4;
    public GameObject[] balls;
    void Start()
    {
        
        foreach(GameObject ballObj in balls){
            print(ballObj);
            
        }
        balls = new GameObject[6];


    }
    
    
}
