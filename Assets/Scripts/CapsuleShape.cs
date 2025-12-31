using UnityEngine;

public class CapsuleShape : Shape
{
    private void Start()
    {
        ShapeName = "Green Capsule";
        MoveSpeed = 1.5f;
    }

    // POLYMORPHISM
    protected override void Move()
    {
        transform.Translate(Vector3.right * MoveSpeed);
    }

    protected override void DisplayText()
    {
        Debug.Log("I am a Capsule. I move sideways!");
    }
}
