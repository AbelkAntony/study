using UnityEngine;

public class Enemy
{
    public string name;
    public int life;
    public int attackPower;
    public int defendingPower;

    public void Attack()
    {
        Debug.Log( name + "attacked " + attackPower);
    }
    public void Defend()
    {
        Debug.Log(name + "Defend " + defendingPower);
    }

}
