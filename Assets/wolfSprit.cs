using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfSprit : AttackPlayer
{
    // Start is called before the first frame update
    void Start()
    {
        AttackPlayerr();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void AttackPlayerr()
    {
        print("wereWolf is attacking player");
    }
}
