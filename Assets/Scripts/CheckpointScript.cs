using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    int CurrentLevel;

    Vector3 NewPlayerPos;
    void OnControllerColliderHit(ControllerColliderHit hit)
    {

        int NextLevel = CurrentLevel + 1;
        string checkpointName = hit.gameObject.name;

        if (hit.gameObject.CompareTag("Checkpoint"))
        {
            if (NextLevel.Equals(int.Parse(checkpointName)))
            {
                CurrentLevel = NextLevel;
                PlayerPrefs.SetInt("Level", CurrentLevel);
            }
        }
    }
    private void Awake()
    {
        int Level = PlayerPrefs.GetInt("Level", 0);
        GameObject Checkpoint = GameObject.Find($"{Level}");

        NewPlayerPos = Checkpoint.transform.position + new Vector3(0, 10, 0);
        //NewPlayerPos is the position the player should be in
        gameObject.transform.position = NewPlayerPos;
        //Setting the position of the player to NewPlayerPos
    }

}
