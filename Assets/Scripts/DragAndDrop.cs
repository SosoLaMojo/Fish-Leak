using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool moveAllowed;

    private Collider2D triggerCollider;
    
    // Start is called before the first frame update
    void Start()
    {
        triggerCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);

                if (triggerCollider == touchedCollider)
                {
                    moveAllowed = true;
                }
            }

            if (touch.phase == TouchPhase.Moved && moveAllowed)
            {
                transform.position = new Vector2(touchPosition.x, touchPosition.y);
            }

            if (touch.phase == TouchPhase.Ended)
            {
                moveAllowed = false;
            }
        }
    }
}
