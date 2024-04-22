using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private float timeleft;
    
    void Update()
    {
        Vector3 goal = transform.position;
        timeleft -= Time.deltaTime;
        
        if (timeleft <= 0.0) 
        {
            timeleft = 0.15f;
        goal.z = goal.z * -1.0f;
        }

        if(goal.y>=-4.0f)
        {
            goal.y = goal.y  -0.05f;
        }

        transform.position = goal;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = transform.position;
             transform.Translate(0,1.0f,0);
        }
    }

    public void MoveUp()
    {
        Vector3 pos = transform.position;
        if(pos.y<4.0f)
        {
            transform.Translate(0,1.0f,0);
        }
    }

    public void MoveDown()
    {
        Vector3 pos = transform.position;
        if(pos.y>-4.0f)
        {
        transform.Translate(0,-0.5f,0);
        }
    } 



   // public void MoveRight()
   // {
     //   Vector3 pos = transform.position;
       // if(pos.x<8.0f)
        //{
          //  transform.Translate(0.5,0,0);
        //}
    //}

   // public void MoveLeft()
    //{
      //  Vecter3 pos =transform.position;
      //  if(pos.x>-8.0f)
     //   {
      //      transform.Translate(-0.5,0,0);
      //  }
   // }
}
