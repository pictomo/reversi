using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject board;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        (int, int) boardSize = board.GetComponent<GameManager>().boardSize;
        transform.position = new Vector3(boardSize.Item1 / 2 - 0.5f, boardSize.Item2 / 2 - 0.5f, -10);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
