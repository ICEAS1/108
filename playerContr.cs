using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerContr : MonoBehaviour
{
    // Start is called before the first frame update
    // [SerializeField] TextMeshProUGUI Tdrova;
    // [SerializeField] TextMeshProUGUI Tteplo;
    // [SerializeField] TextMeshProUGUI Thp;
    public CharacterController contr;
    int hp =100;
    int drova=0;
    int teplo=20;

    int drovaMax=8;

    public GameObject handContr;

    

    float speed =12f;
    float vertical;
    float horizontal;
    void Start()
    {
        contr=GetComponent<CharacterController>();
        InvokeRepeating("forInvoke",0,1f);
        handContr=GameObject.Find("hand");
        
    }
    void forInvoke(){
        teplo=teplo-1;
        print(teplo);
        if(teplo==0||teplo<0){
            hp=hp-1;
            print(hp);
        }
    }
    // Update is called once per frame
    void Update()
    {
        vertical=Input.GetAxis("Vertical");
        horizontal=Input.GetAxis("Horizontal");

        contr.Move(transform.forward*speed*vertical*Time.deltaTime);
        contr.Move(transform.right*speed*horizontal*Time.deltaTime);

        if(drova>drovaMax){
            drova=drovaMax;
        }
        if(hp==99){
            print("холодно");
        }

    }
    void OnControllerColliderHit(ControllerColliderHit CCH){
        if(CCH.transform.tag=="drova"){
            drova=drova+1;
            print(drova);
            Destroy(CCH.gameObject);
        }
        if(CCH.transform.tag=="campfire"){
            if(drova<8){
                print("не хватает");
            }
            if(drova==8){
                print("достаточно");
                CancelInvoke();
            }
        }
        
    }
}

