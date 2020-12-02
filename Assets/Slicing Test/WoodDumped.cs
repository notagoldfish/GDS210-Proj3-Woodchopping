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
            print("the tag is woodchops");
            var woodScored = other.GetComponent<WoodScored>();
            if (woodScored.addedScore == false)
            {
                print("the woodscored.addedscore does equal false");
                scoreBoard.AddScore(scoreIncrease);
                woodScored.addedScore = true;
                Destroy(other.gameObject, 1);
            }
        }
    }

}
