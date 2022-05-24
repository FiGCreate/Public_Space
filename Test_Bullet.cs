using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Bullet : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Player>().Damaged(5);
    }
}
