using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public Dice dice;
    public bool CanMove;

    // Start is called before the first frame update
    void Start()
    {
        dice = FindObjectOfType<Dice>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
