using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cooldown : MonoBehaviour
{
    [SerializeField] Image CoolDown;
    [SerializeField] float actualCooldown;
    bool isCooldown;
    int baseCooldown = 20;
    int secondPerFish = 2;
    [SerializeField] int fish;

    void Update()
    {
        if (isCooldown)
        {
            CoolDown.fillAmount += 1 / actualCooldown * Time.deltaTime;
        }
        if (CoolDown.fillAmount >= 1)
        {
            CoolDown.fillAmount = 0;
            isCooldown = false;
        }
    }
    public void cooldownRepulsif()
    {
        if (!isCooldown)
        {
            actualCooldown = baseCooldown - secondPerFish * fish;
            isCooldown = true;
        }
    }
    public void addFish()
    {
        fish += 1;
    }
}
