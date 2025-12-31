using UnityEngine;

public class SphereShape : Shape
{
    private void Start()
    {
        ShapeName = "Blue Sphere";
        MoveSpeed = 3f;
    }

    // POLYMORPHISM
    protected override void Move()
    {
        transform.Translate(Vector3.up * MoveSpeed);
    }

    protected override void DisplayText()
    {
        Debug.Log("I am a Sphere. I move upward!");
    }
}
