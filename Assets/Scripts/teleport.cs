using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{

private float teleporttime = 1;
private float teleporttime2 = 1;
    private float zNumber = 3.75f;
  
      private float xNumber = 3.75f;
   
    
 



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      teleporttime++;
      teleporttime2++;
          
      
      
      if (teleporttime >= 1000){

            teleporttime = 0;
            zNumber = zNumber * -1;

            }


              if (teleporttime2 >= 500){
              
                   teleporttime2 = 0;
          
            xNumber = xNumber * -1;

            }
            
    
        
        
        transform.position = new Vector3(xNumber, 0.75f, zNumber);




        
    }
}
