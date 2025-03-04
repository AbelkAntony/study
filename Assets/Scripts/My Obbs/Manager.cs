using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] private int life;
    [SerializeField] public int power;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Joker jokerOne = new Joker();
        jokerOne.name = "Joker";
        jokerOne.attackPower = 10;
        jokerOne.defendingPower = 5;
        jokerOne.Attack();
        jokerOne.Defend();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
