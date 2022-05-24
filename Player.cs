using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int hp = 0;
    public void Damaged(int damage_value)
    {
        hp -= damage_value;
        if (hp <= 0) Destroy(gameObject);
    }
}
