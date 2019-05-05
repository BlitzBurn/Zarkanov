using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMasterScript : MonoBehaviour
{
    public MovementController movementController;
    private bool combatMode;

    void Start()
    {
        movementController = GetComponent<MovementController>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&combatMode==false)
        {
            movementController.enabled = false;
            combatMode = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space)&&combatMode==true)
        {
            movementController.enabled = true;
            combatMode = false;
        }
    }
}
