using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       Vector3 goal = transform.position;
     goal.x = goal.x -6f;
     
      if(goal.x<=700)
      {
         goal.x = 700; 
    }
      transform.position = goal;

    }
}
