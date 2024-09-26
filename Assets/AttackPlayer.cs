using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AttackPlayerr();
        GetComponent<SpriteRenderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseOver()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.red;
        AttackPlayerr();
    }
    public virtual void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.white;
        
    }
    public virtual void AttackPlayerr()
    {
        print("Enemy is attacking player");
    }
}
