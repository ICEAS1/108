using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    int exit=0;
    string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        sceneName=SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape")){
            PlayerPrefs.SetString("nameLevel",sceneName);
            SceneManager.LoadScene("menu");
        }
    }
    public void GameStart(){
        SceneManager.LoadScene("SampleScene");
    }
    public void GameExit(){
        exit=exit+1;
        if(exit==1){
            print("Не надо выходить, останься, поиграй в меня!");
        }
        if(exit==2){
            print("Ну же поиграй в меня!");
        }
        if(exit==3){
            print("ПОИГРАЙ!");
        }
        if(exit==4){
            print("... ну пожалуйста");
        }
        if(exit==5){
            print("Мой создатель потратил кучу времени на меня...");
        }
        if(exit==6){
            print("^u^ я не позволю тебе выйти из меня не поиграв");
        }
        if(exit==7){
            print("игра не доделана, я потратил кучу сил на не рабочую механику, в любом случае приятной игры) кое-что еще");
        }
        if(exit==8){
            print("голова иногда работает неправильно...");
            exit=exit-exit;
        }
    }
}
