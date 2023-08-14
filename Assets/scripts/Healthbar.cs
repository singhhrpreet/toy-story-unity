using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    int HealthCurrent;

    public int HealthMax = 3;
    public MeshRenderer HealthSeg1, HealthSeg2, HealthSeg3;
    public Material MatHurt, MatHeal;

    // Start is called before the first frame update
    void Start()
    {
        HealthCurrent = HealthMax;
    }

    public void HealthUpdate(int HealthChange)
    {
        HealthCurrent += HealthChange;

        if(HealthCurrent > HealthMax)
        {
            HealthCurrent = HealthMax;
        }

        if(HealthCurrent <= 0)
        {
            //FailState
        }

        switch(HealthCurrent)
        {
            case 1:
                HealthSeg1.material = MatHeal;
                HealthSeg2.material = MatHurt;
                HealthSeg3.material = MatHurt;
                break;

            case 2:
                HealthSeg1.material = MatHeal;
                HealthSeg2.material = MatHeal;
                HealthSeg3.material = MatHurt;
                break;

            case 3:
                HealthSeg1.material = MatHeal;
                HealthSeg2.material = MatHeal;
                HealthSeg3.material = MatHeal;
                break;

            default:
                HealthSeg1.material = MatHurt;
                HealthSeg2.material = MatHurt;
                HealthSeg3.material = MatHurt;
                break;
        }
    }
}
