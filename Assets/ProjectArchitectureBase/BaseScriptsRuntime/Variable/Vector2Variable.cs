using UnityEngine;
using ProjectArchitectureBase.BaseScriptsRuntime.Event;

namespace Variables.Scripts.VariableBase.Variables
{
    [CreateAssetMenu(menuName = "Variables/vector2", fileName = "Vector2Variable")]
    public class Vector2Variable : Variable<Vector2,Vector2Event>
    {  
    }
}
