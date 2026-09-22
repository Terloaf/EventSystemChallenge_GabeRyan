using UnityEngine;

public class SpawnSquare : MonoBehaviour
{
    public GameObject square;


    public void InstantiateSquare()
    {
        Instantiate(square);
    }
}
