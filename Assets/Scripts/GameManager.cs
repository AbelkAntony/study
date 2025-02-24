using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    private int firstNumber = 10;
    private int secondNumber = 5;
    private string[] students = {    "ABEL K ANTONY" , 
                                    "ABEL ABRAHAM TITUS", 
                                    "ADITYA E AJITH ",
                                    "ASHMIN",
                                    "SAI",
                                    "SREEYAS",
                                    "SREEJITH",
                                    "SHABARINATH",
                                    "ZABRAN",
                                    "JORDIN",
                                    "SHYAM",
                                    "UDIT",
                                    "DEVANARAYANAN"};


    void Start()
    {
        //DontDestroyOnLoad(this);
        //Addition();
        //Subtraction();
        //Multiplication();
        SendMessageUsingForeach();
        SendMessageUsingForLoop();  
    }

    void Addition()
    {
        int addition = firstNumber + secondNumber;
        print(firstNumber + "+" + secondNumber + "=" + addition);
    }

    void Subtraction()
    {
        int substraction = firstNumber - secondNumber;
        print(firstNumber + "-" + secondNumber + "=" + substraction);
    }

    void Multiplication()
    {
        int multiplication = firstNumber * secondNumber;
        print(firstNumber + "*" + secondNumber + "=" + multiplication);
    }

    void SendMessageUsingForeach()
    {
        foreach(string student in students)
        {
            print(student + " come and meet me");
        }
    }
  
    void SendMessageUsingForLoop()
    {
        for(int i =0;i>students.Length;i++)
        {
            print(students[i] + "call me urgently");
        }
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }
    public void LoadSplashScene()
    {
        SceneManager.LoadScene("SplashScene");
    }
    public void LoadInstructionScene()
    {
        SceneManager.LoadScene("InstructioScene");
    }

}
