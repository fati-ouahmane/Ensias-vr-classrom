using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class script : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Canvas;
    public GameObject choice1;
    public GameObject choice2;
    public int TheOne;

    public GameObject choice3;
    public int choicemade;
    
    public void choiceOption1(){
        TextBox.GetComponent<Text>().text=" please go to the next classs  where  you can find the material.";
        choicemade=1;
        TheOne=0;
    }
       public void choiceOption2(){
        TextBox.GetComponent<Text>().text="Hi teacher you can start your lesson you are in the right class .";
        choicemade=2; 
        TheOne=2; 
    }
       public void choiceOption3(){
        TextBox.GetComponent<Text>().text=" please go to the exam's class the students are waiting for you.";
        choicemade=3;
        TheOne=3;
    }
    public void hide(){
        if (TheOne==2){
            Canvas.SetActive(false);
         }

    }
    void Update()
    {
        if (choicemade>=1){
            choice1.SetActive(false);
            choice2.SetActive(false);
            choice3.SetActive(false);

        }
        
}
}