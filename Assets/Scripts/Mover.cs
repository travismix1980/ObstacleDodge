using UnityEngine;

public class Mover : MonoBehaviour
{

    private float xVal = 0;
    private float yVal = 0;
    private float zVal = 0;
    [SerializeField] private float moveSpeed = 10f;
    void Start()
    {

    }

    void Update()
    {
        xVal = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        zVal = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xVal, yVal, zVal);
    }
}
