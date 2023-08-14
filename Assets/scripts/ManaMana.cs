using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaMana : MonoBehaviour
{

    public float currentMana, localChange;
    public float regenRate, regenTimer, regenValue;

    float maxMana = 1.0f;

    public GameObject manaSegOrigin;

    void Start()
    {
        currentMana = maxMana;
    }

    void Update()
    {
        if (currentMana >= maxMana)
        {
            currentMana = maxMana;
            manaSegOrigin.transform.localScale = new Vector3(currentMana, 1f, 1f);
        }

        if (Time.deltaTime > regenTimer)
        {
            if (currentMana < maxMana)
            {
                currentMana += regenValue;
                manaSegOrigin.transform.localScale = new Vector3(currentMana, 1f, 1f);

            }

            if (Input.GetMouseButtonDown(0))
            {
                localChange = -0.1f;
                ChangeCurrentMana(localChange);
            }
        }
    }

        public void ChangeCurrentMana(float incomingChange)
        {
            currentMana += incomingChange;

            if (currentMana > maxMana)
            {
                currentMana = maxMana;
            }

            if (currentMana < 0f)
            {
                currentMana = 0f;
            }

            manaSegOrigin.transform.localScale = new Vector3(currentMana, 1f, 1f);
            incomingChange = 0f;
        }
    } 
