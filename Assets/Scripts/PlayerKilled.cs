using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKilled : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Lava"))
        {
            Debug.Log("Lava Touched");
        }
    }
}
