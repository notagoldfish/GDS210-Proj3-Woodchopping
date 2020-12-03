using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodDumped : MonoBehaviour
{

    public WoodScore scoreBoard;
    public int scoreIncrease;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Woodchops"))
        {
            var woodScored = other.GetComponent<WoodScored>();
            if (woodScored.addedScore == false)
            {
                scoreBoard.AddScore(scoreIncrease);
                woodScored.addedScore = true;
                Destroy(other.gameObject, 1);
            }
        }
    }

}
