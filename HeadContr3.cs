using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HeadContr3 : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController contr;//передвижение вперед
    public Transform playerBody;//поворот тела
    float xRotation = 0f;
    public float speed = 12f;
    int hp = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");//движение вперед\назад
        contr.Move(playerBody.forward * vertical * 12f * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X");//поворот влево вправо
        float mouseY = Input.GetAxis("Mouse Y");// поворот головы вверх вниз
        xRotation = xRotation - mouseY;
        xRotation = Math.Clamp(xRotation,-90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation,0,0);

        playerBody.Rotate(0,mouseX,0);

        float horizontal = Input.GetAxis("Horizontal");
        contr.Move(playerBody.right * speed * horizontal * Time.deltaTime);

    }

    public void harm() {
        hp = hp - 2;
        print(hp);
    }


}
