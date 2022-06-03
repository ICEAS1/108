using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drovaContr : MonoBehaviour
{
    // Start is called before the first frame update
    int drova = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnControllerColliderHit(ControllerColliderHit CCH){
        if(CCH.transform.tag=="campfire"){
            drova=drova+1;
            print(drova);
           
        }
    }
}
