using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpawnSquare spawnSquare;
    public ScoreCounter scoreCounter;
    public void OnSpacePress()
    {
        spawnSquare.InstantiateSquare();
        scoreCounter.IncreaseScore();
    }
}
