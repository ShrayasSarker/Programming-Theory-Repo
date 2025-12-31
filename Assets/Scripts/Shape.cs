using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    
    // ENCAPSULATION
    
    private string shapeName;
    private float moveSpeed = 2f;

    public string ShapeName
    {
        get { return shapeName; }
        protected set
        {
            if (value.Length < 20)
                shapeName = value;
        }
    }

    public float MoveSpeed
    {
        get { return moveSpeed; }
        protected set
        {
            if (value > 0)
                moveSpeed = value;
        }
    }

    
    // ABSTRACTION
    
    protected virtual void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckClick();
        }
    }

    private void CheckClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform == transform)
            {
                Interact();
            }
        }
    }

    protected void Interact()
    {
        DisplayText();
        Move();
    }

    
    // INHERITANCE + POLYMORPHISM
    
    protected abstract void Move();
    protected abstract void DisplayText();
}
