using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crown2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   void Update()
    {
       Vector3 goal = transform.position;
      goal.x = goal.x -0.1f;
      
      if(goal.x<-20.0f)
      {
         goal.x = 20.0f; 
      }
   transform.position = goal;

    }
}
