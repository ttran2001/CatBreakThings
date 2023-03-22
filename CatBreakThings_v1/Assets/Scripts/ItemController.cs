using UnityEngine;
using System.Collections;

public class ItemController : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    private bool mIsColliding;
    private float mInitialZPosition;

    private void Start()
    {
        mInitialZPosition = transform.position.z;
    }

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        var mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, mZCoord);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + mOffset;

        curPosition.z = mInitialZPosition; 

        if (mIsColliding)
        {
            curPosition.z = mInitialZPosition; // set z position to initial z position
        }

        transform.position = curPosition;
    }
}