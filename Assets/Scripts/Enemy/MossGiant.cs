using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MossGiant : Enemy, IDamageable
{
    public int Health { get; set; }
    

    //use this for initialization
    public override void Init()
    {
        base.Init();
        
    }
    public void Damage()
    {

    }
}
