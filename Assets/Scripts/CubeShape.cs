using UnityEngine;

public class CubeShape : Shape
{
    private void Start()
    {
        ShapeName = "Red Cube";
        MoveSpeed = 2f;
    }

    // POLYMORPHISM
    protected override void Move()
    {
        transform.Translate(Vector3.forward * MoveSpeed);
    }

    protected override void DisplayText()
    {
        Debug.Log("I am a Cube. I move forward!");
    }
}
