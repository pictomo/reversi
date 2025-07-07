using UnityEngine;

public class GameManager : MonoBehaviour
{
    public (int, int) boardSize = (8, 8);
    int[,] board;

    [SerializeField] GameObject square;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        board = new int[boardSize.Item1, boardSize.Item2];
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Instantiate(square, new Vector3(i, j, 0), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
