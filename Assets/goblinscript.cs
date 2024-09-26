using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goblinscript : AttackPlayer
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
    public override void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.green;

    }
    public override void AttackPlayerr()
    {
        print("goblin is attacking player");
    }
}
