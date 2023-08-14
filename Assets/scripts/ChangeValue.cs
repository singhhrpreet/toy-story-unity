using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeValue : MonoBehaviour
{
    public int Value;
    public bool isDamage;

    void Start()
    {
        if (isDamage)
        {
            Value = -Value;
            gameObject.tag = "PlayerHurt";
        }

        else
        {
            gameObject.tag = "PlayerHeal";
        }
    }

    void Update()
    {
        
    }
}
