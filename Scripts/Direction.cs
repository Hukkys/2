using UnityEngine;


public class Direction : MonoBehaviour
{
    public Camera _camera;
    [SerializeField] private InputControl input;
    public bool directionForward;


    public void Update()
    {
        DirectionF();
    }

    public void DirectionF()
    {
        var mousePos = _camera.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float PosX = Mathf.Sign(mousePos.x);
        transform.rotation = Quaternion.Euler(0, 90 * PosX, 0);

        if (PosX == Mathf.Sign(input.AxisHorizontalMove))
        {
            directionForward = true;
        }
        else directionForward = false;
    }


}