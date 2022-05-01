using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Variables.Scripts.VariableBase.Variables;

public class InputManager : MonoBehaviour
{
#region Public
    public LayerMask UILayer = 10;
    public FloatVariable snappiness;
    public Vector2Variable inputDirection;
    #endregion
    #region Private
    private Vector3 _initialMousePosition; 
    private Vector2 lastPosition;
    private Vector2 mouseOrigin;
    private Vector2 lastDeltaX;
    #endregion
    void Update()
    {
        GetInputDisplacement();
        inputDirection.Value = mouseOrigin;
        Debug.DrawRay(transform.position,(new Vector3(inputDirection.Value.x,0,inputDirection.Value.y).normalized *10),Color.red);
    }
    bool IsTappingAUIElement()
    {
        return IsPointerOverUIElement(GetEventSystemRaycastResults());
    }
    private bool IsPointerOverUIElement(List<RaycastResult> eventSystemRaysastResults)
    {
        for (int index = 0; index < eventSystemRaysastResults.Count; index++)
        {
            RaycastResult curRaysastResult = eventSystemRaysastResults[index];
            if (curRaysastResult.gameObject.layer == UILayer)
                return true;
        }
        return false;
    }

    static List<RaycastResult> GetEventSystemRaycastResults()
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = Input.mousePosition;
        List<RaycastResult> raysastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, raysastResults);
        return raysastResults;
    }

    private void GetInputDisplacement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastPosition = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
            float deltaX = (Input.mousePosition.x - lastPosition.x) / Screen.width;
            float deltaY = (Input.mousePosition.y - lastPosition.y) / Screen.height;
            Vector2 delta = new Vector2(deltaX, deltaY);
            lastDeltaX = delta;
        }
        else if (Input.GetMouseButton(0))
        {
            float deltaX = (Input.mousePosition.x - lastPosition.x) / Screen.width;
            float deltaY = (Input.mousePosition.y - lastPosition.y) / Screen.height;
            Vector2 delta = new Vector2(deltaX, deltaY);
            lastDeltaX = Vector2.Lerp(lastDeltaX, delta, snappiness.Value);
            mouseOrigin = new Vector2(lastDeltaX.x, lastDeltaX.y);
            lastPosition = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            mouseOrigin.x = 0;
            mouseOrigin.y = 0;
        }
    }
}
