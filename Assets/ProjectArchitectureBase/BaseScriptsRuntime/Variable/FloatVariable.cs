using UnityEngine;
using ProjectArchitectureBase.BaseScriptsRuntime.Event;

namespace Variables.Scripts.VariableBase.Variables
{
    [CreateAssetMenu(menuName = "Variables/float", fileName = "FloatVariable")]
    public class FloatVariable : Variable<float,FloatEvent>
    {  
    }
}
