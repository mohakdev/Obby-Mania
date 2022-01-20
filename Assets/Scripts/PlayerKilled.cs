using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKilled : MonoBehaviour
{
    Vector3 NewPlayerPos;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Lava") || hit.gameObject.CompareTag("Border"))
        {
            int Level = PlayerPrefs.GetInt("Level", 0);
            GameObject Checkpoint = GameObject.Find($"{Level}");

            NewPlayerPos = Checkpoint.transform.position + new Vector3(0, 10, 0);
            //NewPlayerPos is the position the player should be in
            gameObject.transform.position = NewPlayerPos;
            //Setting the position of the player to NewPlayerPos
        }
    }
}
