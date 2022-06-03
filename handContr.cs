using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handContr : MonoBehaviour
{
    public Camera cam;
    GameObject PressE;
    GameObject PressF;
    GameObject drova;
    GameObject hand;
    Transform drvTR;
    Transform handTR;

    public int drovaForCampfire=0;
    // Start is called before the first frame update
    void Start()
    {
        PressE=GameObject.Find("PressE");
        PressE.SetActive(false);

        PressF=GameObject.Find("PressF");
        PressF.SetActive(false);

        drova=GameObject.Find("drova");
        hand=GameObject.Find("hand");

        drvTR=drova.GetComponent<Transform>();
        handTR=hand.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        PressE.SetActive(false);
        Debug.DrawRay(cam.transform.position, cam.transform.forward*4f, Color.red);
        RaycastHit touch;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out touch,4)){
            if(touch.transform.gameObject.tag=="drova"){
                PressE.SetActive(true);
                if(Input.GetKeyDown("e")){
                    PressF.SetActive(true);
                    if(drova.GetComponent<Rigidbody>()){
                        Destroy(drova.GetComponent<Rigidbody>());
                    }
                    drovaForCampfire=1;
                    drvTR.position=handTR.position;
                    drvTR.rotation=handTR.rotation;
                    drvTR.SetParent(handTR);
                }
            }
        }
        if(Input.GetKeyDown("f")){
            if(drvTR.position==handTR.position){
                PressF.SetActive(false);
                drvTR.parent=null;
                drova.AddComponent<Rigidbody>();
                drova.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*500f);
            }
        }
    }
}
