using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction_WoodDumped : MonoBehaviour
{

    public Destruction_WoodScore scoreBoard;
    public int scoreIncrease;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Woodchops"))
        {
            var woodScored = other.GetComponent<Destruction_WoodScored>();
            if (woodScored.addedScore == false)
            {
                scoreBoard.AddScore(scoreIncrease);
                woodScored.addedScore = true;
                Destroy(other.gameObject, 1);
            }
        }
    }

}
